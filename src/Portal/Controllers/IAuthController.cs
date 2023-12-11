using Portal.Models.Auth;
using Refit;
using System.Net.Http;
using System.Threading.Tasks;

namespace Portal.Controllers
{
	public interface IAuthController
	{
		HttpClient Client { get; }


		[Post("/account/register")]
		Task Register([Body] RegisterRequestModel request);

		[Post("/account/login")]
		Task<LoginResponseModel> Login([Body] LoginRequestModel request);
		 
		[Get("/account/manage/info")]
		Task<UserInfoResponse> GetUserInfo();
	}
}
