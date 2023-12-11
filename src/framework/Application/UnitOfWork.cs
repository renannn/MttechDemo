using Application.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data.Common;
using System.Data;
using System.Globalization;
using Microsoft.EntityFrameworkCore;

namespace Application
{
	public class UnitOfWork : IUnitOfWork
	{
		private IDbContextTransaction _transaction;
		private readonly AppDbContext _context;

		public TResult? GetShadownPropertyValue<TType, TResult>(TType entry, string field)
		{
			return (TResult)_context.Entry(entry).Property(field).CurrentValue;
		}

		public UnitOfWork(AppDbContext context)
		{
			_context = context ?? throw new ArgumentNullException(nameof(context));
		}

		public void AddRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
		{
			_context.Set<TEntity>().AddRange(entities);
		}

		public void BeginTransaction()
		{
			_transaction = _context.Database.BeginTransaction();
		}

		public void RollbackTransaction()
		{
			if (_transaction == null)
			{
				throw new NullReferenceException("Please call `BeginTransaction()` method first.");
			}
			_transaction.Rollback();
		}

		public void CommitTransaction()
		{
			if (_transaction == null)
			{
				throw new NullReferenceException("Please call `BeginTransaction()` method first.");
			}
			_transaction.Commit();
		}

		public void ExecuteSqlInterpolatedCommand(FormattableString query)
		{
			_context.ExecuteSqlInterpolatedCommand(query);
		}

		public void ExecuteSqlRawCommand(string query, params object[] parameters)
		{
			_context.ExecuteSqlRawCommand(query, parameters);
		}

		public T GetShadowPropertyValue<T>(object entity, string propertyName) where T : IConvertible
		{
			var value = _context.Entry(entity).Property(propertyName).CurrentValue;
			return value != null
				? (T)Convert.ChangeType(value, typeof(T), CultureInfo.InvariantCulture)
				: default;
		}

		public object GetShadowPropertyValue(object entity, string propertyName)
		{
			return _context.Entry(entity).Property(propertyName).CurrentValue;
		}

		public void MarkAsChanged<TEntity>(TEntity entity) where TEntity : class
		{
			_context.Update(entity);
		}

		public void RemoveRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class
		{
			_context.Set<TEntity>().RemoveRange(entities);
		}

		public int SaveChanges(bool acceptAllChangesOnSuccess)
		{
			return _context.SaveChanges(acceptAllChangesOnSuccess);
		}

		public int SaveChanges()
		{
			return _context.SaveChanges();
		}

		public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
		{
			return await _context.SaveChangesAsync(cancellationToken);
		}

		public void ExecuteQuery(string query)
		{
			_context.ExecuteSqlRawCommand(query);
		}

		public async Task<TType?> ExecuteQuery<TType>(string query)
		{
			var connection = _context.Database.GetDbConnection();
			try
			{
				await connection.OpenAsync();

				using (var cmd = connection.CreateCommand())
				{
					cmd.CommandText = query;
					cmd.CommandType = CommandType.Text;


					return (TType)(await cmd.ExecuteScalarAsync())!;
				}
			}
			finally
			{
				await connection.CloseAsync();
			}
		}

		public DbConnection GetConnection()
		{
			return _context.Database.GetDbConnection();
		}

		public async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken())
		{
			return await _context.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
		}

		public Microsoft.EntityFrameworkCore.DbSet<TEntity> Set<TEntity>() where TEntity : class
		{
			return _context.Set<TEntity>();
		}

		public TEntity Add<TEntity>(TEntity entitie) where TEntity : class
		{
			_context.Set<TEntity>().Add(entitie); 
			return entitie;
		}
	}
}
