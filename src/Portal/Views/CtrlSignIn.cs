using Core.Utils;
using Portal.Services;
using Refit;
using System;
using System.Net;
using System.Windows.Forms;

namespace Portal.Controles
{
	public partial class CtrlSignIn : UserControl
	{
		public delegate void NewUserEventHandler(object sender, EventArgs e);
		public delegate void RecoveryPasswordEventHandler(object sender, EventArgs e);
		public delegate void LoginSucessEventHandler(object sender, EventArgs e);

		public event NewUserEventHandler NewUserEvent;
		public event RecoveryPasswordEventHandler RecoveryPasswordEvent;
		public event LoginSucessEventHandler LoginSucessEvent;

		public CtrlSignIn()
		{
			InitializeComponent();
		}

		public void SetFocus()
		{
			TxtEmail.Focus();
		}

		private void lnkNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			NewUserEvent?.Invoke(this, e);
		}

		private async void BtnEntrar_ClickAsync(object sender, EventArgs e)
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

					Enabled = true;
					return;
				}

				var loginResult = await AutenticacaoService.GetInstance.AuthWithPassword(email, password);

				UserSessionManager.GetInstance.Token = loginResult;
				UserSessionManager.GetInstance.DataLogin = DateTime.Now;

				HttpClientManager.GetInstance.client.DefaultRequestHeaders.Add("Authorization", $"Bearer {loginResult.AccessToken.Trim()}");

				LoginSucessEvent?.Invoke(this, e);
			}
			catch (ApiException apiEx)
			{
				switch (apiEx.StatusCode)
				{
					case HttpStatusCode.Unauthorized:
						MessageBox.Show("Nome de usuário ou senha inválido",
							"Ocorreu um erro durante a autenticação.",
							MessageBoxButtons.OK,
							MessageBoxIcon.Error);
						break;
					default:
						MessageBox.Show("Ocorreu um erro durante a autenticação," +
							" por favor entrar em contato com o suporte",
							"Ocorreu um erro durante a autenticação.",
							MessageBoxButtons.OK,
							MessageBoxIcon.Error);

						break;
				}
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

		private void LnkRecuperarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			RecoveryPasswordEvent?.Invoke(this, e);
		}
	}
}
