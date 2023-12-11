using Core.Utils;
using System;
using System.Windows.Forms;

namespace Portal.Controles
{
	public partial class CtrlForgetPassword : UserControl
	{
		public delegate void ReturnEventHandler(object sender, EventArgs e);

		public event ReturnEventHandler ReturnEvent;

		public CtrlForgetPassword()
		{
			InitializeComponent();
		}

		public void SetFocus()
		{
			TxtEmail.Focus();
		}

		private void btnReturn_Click(object sender, EventArgs e)
		{
			ReturnEvent?.Invoke(sender,e);
		}

		private void BtnRecuperarSenha_Click(object sender, EventArgs e)
		{
			CleanErrors();

			var err = false;
			var email = TxtEmail.Text.Trim();

			if (string.IsNullOrEmpty(email) || !email.IsNormalized() || !email.IsValidEmail())
			{
				err = true;
				LblErrEmail.Visible = true;
			}
			if (err)
			{
				MessageBox.Show("Por favor, verificar o preenchimento do formulario de autenticação.", "Erro na Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}
		private void CleanErrors()
		{
			LblErrEmail.Visible = false;
		}
	}
}
