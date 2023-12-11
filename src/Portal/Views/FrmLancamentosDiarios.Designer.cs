namespace Portal.Views
{
	partial class FrmLancamentosDiarios
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.CboEmails = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.TxtValor = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.CboTpLancamento = new System.Windows.Forms.ComboBox();
			this.DtInicial = new System.Windows.Forms.DateTimePicker();
			this.DtFinal = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.BtnPesquisar = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.BtnExportar = new System.Windows.Forms.Button();
			this.DataSistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TipoLancamentoDescritivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NomeUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Observacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// CboEmails
			// 
			this.CboEmails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CboEmails.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.CboEmails.FormattingEnabled = true;
			this.CboEmails.Location = new System.Drawing.Point(3, 25);
			this.CboEmails.Name = "CboEmails";
			this.CboEmails.Size = new System.Drawing.Size(351, 29);
			this.CboEmails.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Email";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1084, 10);
			this.panel1.TabIndex = 2;
			// 
			// TxtValor
			// 
			this.TxtValor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtValor.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.TxtValor.Location = new System.Drawing.Point(0, 25);
			this.TxtValor.Name = "TxtValor";
			this.TxtValor.Size = new System.Drawing.Size(355, 29);
			this.TxtValor.TabIndex = 8;
			this.TxtValor.TextChanged += new System.EventHandler(this.TxtValor_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(-3, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "Valor";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Tipo de lançamento";
			// 
			// CboTpLancamento
			// 
			this.CboTpLancamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CboTpLancamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CboTpLancamento.FormattingEnabled = true;
			this.CboTpLancamento.Location = new System.Drawing.Point(3, 25);
			this.CboTpLancamento.Name = "CboTpLancamento";
			this.CboTpLancamento.Size = new System.Drawing.Size(348, 29);
			this.CboTpLancamento.TabIndex = 5;
			// 
			// DtInicial
			// 
			this.DtInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DtInicial.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.DtInicial.Location = new System.Drawing.Point(6, 25);
			this.DtInicial.Name = "DtInicial";
			this.DtInicial.Size = new System.Drawing.Size(525, 29);
			this.DtInicial.TabIndex = 9;
			this.DtInicial.Value = new System.DateTime(2023, 12, 11, 0, 0, 0, 0);
			// 
			// DtFinal
			// 
			this.DtFinal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DtFinal.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.DtFinal.Location = new System.Drawing.Point(3, 25);
			this.DtFinal.Name = "DtFinal";
			this.DtFinal.Size = new System.Drawing.Size(532, 29);
			this.DtFinal.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(6, 5);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 17);
			this.label4.TabIndex = 11;
			this.label4.Text = "Data Inicial";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(3, 5);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 17);
			this.label5.TabIndex = 12;
			this.label5.Text = "Data Final";
			// 
			// BtnPesquisar
			// 
			this.BtnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
			this.BtnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnPesquisar.ForeColor = System.Drawing.Color.White;
			this.BtnPesquisar.Location = new System.Drawing.Point(0, 0);
			this.BtnPesquisar.Name = "BtnPesquisar";
			this.BtnPesquisar.Size = new System.Drawing.Size(1078, 45);
			this.BtnPesquisar.TabIndex = 13;
			this.BtnPesquisar.Text = "Pesquisar";
			this.BtnPesquisar.UseVisualStyleBackColor = false;
			this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel6, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel4, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel5, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 16);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1084, 185);
			this.tableLayoutPanel1.TabIndex = 14;
			// 
			// panel2
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.panel2, 2);
			this.panel2.Controls.Add(this.CboEmails);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(354, 61);
			this.panel2.TabIndex = 0;
			// 
			// panel3
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.panel3, 3);
			this.panel3.Controls.Add(this.DtInicial);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(3, 70);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(534, 61);
			this.panel3.TabIndex = 1;
			// 
			// panel6
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.panel6, 2);
			this.panel6.Controls.Add(this.CboTpLancamento);
			this.panel6.Controls.Add(this.label3);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.Location = new System.Drawing.Point(363, 3);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(354, 61);
			this.panel6.TabIndex = 4;
			// 
			// panel4
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.panel4, 2);
			this.panel4.Controls.Add(this.TxtValor);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(723, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(358, 61);
			this.panel4.TabIndex = 2;
			// 
			// panel5
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.panel5, 3);
			this.panel5.Controls.Add(this.DtFinal);
			this.panel5.Controls.Add(this.label5);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(543, 70);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(538, 61);
			this.panel5.TabIndex = 5;
			// 
			// panel7
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.panel7, 6);
			this.panel7.Controls.Add(this.BtnPesquisar);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(3, 137);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(1078, 45);
			this.panel7.TabIndex = 6;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataSistema,
            this.TipoLancamentoDescritivo,
            this.NomeUsuario,
            this.Valor,
            this.Observacao});
			this.dataGridView1.Location = new System.Drawing.Point(3, 204);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1078, 500);
			this.dataGridView1.TabIndex = 15;
			// 
			// BtnExportar
			// 
			this.BtnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
			this.BtnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnExportar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnExportar.ForeColor = System.Drawing.Color.White;
			this.BtnExportar.Location = new System.Drawing.Point(824, 710);
			this.BtnExportar.Name = "BtnExportar";
			this.BtnExportar.Size = new System.Drawing.Size(254, 42);
			this.BtnExportar.TabIndex = 16;
			this.BtnExportar.Text = "Exportar";
			this.BtnExportar.UseVisualStyleBackColor = false;
			this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
			// 
			// DataSistema
			// 
			this.DataSistema.DataPropertyName = "DataSistema";
			this.DataSistema.HeaderText = "Data Lançamento";
			this.DataSistema.Name = "DataSistema";
			this.DataSistema.ReadOnly = true;
			this.DataSistema.Width = 160;
			// 
			// TipoLancamentoDescritivo
			// 
			this.TipoLancamentoDescritivo.DataPropertyName = "TipoLancamentoDescritivo";
			this.TipoLancamentoDescritivo.HeaderText = "Tipo de Lançamento";
			this.TipoLancamentoDescritivo.Name = "TipoLancamentoDescritivo";
			this.TipoLancamentoDescritivo.ReadOnly = true;
			this.TipoLancamentoDescritivo.Width = 130;
			// 
			// NomeUsuario
			// 
			this.NomeUsuario.DataPropertyName = "NomeUsuario";
			this.NomeUsuario.HeaderText = "Usuario";
			this.NomeUsuario.Name = "NomeUsuario";
			this.NomeUsuario.ReadOnly = true;
			this.NomeUsuario.Width = 230;
			// 
			// Valor
			// 
			this.Valor.DataPropertyName = "ValorFormatado";
			this.Valor.HeaderText = "Valor";
			this.Valor.Name = "Valor";
			this.Valor.ReadOnly = true;
			this.Valor.Width = 130;
			// 
			// Observacao
			// 
			this.Observacao.DataPropertyName = "Observacao";
			this.Observacao.HeaderText = "Observação";
			this.Observacao.Name = "Observacao";
			this.Observacao.ReadOnly = true;
			this.Observacao.Width = 350;
			// 
			// FrmLancamentosDiarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 761);
			this.Controls.Add(this.BtnExportar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.panel1);
			this.MinimumSize = new System.Drawing.Size(1100, 800);
			this.Name = "FrmLancamentosDiarios";
			this.Text = "Lançamentos Diarios";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmLancamentosDiarios_LoadAsync);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox CboEmails;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox TxtValor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox CboTpLancamento;
		private System.Windows.Forms.DateTimePicker DtInicial;
		private System.Windows.Forms.DateTimePicker DtFinal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button BtnPesquisar;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button BtnExportar;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataSistema;
		private System.Windows.Forms.DataGridViewTextBoxColumn TipoLancamentoDescritivo;
		private System.Windows.Forms.DataGridViewTextBoxColumn NomeUsuario;
		private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
		private System.Windows.Forms.DataGridViewTextBoxColumn Observacao;
	}
}