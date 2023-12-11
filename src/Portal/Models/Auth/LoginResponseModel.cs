namespace Portal.Models.Auth
{
	public class LoginResponseModel
	{
		public string AccessToken { get; set; }
		public string RefreshToken { get; set; }
		public int ExpiresIn { get; set; }
		public string TokenType { get; set; }
	}
}
