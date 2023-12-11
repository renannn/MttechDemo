using Core.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Caixa
{
	[Table("Tbl_Lancamento", Schema ="Caixa")]
	public class Lancamento
	{
		[Key()]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid Id { get; set; }

		public string Observacao { get; set; }

		public decimal Valor { get; set; }

		public TipoLancamento TipoLancamento { get; set; }

		public DateTime DataSistema { get; set; }

		public string AppUserId { get; set; }


		public virtual AppUser AppUser { get; set; }
	}
}
