using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.EntityFrameworkCore
{
	public static class EntityFrameworkCoreModelBuilderExtensions
	{
		public static void SetDecimalPrecision(this ModelBuilder builder)
		{
			foreach (var property in builder.Model.GetEntityTypes()
															  .SelectMany(t => t.GetProperties())
															  .Where(p => p.ClrType == typeof(decimal)
																		  || p.ClrType == typeof(decimal?)))
			{
				property.SetColumnType("decimal(18, 6)");
			}
		}

	}
}
