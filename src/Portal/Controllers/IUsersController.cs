using Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Controllers
{
	public interface IUsersController
	{
		HttpClient Client { get; }

		[Get("/Users")]
		Task<List<UsuarioModel>> List();
	}
}
