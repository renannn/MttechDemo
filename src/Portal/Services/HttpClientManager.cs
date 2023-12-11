using Portal.Controllers;
using Refit;
using System;
using System.Configuration;
using System.Net.Http;

namespace Portal.Services
{
	public class HttpClientManager
	{
		public  HttpClient client { get; set; }
		private readonly RefitSettings _refitSettings;

		private readonly UserSessionManager _userSessionManager;

		private static HttpClientManager instance = null;
		public static HttpClientManager GetInstance
		{
			get
			{
				if (instance == null)
					instance = new HttpClientManager();
				return instance;
			}
		}

		public HttpClientManager()
		{
			_userSessionManager = UserSessionManager.GetInstance;

			client = new HttpClient()
			{
				BaseAddress = new Uri(ConfigurationManager.AppSettings["UrlApi"]),
				Timeout = TimeSpan.FromMinutes(5)
			};

			_refitSettings = new RefitSettings()
			{
			};

		}

		public IUsersController UsersController => RestService.For<IUsersController>(client, _refitSettings);
		public IAuthController AuthController => RestService.For<IAuthController>(client, _refitSettings);
		public ILancamentosController LancamentosController => RestService.For<ILancamentosController>(client, _refitSettings);
	}
}
