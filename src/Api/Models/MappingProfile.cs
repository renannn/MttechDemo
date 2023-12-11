using AutoMapper;
using Core.Caixa;
using Core.Identity;
using Models;

namespace Api.Models
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Lancamento, LancamentoResponseModel>()
				.ForMember(dto => dto.NomeUsuario, act => act.MapFrom(src => src.AppUser.Email));

			CreateMap<LancamentoModel, Lancamento>();
			CreateMap<AppUser, UsuarioModel>();
		}
	}
}
