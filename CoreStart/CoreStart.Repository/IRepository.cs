using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreStart.Repository
{
    public interface IRepository<TEntity, TKey> where TEntity : class
    {
        #region 查

        Task<TEntity> GetAsync(TKey id);
        TEntity Get(TKey id);

        TEntity Get(Expression<Func<TEntity, bool>> param);
        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> param);

        long Count(Expression<Func<TEntity, bool>> param);
        Task<long> CountAsync(Expression<Func<TEntity, bool>> param);

        IList<TEntity> GetList(Expression<Func<TEntity, bool>> param);
        Task<IList<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> param);

        //todo GetPaged

        #endregion


        #region 增

        bool Insert(TEntity entity);
        Task<bool> InsertAsync(TEntity entity);
        bool Insert(IList<TEntity> entities);
        Task<bool> InsertAsync(IList<TEntity> entities);

        #endregion


        #region 改

        bool Update(TEntity entity);
        Task<bool> UpdateAsync(TEntity entity);

        #endregion


        #region 删

        bool Delete(TEntity entity);
        bool Delete(TKey key);
        Task<bool> DeleteAsync(TEntity entity);
        Task<bool> DeleteAsync(TKey key);

        #endregion


        #region execute sql

        //todo

        #endregion
    }
}
