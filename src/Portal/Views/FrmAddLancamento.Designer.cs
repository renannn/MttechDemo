namespace Portal.Views
{
	partial class FrmAddLancamento
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.CboTpLancamento = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtValor = new System.Windows.Forms.TextBox();
			this.TxtObservacao = new System.Windows.Forms.TextBox();
			this.BtnAdicionar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.LblErrTpDoc = new System.Windows.Forms.Label();
			this.LblErrValor = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(480, 10);
			this.panel1.TabIndex = 0;
			// 
			// CboTpLancamento
			// 
			this.CboTpLancamento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CboTpLancamento.FormattingEnabled = true;
			this.CboTpLancamento.Location = new System.Drawing.Point(0, 46);
			this.CboTpLancamento.Name = "CboTpLancamento";
			this.CboTpLancamento.Size = new System.Drawing.Size(476, 29);
			this.CboTpLancamento.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tipo de lançamento";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(0, 107);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Valor";
			// 
			// TxtValor
			// 
			this.TxtValor.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.TxtValor.Location = new System.Drawing.Point(0, 129);
			this.TxtValor.Name = "TxtValor";
			this.TxtValor.Size = new System.Drawing.Size(476, 29);
			this.TxtValor.TabIndex = 4;
			this.TxtValor.TextChanged += new System.EventHandler(this.TxtValor_TextChanged);
			// 
			// TxtObservacao
			// 
			this.TxtObservacao.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.TxtObservacao.Location = new System.Drawing.Point(0, 214);
			this.TxtObservacao.MaxLength = 550;
			this.TxtObservacao.Multiline = true;
			this.TxtObservacao.Name = "TxtObservacao";
			this.TxtObservacao.Size = new System.Drawing.Size(476, 258);
			this.TxtObservacao.TabIndex = 5;
			// 
			// BtnAdicionar
			// 
			this.BtnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.BtnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnAdicionar.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnAdicionar.ForeColor = System.Drawing.Color.White;
			this.BtnAdicionar.Location = new System.Drawing.Point(0, 478);
			this.BtnAdicionar.Name = "BtnAdicionar";
			this.BtnAdicionar.Size = new System.Drawing.Size(476, 98);
			this.BtnAdicionar.TabIndex = 6;
			this.BtnAdicionar.Text = "Adicionar";
			this.BtnAdicionar.UseVisualStyleBackColor = false;
			this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_ClickAsync);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(0, 192);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Observação";
			// 
			// LblErrTpDoc
			// 
			this.LblErrTpDoc.AutoSize = true;
			this.LblErrTpDoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblErrTpDoc.ForeColor = System.Drawing.Color.Red;
			this.LblErrTpDoc.Location = new System.Drawing.Point(0, 79);
			this.LblErrTpDoc.Name = "LblErrTpDoc";
			this.LblErrTpDoc.Size = new System.Drawing.Size(218, 17);
			this.LblErrTpDoc.TabIndex = 9;
			this.LblErrTpDoc.Text = "(*) Tipo de Documento é necessário";
			this.LblErrTpDoc.Visible = false;
			// 
			// LblErrValor
			// 
			this.LblErrValor.AutoSize = true;
			this.LblErrValor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblErrValor.ForeColor = System.Drawing.Color.Red;
			this.LblErrValor.Location = new System.Drawing.Point(0, 161);
			this.LblErrValor.Name = "LblErrValor";
			this.LblErrValor.Size = new System.Drawing.Size(71, 17);
			this.LblErrValor.TabIndex = 10;
			this.LblErrValor.Text = "{{ValorErr}}";
			this.LblErrValor.Visible = false;
			// 
			// FrmAddLancamento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(480, 588);
			this.Controls.Add(this.LblErrValor);
			this.Controls.Add(this.LblErrTpDoc);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.BtnAdicionar);
			this.Controls.Add(this.TxtObservacao);
			this.Controls.Add(this.TxtValor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CboTpLancamento);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmAddLancamento";
			this.Text = "Adicionar Lançamento";
			this.Load += new System.EventHandler(this.FrmAddLancamento_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox CboTpLancamento;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtValor;
		private System.Windows.Forms.TextBox TxtObservacao;
		private System.Windows.Forms.Button BtnAdicionar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label LblErrTpDoc;
		private System.Windows.Forms.Label LblErrValor;
	}
}