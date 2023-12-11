using System.Collections.Generic;

namespace Portal.Models.Auth
{
	public class UserInfoResponse
	{
		public string Email { get; set; }

		public bool IsEmailConfirmed { get; set; }
		
		public Dictionary<string, string> Claims { get; set; }	
	}
}
