﻿using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using X14 = DocumentFormat.OpenXml.Office2010.Excel;
using X15 = DocumentFormat.OpenXml.Office2013.Excel;


using Models;
using Portal.Models.Utils;
using Portal.Services;
using Refit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Text;

namespace Portal.Views
{
	public partial class FrmLancamentosDiarios : Form
	{
		public FrmLancamentosDiarios()
		{
			InitializeComponent();
		}

		private async void FrmLancamentosDiarios_LoadAsync(object sender, EventArgs e)
		{
			var itensUsuarios = await HttpClientManager.GetInstance.UsersController.List();

			var itensDisplay = new List<UsuarioModel>()
			{
				new UsuarioModel()
				{
					Email = "(Todos)",
					IdUsuario = ""
				}
			};
			itensDisplay.AddRange(itensUsuarios);

			CboEmails.DataSource = itensDisplay;
			CboEmails.DisplayMember = "Email";
			CboEmails.ValueMember = "IdUsuario";

			var itensTpLancamento = new List<ItemComboBox>
			{
				new ItemComboBox() { Text = "(Todos)", Value = "0" },
				new ItemComboBox() { Text = "Débito", Value = "1" },
				new ItemComboBox() { Text = "Crédito", Value = "2" }
			};

			CboTpLancamento.DataSource = itensTpLancamento;
			CboTpLancamento.DisplayMember = "Text";
			CboTpLancamento.ValueMember = "Value";
			CboTpLancamento.SelectedIndex = 0;

			DtInicial.Value = DateTime.Today;
			DtFinal.Value = DateTime.Today;
			LblValorConsolidado.Text = "Valor Consolidado: " + string.Format(CultureInfo.CreateSpecificCulture("pt-BR"), "{0:C2}", 0);
		}

		private void TxtValor_TextChanged(object sender, EventArgs e)
		{
			string value = TxtValor.Text.Replace(",", "")
				.Replace("R$", "")
				.Replace(".", "")
				.TrimStart('0');

			if (decimal.TryParse(value, out decimal ul))
			{
				ul /= 100;
				TxtValor.TextChanged -= new EventHandler(TxtValor_TextChanged);
				TxtValor.Text = string.Format(CultureInfo.CreateSpecificCulture("pt-BR"), "{0:C2}", ul);
				TxtValor.TextChanged += new EventHandler(TxtValor_TextChanged);
				TxtValor.Select(TxtValor.Text.Length, 0);
			}
			else
			{
				TxtValor.Text = "R$0.00";
				TxtValor.Select(TxtValor.Text.Length, 0);
			}
		}

		private async void BtnPesquisar_Click(object sender, EventArgs e)
		{
			try
			{
				Enabled = false;


				var AppUserId = CboEmails.SelectedValue.ToString();
				var TipoLancamento = Convert.ToByte(CboTpLancamento.SelectedValue);

				var DataInicio = DtInicial.Value;
				var DataTermino = DtFinal.Value;

				decimal ul = 0;
				string value = TxtValor.Text.Replace(",", "")
				.Replace("R$", "")
				.Replace(".", "")
				.TrimStart('0');

				decimal.TryParse(value, out ul);
				ul /= 100;

				var itens = await HttpClientManager.GetInstance
													.LancamentosController
													.Query(new LancamentoQueryModel()
													{
														AppUserId = AppUserId,
														TipoLancamento = TipoLancamento,
														DataInicio = DataInicio,
														DataTermino = DataTermino,
														Valor = ul
													});

				GvResultado.AutoGenerateColumns = false;
				GvResultado.DataSource = itens;

				var valorConsolidado = itens.Where(X => X.TipoLancamento == 1).Sum(X => X.Valor) - itens.Where(X => X.TipoLancamento == 2).Sum(X => X.Valor);

				LblValorConsolidado.Text = "Valor Consolidado: " + string.Format(CultureInfo.CreateSpecificCulture("pt-BR"), "{0:C2}", valorConsolidado);

			}
			catch (ApiException apiEx)
			{
				MessageBox.Show("Ocorreu um erro durante a o acesso a consulta," +
					" por favor entrar em contato com o suporte.",
					"Ocorreu um erro durante a solicitação.",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			finally
			{
				Enabled = true;
			}
		}

		private void BtnExportar_Click(object sender, EventArgs e)
		{
			try
			{
				Enabled = false;

				DataTable data = new DataTable();
				foreach (DataGridViewColumn column in GvResultado.Columns)
				{
					data.Columns.Add(column.HeaderText, column.ValueType);
				}

				foreach (DataGridViewRow row in GvResultado.Rows)
				{
					data.Rows.Add();
					foreach (DataGridViewCell cell in row.Cells)
					{
						data.Rows[data.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
					}
				}

				var fi = new SaveFileDialog()
				{
					Filter = "CSV files (*.csv)|*.csv|Excel Files|*.xlsx"
				};

				if (fi.ShowDialog() == DialogResult.OK)
				{
					if (fi.FileName.Contains(".xls"))
					{
						using (SpreadsheetDocument package = SpreadsheetDocument.Create(fi.FileName, SpreadsheetDocumentType.Workbook))
						{
							ToDatatable(package, data);
						}
					}
					else
					{
						ToCSV(data, fi.FileName);
					}

					MessageBox.Show("Relatório exportado com sucesso.",
							"Lançamentos Diarios",
							MessageBoxButtons.OK,
							MessageBoxIcon.Information);
				}
			}
			catch (ApiException apiEx)
			{
				MessageBox.Show("Ocorreu um erro durante a o acesso a consulta," +
					" por favor entrar em contato com o suporte.",
					"Ocorreu um erro durante a solicitação.",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			finally
			{
				Enabled = true;
			}
		}

		public void ToCSV(DataTable dtDataTable, string filepath)
		{
			StreamWriter sw = new StreamWriter(filepath, false, new UTF8Encoding(false));
			//headers
			for (int i = 0; i < dtDataTable.Columns.Count; i++)
			{
				sw.Write(dtDataTable.Columns[i]);
				if (i < dtDataTable.Columns.Count - 1)
				{
					sw.Write(",");
				}
			}
			sw.Write(sw.NewLine);
			foreach (DataRow dr in dtDataTable.Rows)
			{
				for (int i = 0; i < dtDataTable.Columns.Count; i++)
				{
					if (!Convert.IsDBNull(dr[i]))
					{
						string value = dr[i].ToString();
						if (value.Contains(','))
						{
							value = String.Format("\"{0}\"", value);
							sw.Write(value);
						}
						else
						{
							sw.Write(dr[i].ToString());
						}
					}
					if (i < dtDataTable.Columns.Count - 1)
					{
						sw.Write(",");
					}
				}
				sw.Write(sw.NewLine);
			}
			sw.Close();
		}

		private void ToDatatable(SpreadsheetDocument document, DataTable data)
		{
			SheetData partSheetData = GenerateSheetdataForDetails(data);

			WorkbookPart workbookPart1 = document.AddWorkbookPart();
			GenerateWorkbookPartContent(workbookPart1);

			WorkbookStylesPart workbookStylesPart1 = workbookPart1.AddNewPart<WorkbookStylesPart>("rId3");
			GenerateWorkbookStylesPartContent(workbookStylesPart1);

			WorksheetPart worksheetPart1 = workbookPart1.AddNewPart<WorksheetPart>("rId1");
			GenerateWorksheetPartContent(worksheetPart1, partSheetData);
		}

		private SheetData GenerateSheetdataForDetails(DataTable data)
		{
			SheetData sheetData1 = new SheetData();
			sheetData1.Append(CreateHeaderRowForExcel(data));

			for (int i = 0; i < data.Rows.Count; i++)
			{
				Row partsRows = GenerateRowForChildPartDetail(data.Rows[i]);
				sheetData1.Append(partsRows);
			}

			return sheetData1;
		}

		private Row CreateHeaderRowForExcel(DataTable dt)
		{
			Row workRow = new Row();
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				workRow.Append(CreateCell(dt.Columns[i].ColumnName, 2U));
			}
			return workRow;
		}

		private Row GenerateRowForChildPartDetail(DataRow testmodel)
		{
			Row tRow = new Row();

			for (int i = 0; i < testmodel.Table.Columns.Count; i++)
			{
				var columnName = testmodel.Table.Columns[i].ColumnName;
				tRow.Append(CreateCell(testmodel[columnName].ToString()));
			}

			return tRow;
		}

		private Cell CreateCell(string text)
		{
			Cell cell = new Cell();
			cell.StyleIndex = 1U;
			cell.DataType = ResolveCellDataTypeOnValue(text);
			cell.CellValue = new CellValue(text);
			return cell;
		}

		private Cell CreateCell(string text, uint styleIndex)
		{
			Cell cell = new Cell();
			cell.StyleIndex = styleIndex;
			cell.DataType = ResolveCellDataTypeOnValue(text);
			cell.CellValue = new CellValue(text);
			return cell;
		}

		private EnumValue<CellValues> ResolveCellDataTypeOnValue(string text)
		{
			int intVal;
			double doubleVal;
			if (int.TryParse(text, out intVal) || double.TryParse(text, out doubleVal))
			{
				return CellValues.Number;
			}
			else
			{
				return CellValues.String;
			}
		}

		private void GenerateWorkbookPartContent(WorkbookPart workbookPart1)
		{
			Workbook workbook1 = new Workbook();
			Sheets sheets1 = new Sheets();
			Sheet sheet1 = new Sheet() { Name = "Sheet1", SheetId = (UInt32Value)1U, Id = "rId1" };
			sheets1.Append(sheet1);
			workbook1.Append(sheets1);
			workbookPart1.Workbook = workbook1;
		}

		private void GenerateWorksheetPartContent(WorksheetPart worksheetPart1, SheetData sheetData1)
		{
			Worksheet worksheet1 = new Worksheet() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "x14ac" } };
			worksheet1.AddNamespaceDeclaration("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
			worksheet1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
			worksheet1.AddNamespaceDeclaration("x14ac", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac");
			SheetDimension sheetDimension1 = new SheetDimension() { Reference = "A1" };

			SheetViews sheetViews1 = new SheetViews();

			SheetView sheetView1 = new SheetView() { TabSelected = true, WorkbookViewId = (UInt32Value)0U };
			Selection selection1 = new Selection() { ActiveCell = "A1", SequenceOfReferences = new ListValue<StringValue>() { InnerText = "A1" } };

			sheetView1.Append(selection1);

			sheetViews1.Append(sheetView1);
			SheetFormatProperties sheetFormatProperties1 = new SheetFormatProperties() { DefaultRowHeight = 15D, DyDescent = 0.25D };

			PageMargins pageMargins1 = new PageMargins() { Left = 0.7D, Right = 0.7D, Top = 0.75D, Bottom = 0.75D, Header = 0.3D, Footer = 0.3D };
			worksheet1.Append(sheetDimension1);
			worksheet1.Append(sheetViews1);
			worksheet1.Append(sheetFormatProperties1);
			worksheet1.Append(sheetData1);
			worksheet1.Append(pageMargins1);
			worksheetPart1.Worksheet = worksheet1;
		}

		private void GenerateWorkbookStylesPartContent(WorkbookStylesPart workbookStylesPart1)
		{
			Stylesheet stylesheet1 = new Stylesheet() { MCAttributes = new MarkupCompatibilityAttributes() { Ignorable = "x14ac" } };
			stylesheet1.AddNamespaceDeclaration("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
			stylesheet1.AddNamespaceDeclaration("x14ac", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/ac");

			Fonts fonts1 = new Fonts() { Count = (UInt32Value)2U, KnownFonts = true };

			Font font1 = new Font();
			FontSize fontSize1 = new FontSize() { Val = 11D };
			Color color1 = new Color() { Theme = (UInt32Value)1U };
			FontName fontName1 = new FontName() { Val = "Calibri" };
			FontFamilyNumbering fontFamilyNumbering1 = new FontFamilyNumbering() { Val = 2 };
			FontScheme fontScheme1 = new FontScheme() { Val = FontSchemeValues.Minor };

			font1.Append(fontSize1);
			font1.Append(color1);
			font1.Append(fontName1);
			font1.Append(fontFamilyNumbering1);
			font1.Append(fontScheme1);

			Font font2 = new Font();
			Bold bold1 = new Bold();
			FontSize fontSize2 = new FontSize() { Val = 11D };
			Color color2 = new Color() { Theme = (UInt32Value)1U };
			FontName fontName2 = new FontName() { Val = "Calibri" };
			FontFamilyNumbering fontFamilyNumbering2 = new FontFamilyNumbering() { Val = 2 };
			FontScheme fontScheme2 = new FontScheme() { Val = FontSchemeValues.Minor };

			font2.Append(bold1);
			font2.Append(fontSize2);
			font2.Append(color2);
			font2.Append(fontName2);
			font2.Append(fontFamilyNumbering2);
			font2.Append(fontScheme2);

			fonts1.Append(font1);
			fonts1.Append(font2);

			Fills fills1 = new Fills() { Count = (UInt32Value)2U };

			Fill fill1 = new Fill();
			PatternFill patternFill1 = new PatternFill() { PatternType = PatternValues.None };

			fill1.Append(patternFill1);

			Fill fill2 = new Fill();
			PatternFill patternFill2 = new PatternFill() { PatternType = PatternValues.Gray125 };

			fill2.Append(patternFill2);

			fills1.Append(fill1);
			fills1.Append(fill2);

			Borders borders1 = new Borders() { Count = (UInt32Value)2U };

			Border border1 = new Border();
			LeftBorder leftBorder1 = new LeftBorder();
			RightBorder rightBorder1 = new RightBorder();
			TopBorder topBorder1 = new TopBorder();
			BottomBorder bottomBorder1 = new BottomBorder();
			DiagonalBorder diagonalBorder1 = new DiagonalBorder();

			border1.Append(leftBorder1);
			border1.Append(rightBorder1);
			border1.Append(topBorder1);
			border1.Append(bottomBorder1);
			border1.Append(diagonalBorder1);

			Border border2 = new Border();

			LeftBorder leftBorder2 = new LeftBorder() { Style = BorderStyleValues.Thin };
			Color color3 = new Color() { Indexed = (UInt32Value)64U };

			leftBorder2.Append(color3);

			RightBorder rightBorder2 = new RightBorder() { Style = BorderStyleValues.Thin };
			Color color4 = new Color() { Indexed = (UInt32Value)64U };

			rightBorder2.Append(color4);

			TopBorder topBorder2 = new TopBorder() { Style = BorderStyleValues.Thin };
			Color color5 = new Color() { Indexed = (UInt32Value)64U };

			topBorder2.Append(color5);

			BottomBorder bottomBorder2 = new BottomBorder() { Style = BorderStyleValues.Thin };
			Color color6 = new Color() { Indexed = (UInt32Value)64U };

			bottomBorder2.Append(color6);
			DiagonalBorder diagonalBorder2 = new DiagonalBorder();

			border2.Append(leftBorder2);
			border2.Append(rightBorder2);
			border2.Append(topBorder2);
			border2.Append(bottomBorder2);
			border2.Append(diagonalBorder2);

			borders1.Append(border1);
			borders1.Append(border2);

			CellStyleFormats cellStyleFormats1 = new CellStyleFormats() { Count = (UInt32Value)1U };
			CellFormat cellFormat1 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U };

			cellStyleFormats1.Append(cellFormat1);

			CellFormats cellFormats1 = new CellFormats() { Count = (UInt32Value)3U };
			CellFormat cellFormat2 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)0U, FormatId = (UInt32Value)0U };
			CellFormat cellFormat3 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)0U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyBorder = true };
			CellFormat cellFormat4 = new CellFormat() { NumberFormatId = (UInt32Value)0U, FontId = (UInt32Value)1U, FillId = (UInt32Value)0U, BorderId = (UInt32Value)1U, FormatId = (UInt32Value)0U, ApplyFont = true, ApplyBorder = true };

			cellFormats1.Append(cellFormat2);
			cellFormats1.Append(cellFormat3);
			cellFormats1.Append(cellFormat4);

			CellStyles cellStyles1 = new CellStyles() { Count = (UInt32Value)1U };
			CellStyle cellStyle1 = new CellStyle() { Name = "Normal", FormatId = (UInt32Value)0U, BuiltinId = (UInt32Value)0U };

			cellStyles1.Append(cellStyle1);
			DifferentialFormats differentialFormats1 = new DifferentialFormats() { Count = (UInt32Value)0U };
			TableStyles tableStyles1 = new TableStyles() { Count = (UInt32Value)0U, DefaultTableStyle = "TableStyleMedium2", DefaultPivotStyle = "PivotStyleLight16" };

			StylesheetExtensionList stylesheetExtensionList1 = new StylesheetExtensionList();

			StylesheetExtension stylesheetExtension1 = new StylesheetExtension() { Uri = "{EB79DEF2-80B8-43e5-95BD-54CBDDF9020C}" };
			stylesheetExtension1.AddNamespaceDeclaration("x14", "http://schemas.microsoft.com/office/spreadsheetml/2009/9/main");
			X14.SlicerStyles slicerStyles1 = new X14.SlicerStyles() { DefaultSlicerStyle = "SlicerStyleLight1" };

			stylesheetExtension1.Append(slicerStyles1);

			StylesheetExtension stylesheetExtension2 = new StylesheetExtension() { Uri = "{9260A510-F301-46a8-8635-F512D64BE5F5}" };
			stylesheetExtension2.AddNamespaceDeclaration("x15", "http://schemas.microsoft.com/office/spreadsheetml/2010/11/main");
			X15.TimelineStyles timelineStyles1 = new X15.TimelineStyles() { DefaultTimelineStyle = "TimeSlicerStyleLight1" };

			stylesheetExtension2.Append(timelineStyles1);

			stylesheetExtensionList1.Append(stylesheetExtension1);
			stylesheetExtensionList1.Append(stylesheetExtension2);

			stylesheet1.Append(fonts1);
			stylesheet1.Append(fills1);
			stylesheet1.Append(borders1);
			stylesheet1.Append(cellStyleFormats1);
			stylesheet1.Append(cellFormats1);
			stylesheet1.Append(cellStyles1);
			stylesheet1.Append(differentialFormats1);
			stylesheet1.Append(tableStyles1);
			stylesheet1.Append(stylesheetExtensionList1);

			workbookStylesPart1.Stylesheet = stylesheet1;
		}
	}
}
