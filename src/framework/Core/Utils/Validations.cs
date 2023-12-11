using System.ComponentModel.DataAnnotations;

namespace Core.Utils
{
	public static class Validations
	{
		public static bool IsValidEmail(this string source)
		{
			return new EmailAddressAttribute().IsValid(source);
		}
	}
}
