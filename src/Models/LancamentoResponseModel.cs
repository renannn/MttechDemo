using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace Models
{
	public class LancamentoResponseModel : LancamentoModel
	{
		public Guid Id { get; set; }

		public DateTime DataSistema { get; set; }

		public string AppUserId { get; set; }

		public string NomeUsuario { get; set; }
		public string TipoLancamentoDescritivo
		{

			get
			{
				switch (TipoLancamento)
				{
					case 1:
						return "Débito";
					case 2:
						return "Crédito";
					default:
						return "";
				}
			}
		}

		public string ValorFormatado => string.Format(CultureInfo.CreateSpecificCulture("pt-BR"), "{0:C2}", Valor);

	}
}
