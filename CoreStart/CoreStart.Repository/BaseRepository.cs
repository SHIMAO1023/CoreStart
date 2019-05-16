using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreStart.Repository
{
    public abstract class BaseRepository<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity : class
    {
        private readonly DbSet<TEntity> _dbSet;

        public DbContext _dbContext;

        public BaseRepository(DbContext dbContext)
        {
            this._dbContext = dbContext;
            this._dbSet = _dbContext.Set<TEntity>();
        }

        #region 查

        public long Count(Expression<Func<TEntity, bool>> param)
        {
            return this._dbSet.LongCount(param);
        }

        public async Task<long> CountAsync(Expression<Func<TEntity, bool>> param)
        {
            return await this._dbSet.LongCountAsync(param);
        }

        public TEntity Get(TKey id)
        {
            return _dbSet.Find(id);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> param)
        {
            return _dbSet.Where(param).FirstOrDefault();
        }

        public async Task<TEntity> GetAsync(TKey id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> param)
        {
            return await _dbSet.Where(param).FirstOrDefaultAsync();
        }

        public IList<TEntity> GetList(Expression<Func<TEntity, bool>> param)
        {
            return _dbSet.Where(param).ToList();
        }

        public async Task<IList<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> param)
        {
            return await _dbSet.Where(param).ToListAsync();
        }

        #endregion


        #region 增

        public bool Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Insert(IList<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAsync(IList<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        #endregion


        #region 增

        public bool Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        #endregion


        #region 删

        public bool Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TKey key)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TKey key)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
