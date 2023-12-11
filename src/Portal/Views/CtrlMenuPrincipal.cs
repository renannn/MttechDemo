using Portal.Services;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portal.Views
{
	public partial class CtrlMenuPrincipal : UserControl
	{
		public delegate void LogoffEventHandler(object sender, EventArgs e);

		public event LogoffEventHandler LogoffEvent;

		public List<Form> Forms { get; set; } = new List<Form>();

		public CtrlMenuPrincipal()
		{
			InitializeComponent();
		}

		private void BtnLogoff_Click(object sender, EventArgs e)
		{
			Logoff();
		}

		private async void TimerUserInfos_TickAsync(object sender, EventArgs e)
		{
			await ShowInfo();
		}

		private async Task ShowInfo()
		{
			try
			{
				var userInfo = await HttpClientManager.GetInstance.AuthController.GetUserInfo();

				LblUser.Text = userInfo.Email;
			}
			catch (ApiException apiEx)
			{
				Logoff();
			}
		}

		private void Logoff()
		{
			UserSessionManager.GetInstance.Token = null;

			for (int i = Forms.Count - 1; i >= 0; i--)
			{
				Forms[i].Close();
			}

			LogoffEvent?.Invoke(this, EventArgs.Empty);
		}

		private async void CtrlMenuPrincipal_Load(object sender, EventArgs e)
		{
			await ShowInfo();
		}

		private void MenuLancamento_Click(object sender, EventArgs e)
		{
			var frm = new FrmAddLancamento();
			frm.FormClosed += OnFormClosed;
			Forms.Add(frm);
			frm.Show();
		}

		private void OnFormClosed(object sender, FormClosedEventArgs e)
		{
			Form item = (Form)sender;
			Forms.Remove(item);
			item.Dispose();
			GC.Collect();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var frm = new FrmLancamentosDiarios();
			frm.FormClosed += OnFormClosed;
			Forms.Add(frm);
			frm.Show();
		}
	}
}
