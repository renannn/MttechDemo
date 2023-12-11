using Models;
using Portal.Models.Utils;
using Portal.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal.Views
{
	public partial class FrmAddLancamento : Form
	{
		public FrmAddLancamento()
		{
			InitializeComponent();
		}

		private void FrmAddLancamento_Load(object sender, EventArgs e)
		{
			var itensTpLancamento = new List<ItemComboBox>
			{
				new ItemComboBox() { Text = "Débito", Value = "1" },
				new ItemComboBox() { Text = "Crédito", Value = "2" }
			};

			CboTpLancamento.DataSource = itensTpLancamento;
			CboTpLancamento.DisplayMember = "Text";
			CboTpLancamento.ValueMember = "Value";
			CboTpLancamento.SelectedIndex = 0;
		}

		private void TxtValor_TextChanged(object sender, EventArgs e)
		{

			string value = TxtValor.Text.Replace(",", "")
				.Replace("R$", "")
				.Replace(".", "")
				.TrimStart('0');

			decimal ul;
			if (decimal.TryParse(value, out ul))
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

		private async void BtnAdicionar_ClickAsync(object sender, EventArgs e)
		{
			Enabled = false;
			try
			{
				CleanErrors();
				var err = false;

				string value = TxtValor.Text.Replace(",", "")
					.Replace("R$", "")
					.Replace(".", "")
					.TrimStart('0');

				if (string.IsNullOrEmpty(value))
				{
					err = true;
					LblErrValor.Visible = true;
					LblErrValor.Text = "(*) Valor é necessário";
				}
				if (!decimal.TryParse(value, out decimal valorNumerico) || valorNumerico <= 0)
				{
					err = true;
					LblErrValor.Visible = true;
					LblErrValor.Text = "(*) Valor invalido ";
				}

				var tpLancamento = CboTpLancamento.SelectedValue.ToString();
				if (string.IsNullOrEmpty(tpLancamento))
				{
					err = true;
					LblErrTpDoc.Visible = true;
				}
				valorNumerico /= 100;

				var item = new LancamentoModel()
				{
					Observacao = TxtObservacao.Text,
					TipoLancamento = Convert.ToByte(tpLancamento),
					Valor = valorNumerico
				};

				item = await HttpClientManager.GetInstance.LancamentosController.Add(item);

				var result = MessageBox.Show("Lançamento cadastrado com sucesso, deseja continuar e efetuar um novo lançamento?",
							"Cadastro de Lançamento",
							MessageBoxButtons.YesNo,
							MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					LimparFormulario();
				}
				else
				{
					this.Close();
				}
			}
			catch (Exception ex)
			{

			}
			finally
			{
				Enabled = true;
			}
		}

		private void LimparFormulario()
		{
			CboTpLancamento.SelectedIndex = 0;
			TxtObservacao.Text = string.Empty;
			TxtValor.Text = string.Empty;
		}

		private void CleanErrors()
		{
			LblErrTpDoc.Visible = false;
			LblErrValor.Visible = false;
		}
	}
}
