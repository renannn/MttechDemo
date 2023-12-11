using Portal.Controles;
using Portal.Services;
using Portal.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Portal
{
	public partial class FrmPrincipal : Form
	{
		Control Main;


		public FrmPrincipal()
		{
			InitializeComponent();
		}

		private void FrmPrincipal_Load(object sender, EventArgs e)
		{
			ShowLogin(sender, e);
		}

		private void FrmPrincipal_Shown(object sender, EventArgs e)
		{
		}

		private void ShowNewUser(object sender, EventArgs e)
		{
			var temp = new CtrlSignUp
			{
				Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right),
				Location = new Point(PainelContent.Size.Width - 350, 0),
				Size = new Size(350, PainelContent.Size.Height - 20)
			};

			temp.ReturnEvent += ShowLogin;

			if (Main != null)
			{
				PainelContent.Controls.Remove(Main);
				Main.Dispose();
			}
			temp.SetFocus();
			Main = temp;

			PainelContent.Controls.Add(Main);
			(Main as CtrlSignUp).SetFocus();
		}

		private void ShowLogin(object sender, EventArgs e)
		{
			HttpClientManager.GetInstance.client.DefaultRequestHeaders.Clear();

			var temp = new CtrlSignIn
			{
				Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right),
				Location = new Point(PainelContent.Size.Width - 350, 0),
				Size = new Size(350, PainelContent.Size.Height - 20)
			};

			temp.NewUserEvent += ShowNewUser;
			temp.RecoveryPasswordEvent += ShowRecoveryPassword;
			temp.LoginSucessEvent += LoginSucessEvent;

			if (Main != null)
			{
				PainelContent.Controls.Remove(Main);
				Main.Dispose();
			}
			Main = temp;

			PainelContent.Controls.Add(Main);

			(Main as CtrlSignIn).SetFocus();
		}

		private void LoginSucessEvent(object sender, EventArgs e)
		{
			var temp = new CtrlMenuPrincipal
			{
				Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Left),
				Location = new Point(0, 0),
				Size = new Size(PainelContent.Size.Width, PainelContent.Size.Height)
			};

			temp.LogoffEvent += ShowLogin;

			if (Main != null)
			{
				PainelContent.Controls.Remove(Main);
				Main.Dispose();
			}
			Main = temp;

			PainelContent.Controls.Add(Main);
		}

		private void ShowRecoveryPassword(object sender, EventArgs e)
		{
			var temp = new CtrlForgetPassword
			{
				Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right),
				Location = new Point(PainelContent.Size.Width - 350, 0),
				Size = new Size(350, PainelContent.Size.Height - 20)
			};

			temp.ReturnEvent += ShowLogin;

			if (Main != null)
			{
				PainelContent.Controls.Remove(Main);
				Main.Dispose();
			}
			Main = temp;

			PainelContent.Controls.Add(Main);

			(Main as CtrlForgetPassword).SetFocus();
		}

	}
}
