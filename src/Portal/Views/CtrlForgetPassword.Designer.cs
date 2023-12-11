using System.Drawing;

namespace Portal.Controles
{
	partial class CtrlForgetPassword
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
			this.BtnRecuperarSenha = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btnReturn = new System.Windows.Forms.Button();
			this.LblErrEmail = new System.Windows.Forms.Label();
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
			// BtnRecuperarSenha
			// 
			this.BtnRecuperarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.BtnRecuperarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnRecuperarSenha.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.BtnRecuperarSenha.ForeColor = System.Drawing.Color.White;
			this.BtnRecuperarSenha.Location = new System.Drawing.Point(30, 186);
			this.BtnRecuperarSenha.Name = "BtnRecuperarSenha";
			this.BtnRecuperarSenha.Size = new System.Drawing.Size(300, 45);
			this.BtnRecuperarSenha.TabIndex = 4;
			this.BtnRecuperarSenha.Text = "Confirmar";
			this.BtnRecuperarSenha.UseVisualStyleBackColor = false;
			this.BtnRecuperarSenha.Click += new System.EventHandler(this.BtnRecuperarSenha_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 20F);
			this.label4.Location = new System.Drawing.Point(23, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(211, 37);
			this.label4.TabIndex = 7;
			this.label4.Text = "Recuperar senha";
			// 
			// btnReturn
			// 
			this.btnReturn.BackColor = System.Drawing.Color.Gray;
			this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.btnReturn.ForeColor = System.Drawing.Color.White;
			this.btnReturn.Location = new System.Drawing.Point(30, 237);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(300, 45);
			this.btnReturn.TabIndex = 8;
			this.btnReturn.Text = "Voltar";
			this.btnReturn.UseVisualStyleBackColor = false;
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			// 
			// LblErrEmail
			// 
			this.LblErrEmail.AutoSize = true;
			this.LblErrEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblErrEmail.ForeColor = System.Drawing.Color.Red;
			this.LblErrEmail.Location = new System.Drawing.Point(31, 142);
			this.LblErrEmail.Name = "LblErrEmail";
			this.LblErrEmail.Size = new System.Drawing.Size(204, 17);
			this.LblErrEmail.TabIndex = 14;
			this.LblErrEmail.Text = "(*) E-mail de usuário é necessário";
			this.LblErrEmail.Visible = false;
			// 
			// CtrlForgetPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Azure;
			this.Controls.Add(this.LblErrEmail);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.BtnRecuperarSenha);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxtEmail);
			this.Margin = new System.Windows.Forms.Padding(3, 10, 3, 15);
			this.Name = "CtrlForgetPassword";
			this.Size = new System.Drawing.Size(350, 700);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxtEmail;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button BtnRecuperarSenha;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnReturn;
		private System.Windows.Forms.Label LblErrEmail;
	}
}
