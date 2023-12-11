namespace Portal.Views
{
	partial class CtrlMenuPrincipal
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.LblUser = new System.Windows.Forms.Label();
			this.BtnLogoff = new System.Windows.Forms.Button();
			this.TimerUserInfos = new System.Windows.Forms.Timer(this.components);
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.MenuLancamento = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.LblUser);
			this.panel1.Controls.Add(this.BtnLogoff);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1002, 61);
			this.panel1.TabIndex = 0;
			// 
			// LblUser
			// 
			this.LblUser.AutoSize = true;
			this.LblUser.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblUser.Location = new System.Drawing.Point(12, 12);
			this.LblUser.Name = "LblUser";
			this.LblUser.Size = new System.Drawing.Size(114, 37);
			this.LblUser.TabIndex = 1;
			this.LblUser.Text = "{{Email}}";
			// 
			// BtnLogoff
			// 
			this.BtnLogoff.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.BtnLogoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnLogoff.Location = new System.Drawing.Point(865, 3);
			this.BtnLogoff.Name = "BtnLogoff";
			this.BtnLogoff.Size = new System.Drawing.Size(134, 55);
			this.BtnLogoff.TabIndex = 0;
			this.BtnLogoff.Text = "Logoff";
			this.BtnLogoff.UseVisualStyleBackColor = true;
			this.BtnLogoff.Click += new System.EventHandler(this.BtnLogoff_Click);
			// 
			// TimerUserInfos
			// 
			this.TimerUserInfos.Enabled = true;
			this.TimerUserInfos.Interval = 5000;
			this.TimerUserInfos.Tick += new System.EventHandler(this.TimerUserInfos_TickAsync);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.Controls.Add(this.MenuLancamento);
			this.flowLayoutPanel1.Controls.Add(this.button2);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 70);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(1002, 509);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// MenuLancamento
			// 
			this.MenuLancamento.BackColor = System.Drawing.Color.White;
			this.MenuLancamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MenuLancamento.Location = new System.Drawing.Point(15, 15);
			this.MenuLancamento.Margin = new System.Windows.Forms.Padding(15);
			this.MenuLancamento.Name = "MenuLancamento";
			this.MenuLancamento.Size = new System.Drawing.Size(196, 81);
			this.MenuLancamento.TabIndex = 0;
			this.MenuLancamento.Text = "Adicionar Lançamento";
			this.MenuLancamento.UseVisualStyleBackColor = false;
			this.MenuLancamento.Click += new System.EventHandler(this.MenuLancamento_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(241, 15);
			this.button2.Margin = new System.Windows.Forms.Padding(15);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(196, 81);
			this.button2.TabIndex = 1;
			this.button2.Text = "Lançamentos Diarios";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// CtrlMenuPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "CtrlMenuPrincipal";
			this.Size = new System.Drawing.Size(1008, 729);
			this.Load += new System.EventHandler(this.CtrlMenuPrincipal_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button BtnLogoff;
		private System.Windows.Forms.Timer TimerUserInfos;
		private System.Windows.Forms.Label LblUser;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button MenuLancamento;
		private System.Windows.Forms.Button button2;
	}
}
