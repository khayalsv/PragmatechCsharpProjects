﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace MyEvernote.DataAccessLayer.Repository
{
    public class EfRepository<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey> where TEntity : BaseEntity<TPrimaryKey>
    {
        private readonly MyContext _myContext;

        private DbSet<TEntity> Table => _myContext.Set<TEntity>();

        public EfRepository(MyContext myContext)
        {
            _myContext = myContext;
        }

        public IQueryable<TEntity> GetAll()
        {
            IQueryable<TEntity> query = Table;
            return query;
        }

        public IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = GetAll();
            BindIncludeProperties(query, includeProperties);
            includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return query;
        }

        public async Task<List<TEntity>> GetAllList()
        {
            return await GetAll().ToListAsync();
        }

        public Task<List<TEntity>> GetAllListIncluding(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = GetAll();
            includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return query.ToListAsync();
        }

        public ValueTask<TEntity> Find(TPrimaryKey id)
        {
            return Table.FindAsync(id);
        }

        public Task<TEntity> GetFirst(Expression<Func<TEntity, bool>> predicate)
        {
            return GetAll().FirstOrDefaultAsync(predicate);
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            return GetAll().Where(predicate);
        }

        public IQueryable<TEntity> FindByIncluding(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = GetAll();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return query.Where(predicate);
        }

        public Task<bool> Any(Expression<Func<TEntity, bool>> predicate)
        {
            return Table.AnyAsync(predicate);
        }

        public Task<bool> All(Expression<Func<TEntity, bool>> predicate)
        {
            return Table.AllAsync(predicate);
        }

        public async Task<int> Count()
        {
            return await Table.CountAsync();
        }

        public Task<int> Count(Expression<Func<TEntity, bool>> predicate)
        {
            return Table.CountAsync(predicate);
        }

        public async Task Add(TEntity entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task Update(TEntity entity)
        {
            _myContext.Entry(entity).State = EntityState.Modified;
        }

        public async Task Delete(TEntity entity)
        {
            _myContext.Entry(entity).State = EntityState.Deleted;
        }

        public async Task DeleteWhere(Expression<Func<TEntity, bool>> predicate)
        {
            IEnumerable<TEntity> entities = Table.Where(predicate);

            foreach (var entity in entities)
            {
                _myContext.Entry(entity).State = EntityState.Deleted;
            }
        }

        private static void BindIncludeProperties(IQueryable<TEntity> query, IEnumerable<Expression<Func<TEntity, object>>> includeProperties)
        {
            includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }
        public async Task Commit(CancellationToken cancellationToken = new CancellationToken())
        {
            await _myContext.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
            _myContext?.Dispose();
        }
    }

}
