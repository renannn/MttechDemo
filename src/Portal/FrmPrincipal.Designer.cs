namespace Portal
{
	partial class FrmPrincipal
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

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.PainelContent = new System.Windows.Forms.Panel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.panel2 = new System.Windows.Forms.Panel();
			this.PainelContent.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.PainelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
			this.PainelContent.Controls.Add(this.panel2);
			this.PainelContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PainelContent.Location = new System.Drawing.Point(0, 0);
			this.PainelContent.Name = "panel1";
			this.PainelContent.Size = new System.Drawing.Size(1008, 729);
			this.PainelContent.TabIndex = 0;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 707);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.panel2.BackColor = System.Drawing.SystemColors.Control;
			this.panel2.Location = new System.Drawing.Point(329, 278);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(300, 120);
			this.panel2.TabIndex = 0;
			this.panel2.Visible = false;
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1008, 729);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.PainelContent);
			this.MinimumSize = new System.Drawing.Size(1024, 768);
			this.Name = "FrmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mttechne - Financeiro";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmPrincipal_Load);
			this.Shown += new System.EventHandler(this.FrmPrincipal_Shown);
			this.PainelContent.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel PainelContent;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Panel panel2;
	}
}

