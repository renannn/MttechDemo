using Core.Utils;
using Portal.Services;
using Refit;
using System;
using System.Windows.Forms;

namespace Portal.Controles
{
	public partial class CtrlSignUp : UserControl
	{
		public delegate void ReturnEventHandler(object sender, EventArgs e);

		public event ReturnEventHandler ReturnEvent;

		public CtrlSignUp()
		{
			InitializeComponent();
		}

		public void SetFocus()
		{
			TxtEmail.Focus();
		}

		private void btnReturn_Click(object sender, EventArgs e)
		{
			ReturnEvent?.Invoke(sender, e);
		}

		private async void BtnCadastrar_Click(object sender, EventArgs e)
		{
			try
			{
				Enabled = false;
				CleanErrors();

				var err = false;
				var email = TxtEmail.Text.Trim();
				var password = TxtSenha.Text;

				if (string.IsNullOrEmpty(email) || !email.IsNormalized() || !email.IsValidEmail())
				{
					err = true;
					LblErrEmail.Visible = true;
				}
				if (string.IsNullOrEmpty(password))
				{
					err = true;
					LblErrSenha.Visible = true;
				}

				if (err)
				{
					MessageBox.Show("Por favor, verificar o preenchimento do formulario de autenticação.", "Erro na Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				await HttpClientManager.GetInstance.AuthController.Register(new Models.Auth.RegisterRequestModel
				{
					Email = email,
					Password = password
				});

				MessageBox.Show("Usuário criado com sucesso.",
						"Cadastro de Usuário",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information);

				ReturnEvent?.Invoke(sender, e);
			}
			catch (ApiException apiEx)
			{
				MessageBox.Show(apiEx.Message,
					"Ocorreu um erro durante o registro.",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
			finally
			{
				Enabled = true;
			}
		}
		private void CleanErrors()
		{
			LblErrEmail.Visible = false;
			LblErrSenha.Visible = false;
		}
	}
}
