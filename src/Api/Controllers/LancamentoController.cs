using Application;
using Core.Caixa;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Core.Utils;
using Models;
using AutoMapper;
using Core.Identity;
using LinqKit;
using Microsoft.IdentityModel.Tokens;
using System.Drawing;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
	[ApiController]
	[Authorize]
	public class LancamentoController : Controller
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public LancamentoController(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		[HttpPost("/Lancamento/Add/Teste")]
		public async Task<IActionResult> TesteAsync()
		{
			var itens = new List<Lancamento>();

			var currentUser = this.User.GetUserId();

			for (int i = 0; i < 5000; i++)
			{
				itens.Add(new Lancamento
				{
					AppUserId = currentUser,
					Observacao = "teste 1",
					DataSistema = DateTime.Now,
					TipoLancamento = TipoLancamento.Debito,
					Valor = new Random(i).Next()
				});
			}

			_unitOfWork.AddRange(itens);

			await _unitOfWork.SaveChangesAsync();

			return Ok();
		}

		[HttpPost("/Lancamento/Add")]
		public async Task<LancamentoResponseModel> AddAsync(LancamentoModel item)
		{
			var entity = _mapper.Map<Lancamento>(item);

			entity.AppUserId = this.User.GetUserId();
			entity.DataSistema = DateTime.Now;

			entity = _unitOfWork.Add(entity);

			await _unitOfWork.SaveChangesAsync();

			return _mapper.Map<LancamentoResponseModel>(entity);
		}

		[HttpPost("/Lancamento/Query")]
		public async Task<List<LancamentoResponseModel>> Query(LancamentoQueryModel request)
		{
			var predicate = PredicateBuilder.New<Lancamento>(true);

			if (!string.IsNullOrEmpty(request.AppUserId))
			{
				predicate = predicate.And(a => a.AppUserId.Equals(request.AppUserId));
			}

			if (request.Valor.HasValue && request.Valor.Value > 0)
			{
				predicate = predicate.And(a => a.Valor == request.Valor);
			}

			if (request.TipoLancamento > 0)
			{
				predicate = predicate.And(a => a.TipoLancamento == (TipoLancamento)request.TipoLancamento);
			}

			predicate = predicate.And(a => a.DataSistema >= request.DataInicio);
			predicate = predicate.And(a => a.DataSistema <= request.DataTermino.AddDays(1).AddMicroseconds(-1));

			var itensEntity = await _unitOfWork.Set<Lancamento>().Where(predicate).ToListAsync();
			 
			return itensEntity.Select(x=> _mapper.Map<LancamentoResponseModel>(x)).ToList();
		}
	}
}
