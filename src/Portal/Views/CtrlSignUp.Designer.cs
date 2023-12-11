using System.Drawing;

namespace Portal.Controles
{
	partial class CtrlSignUp
	{
		/// <summary> 
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Designer de Componentes

		/// <summary> 
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.TxtEmail = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnCadastrar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btnReturn = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtSenha = new System.Windows.Forms.TextBox();
			this.LblErrEmail = new System.Windows.Forms.Label();
			this.LblErrSenha = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TxtEmail
			// 
			this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtEmail.Location = new System.Drawing.Point(30, 104);
			this.TxtEmail.Name = "TxtEmail";
			this.TxtEmail.Size = new System.Drawing.Size(300, 35);
			this.TxtEmail.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
			this.label1.Location = new System.Drawing.Point(29, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 28);
			this.label1.TabIndex = 2;
			this.label1.Text = "E-mail:";
			// 
			// BtnCadastrar
			// 
			this.BtnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.BtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnCadastrar.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.BtnCadastrar.ForeColor = System.Drawing.Color.White;
			this.BtnCadastrar.Location = new System.Drawing.Point(28, 291);
			this.BtnCadastrar.Name = "BtnCadastrar";
			this.BtnCadastrar.Size = new System.Drawing.Size(300, 45);
			this.BtnCadastrar.TabIndex = 4;
			this.BtnCadastrar.Text = "Entrar";
			this.BtnCadastrar.UseVisualStyleBackColor = false;
			this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 20F);
			this.label4.Location = new System.Drawing.Point(23, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(148, 37);
			this.label4.TabIndex = 7;
			this.label4.Text = "Registre-se";
			// 
			// btnReturn
			// 
			this.btnReturn.BackColor = System.Drawing.Color.Gray;
			this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.btnReturn.ForeColor = System.Drawing.Color.White;
			this.btnReturn.Location = new System.Drawing.Point(28, 342);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(300, 45);
			this.btnReturn.TabIndex = 8;
			this.btnReturn.Text = "Voltar";
			this.btnReturn.UseVisualStyleBackColor = false;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
			this.label3.Location = new System.Drawing.Point(29, 175);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(69, 28);
			this.label3.TabIndex = 10;
			this.label3.Text = "Senha:";
			// 
			// TxtSenha
			// 
			this.TxtSenha.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtSenha.Location = new System.Drawing.Point(30, 206);
			this.TxtSenha.Name = "TxtSenha";
			this.TxtSenha.PasswordChar = '*';
			this.TxtSenha.Size = new System.Drawing.Size(300, 35);
			this.TxtSenha.TabIndex = 9;
			// 
			// LblErrEmail
			// 
			this.LblErrEmail.AutoSize = true;
			this.LblErrEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblErrEmail.ForeColor = System.Drawing.Color.Red;
			this.LblErrEmail.Location = new System.Drawing.Point(27, 142);
			this.LblErrEmail.Name = "LblErrEmail";
			this.LblErrEmail.Size = new System.Drawing.Size(204, 17);
			this.LblErrEmail.TabIndex = 13;
			this.LblErrEmail.Text = "(*) E-mail de usuário é necessário";
			this.LblErrEmail.Visible = false;
			// 
			// LblErrSenha
			// 
			this.LblErrSenha.AutoSize = true;
			this.LblErrSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblErrSenha.ForeColor = System.Drawing.Color.Red;
			this.LblErrSenha.Location = new System.Drawing.Point(31, 244);
			this.LblErrSenha.Name = "LblErrSenha";
			this.LblErrSenha.Size = new System.Drawing.Size(117, 17);
			this.LblErrSenha.TabIndex = 16;
			this.LblErrSenha.Text = "(*) Digitar a senha!";
			this.LblErrSenha.Visible = false;
			// 
			// CtrlSignUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.Controls.Add(this.LblErrSenha);
			this.Controls.Add(this.LblErrEmail);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TxtSenha);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.BtnCadastrar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxtEmail);
			this.Margin = new System.Windows.Forms.Padding(3, 10, 3, 15);
			this.Name = "CtrlSignUp";
			this.Size = new System.Drawing.Size(350, 700);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxtEmail;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnCadastrar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxtSenha;
		private System.Windows.Forms.Label LblErrEmail;
		private System.Windows.Forms.Label LblErrSenha;
	}
}
