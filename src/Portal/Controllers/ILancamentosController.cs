using Models;
using Refit;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Portal.Controllers
{
	public interface ILancamentosController
	{
		HttpClient Client { get; }

		[Post("/Lancamento/Add")]
		Task<LancamentoResponseModel> Add(LancamentoModel item);


		[Post("/Lancamento/Query")]
		Task<List<LancamentoResponseModel>> Query(LancamentoQueryModel request);
	}
}
