using Portal.Models.Auth;
using System.Threading.Tasks;

namespace Portal.Services
{
	public class AutenticacaoService
	{
		#region Singleton

		private static AutenticacaoService instance = null;
		public static AutenticacaoService GetInstance
		{
			get
			{
				if (instance == null)
					instance = new AutenticacaoService();
				return instance;
			}
		}

		#endregion

		private readonly HttpClientManager _httpClientFactory;

		public AutenticacaoService()
		{
			_httpClientFactory = HttpClientManager.GetInstance;
		}
		public Task<LoginResponseModel> AuthWithPassword(string email, string password)
		{
			var request = new LoginRequestModel
			{
				Email = email,
				Password = password
			};

			return _httpClientFactory.AuthController.Login(request);
		}

	}
}
