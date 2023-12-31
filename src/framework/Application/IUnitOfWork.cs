﻿using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Application
{
	public interface IUnitOfWork
	{
		DbSet<TEntity> Set<TEntity>() where TEntity : class;
		TEntity Add<TEntity>(TEntity entitie) where TEntity : class;
		void AddRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class;
		void RemoveRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class;
		void MarkAsChanged<TEntity>(TEntity entity) where TEntity : class;
		T GetShadowPropertyValue<T>(object entity, string propertyName) where T : IConvertible;
		object GetShadowPropertyValue(object entity, string propertyName);
		void BeginTransaction();
		void RollbackTransaction();
		void CommitTransaction();
		int SaveChanges(bool acceptAllChangesOnSuccess);
		int SaveChanges();
		Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
		Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
		void ExecuteQuery(string query);
		Task<TType> ExecuteQuery<TType>(string query);

		DbConnection GetConnection();
	}
}
