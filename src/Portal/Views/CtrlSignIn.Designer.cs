using System.Drawing;

namespace Portal.Controles
{
	partial class CtrlSignIn
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
			this.TxtSenha = new System.Windows.Forms.TextBox();
			this.lblEmail = new System.Windows.Forms.Label();
			this.LblSenha = new System.Windows.Forms.Label();
			this.BtnEntrar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lnkNewUser = new System.Windows.Forms.LinkLabel();
			this.label4 = new System.Windows.Forms.Label();
			this.LblErrEmail = new System.Windows.Forms.Label();
			this.LblErrSenha = new System.Windows.Forms.Label();
			this.LnkRecuperarSenha = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// TxtEmail
			// 
			this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtEmail.Location = new System.Drawing.Point(30, 104);
			this.TxtEmail.MaxLength = 150;
			this.TxtEmail.Name = "TxtEmail";
			this.TxtEmail.Size = new System.Drawing.Size(300, 35);
			this.TxtEmail.TabIndex = 0;
			// 
			// TxtSenha
			// 
			this.TxtSenha.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtSenha.Location = new System.Drawing.Point(32, 201);
			this.TxtSenha.MaxLength = 25;
			this.TxtSenha.Name = "TxtSenha";
			this.TxtSenha.PasswordChar = '*';
			this.TxtSenha.Size = new System.Drawing.Size(300, 35);
			this.TxtSenha.TabIndex = 1;
			// 
			// lblEmail
			// 
			this.lblEmail.AutoSize = true;
			this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
			this.lblEmail.Location = new System.Drawing.Point(29, 73);
			this.lblEmail.Name = "lblEmail";
			this.lblEmail.Size = new System.Drawing.Size(71, 28);
			this.lblEmail.TabIndex = 2;
			this.lblEmail.Text = "E-mail:";
			// 
			// LblSenha
			// 
			this.LblSenha.AutoSize = true;
			this.LblSenha.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.LblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
			this.LblSenha.Location = new System.Drawing.Point(31, 170);
			this.LblSenha.Name = "LblSenha";
			this.LblSenha.Size = new System.Drawing.Size(69, 28);
			this.LblSenha.TabIndex = 3;
			this.LblSenha.Text = "Senha:";
			// 
			// BtnEntrar
			// 
			this.BtnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnEntrar.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.BtnEntrar.ForeColor = System.Drawing.Color.White;
			this.BtnEntrar.Location = new System.Drawing.Point(30, 281);
			this.BtnEntrar.Name = "BtnEntrar";
			this.BtnEntrar.Size = new System.Drawing.Size(300, 45);
			this.BtnEntrar.TabIndex = 4;
			this.BtnEntrar.Text = "Entrar";
			this.BtnEntrar.UseVisualStyleBackColor = false;
			this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_ClickAsync);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(25, 662);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(187, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "Não tem uma conta?";
			// 
			// lnkNewUser
			// 
			this.lnkNewUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.lnkNewUser.AutoSize = true;
			this.lnkNewUser.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lnkNewUser.Location = new System.Drawing.Point(218, 662);
			this.lnkNewUser.Name = "lnkNewUser";
			this.lnkNewUser.Size = new System.Drawing.Size(112, 25);
			this.lnkNewUser.TabIndex = 6;
			this.lnkNewUser.TabStop = true;
			this.lnkNewUser.Text = "Cadastre-se";
			this.lnkNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNewUser_LinkClicked);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 20F);
			this.label4.Location = new System.Drawing.Point(23, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 37);
			this.label4.TabIndex = 7;
			this.label4.Text = "Login";
			// 
			// LblErrEmail
			// 
			this.LblErrEmail.AutoSize = true;
			this.LblErrEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblErrEmail.ForeColor = System.Drawing.Color.Red;
			this.LblErrEmail.Location = new System.Drawing.Point(32, 146);
			this.LblErrEmail.Name = "LblErrEmail";
			this.LblErrEmail.Size = new System.Drawing.Size(204, 17);
			this.LblErrEmail.TabIndex = 8;
			this.LblErrEmail.Text = "(*) E-mail de usuário é necessário";
			this.LblErrEmail.Visible = false;
			// 
			// LblErrSenha
			// 
			this.LblErrSenha.AutoSize = true;
			this.LblErrSenha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblErrSenha.ForeColor = System.Drawing.Color.Red;
			this.LblErrSenha.Location = new System.Drawing.Point(33, 242);
			this.LblErrSenha.Name = "LblErrSenha";
			this.LblErrSenha.Size = new System.Drawing.Size(117, 17);
			this.LblErrSenha.TabIndex = 9;
			this.LblErrSenha.Text = "(*) Digitar a senha!";
			this.LblErrSenha.Visible = false;
			// 
			// LnkRecuperarSenha
			// 
			this.LnkRecuperarSenha.AutoSize = true;
			this.LnkRecuperarSenha.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.LnkRecuperarSenha.Location = new System.Drawing.Point(204, 340);
			this.LnkRecuperarSenha.Name = "LnkRecuperarSenha";
			this.LnkRecuperarSenha.Size = new System.Drawing.Size(126, 21);
			this.LnkRecuperarSenha.TabIndex = 10;
			this.LnkRecuperarSenha.TabStop = true;
			this.LnkRecuperarSenha.Text = "Recuperar senha";
			this.LnkRecuperarSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkRecuperarSenha_LinkClicked);
			// 
			// CtrlSignIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.Controls.Add(this.LnkRecuperarSenha);
			this.Controls.Add(this.LblErrSenha);
			this.Controls.Add(this.LblErrEmail);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lnkNewUser);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.BtnEntrar);
			this.Controls.Add(this.LblSenha);
			this.Controls.Add(this.lblEmail);
			this.Controls.Add(this.TxtSenha);
			this.Controls.Add(this.TxtEmail);
			this.Margin = new System.Windows.Forms.Padding(3, 10, 3, 15);
			this.Name = "CtrlSignIn";
			this.Size = new System.Drawing.Size(350, 700);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxtEmail;
		private System.Windows.Forms.TextBox TxtSenha;
		private System.Windows.Forms.Label lblEmail;
		private System.Windows.Forms.Label LblSenha;
		private System.Windows.Forms.Button BtnEntrar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.LinkLabel lnkNewUser;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label LblErrEmail;
		private System.Windows.Forms.Label LblErrSenha;
		private System.Windows.Forms.LinkLabel LnkRecuperarSenha;
	}
}
