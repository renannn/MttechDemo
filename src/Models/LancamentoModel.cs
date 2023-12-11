using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
	public class LancamentoModel
	{
		public string Observacao { get; set; }

		public decimal Valor { get; set; }

		public byte TipoLancamento { get; set; }
	}
}
