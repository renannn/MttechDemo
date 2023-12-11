using Portal.Models.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Services
{
	public class UserSessionManager
	{
		private static UserSessionManager instance = null;
		public static UserSessionManager GetInstance
		{
			get
			{
				if (instance == null)
					instance = new UserSessionManager();
				return instance;
			}
		}
		public LoginResponseModel Token { get; set; }

		public DateTime DataLogin { get; set; }
	}
}
