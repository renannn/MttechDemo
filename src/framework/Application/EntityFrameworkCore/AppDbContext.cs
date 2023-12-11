using Core.Caixa;
using Core.Identity;
using EntityFramework.Exceptions.SqlServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Application.EntityFrameworkCore
{
	public class AppDbContext : IdentityDbContext<AppUser>
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }


		public DbSet<Lancamento> Lancamentos { get; set; }

		public void ExecuteSqlInterpolatedCommand(FormattableString query)
		{
			Database.ExecuteSqlInterpolated(query);
		}

		public void ExecuteSqlRawCommand(string query, params object[] parameters)
		{
			Database.ExecuteSqlRaw(query, parameters);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.SetDecimalPrecision();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseExceptionProcessor()
						  .UseLazyLoadingProxies();
		}
	}
}
