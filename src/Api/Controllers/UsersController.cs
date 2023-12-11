using Application;
using AutoMapper;
using Core.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Api.Controllers
{
	[ApiController]
	[Authorize]
	public class UsersController : Controller
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly IMapper _mapper;

		public UsersController(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		[HttpGet("/Users")]
		public List<UsuarioModel> Index()
		{
			var itens = _unitOfWork.Set<AppUser>().ToList();


			return itens.Select(x => _mapper.Map<UsuarioModel>(x)).ToList();
		}
	}
}
