using Core.Caixa;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Identity
{
	public class AppUser :IdentityUser
	{
		[ForeignKey("AppUserId")]
		public virtual ICollection<Lancamento> Lancamentos { get; set; }
	}
}
