﻿using RefactorThis.GraphDiff;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

namespace AradCms.Core.Context
{
    public interface IUnitOfWork : IDisposable
    {
        IList<string> GetUserPermissions(int[] roleIds);

        IDbSet<TEntity> Set<TEntity>() where TEntity : class;

        int SaveChanges();

        Task<int> SaveChangesAsync();

        DbEntityEntry Entry(object entity);

        void MarkAsChanged<TEntity>(TEntity entity) where TEntity : class;

        void MarkAsDetached<TEntity>(TEntity entity) where TEntity : class;

        void MarkAsDeleted<TEntity>(TEntity entity) where TEntity : class;

        void MarkAsAdded<TEntity>(TEntity entity) where TEntity : class;

        IList<T> GetRows<T>(string sql, params object[] parameters) where T : class;

        int SaveAllChanges(bool invalidateCacheDependencies = true);

        Task<int> SaveAllChangesAsync(bool invalidateCacheDependencies = true);

        IEnumerable<TEntity> AddThisRange<TEntity>(IEnumerable<TEntity> entities) where TEntity : class;

        void ForceDatabaseInitialize();

        void EnableFiltering(string name);

        void EnableFiltering(string name, string parameter, object value);

        void DisableFiltering(string name);

        void BulkInsertData<T>(IList<T> data);

        bool ValidateOnSaveEnabled { get; set; }
        bool ProxyCreationEnabled { get; set; }
        bool AutoDetectChangesEnabled { get; set; }
        bool ForceNoTracking { get; set; }

        T Update<T>(T entity, Expression<Func<IUpdateConfiguration<T>, object>> mapping) where T : class, new();

        void SetDynamicEntities(Type[] dynamicTypes);

        void SetConfigurationsAssemblies(Assembly[] assembly);
    }
}