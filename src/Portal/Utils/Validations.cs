using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Core.Utils
{
	public static class Validations
	{
		public static bool IsValidEmail(this string source)
		{
			return new EmailAddressAttribute().IsValid(source);
		}
		public static bool TextisValid(this string text)
		{
			Regex money = new Regex(@"^R\$([1-9]\d{0,2}((\.\d{3})*|\d*))(\,\d{2})?$");
			return money.IsMatch(text);
		}
	}
}
