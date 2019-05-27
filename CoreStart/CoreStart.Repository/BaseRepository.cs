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
            _dbSet.Add(entity);
            return _dbContext.SaveChanges() > 0;
        }

        public bool Insert(IList<TEntity> entities)
        {
            _dbSet.AddRange(entities);
            return _dbContext.SaveChanges() > 0;
        }

        public async Task<bool> InsertAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> InsertAsync(IList<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        #endregion


        #region 改

        public bool Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            return _dbContext.SaveChanges() > 0;
        }

        public async Task<bool> UpdateAsync(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            return await _dbContext.SaveChangesAsync() > 0;
        }

        #endregion


        #region 删

        public bool Delete(TEntity entity)
        {
            //?
            _dbSet.Remove(entity);
            return _dbContext.SaveChanges() > 0;
        }

        public bool Delete(TKey key)
        {
            var entity = _dbSet.Find(key);
            if (entity == null)
            {
                return false;
            }
            _dbSet.Remove(entity);
            return _dbContext.SaveChanges() > 0;
        }

        public async Task<bool> DeleteAsync(TEntity entity)
        {
            _dbSet.Remove(entity);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(TKey key)
        {
            var entity = _dbSet.Find(key);
            if (entity == null)
            {
                return false;
            }
            _dbSet.Remove(entity);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        #endregion

    }
}
