using System;

namespace Models
{
	public class LancamentoQueryModel
	{
		public DateTime DataInicio { get; set; }
		public DateTime DataTermino { get; set; }

		public byte TipoLancamento { get; set; }

		public string AppUserId { get; set; }

		public decimal? Valor { get; set; }
	}
}
