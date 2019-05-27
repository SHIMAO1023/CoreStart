using System;
using System.Collections.Generic;
using System.Text;

namespace CoreStart.Service
{
    public interface IService<TEntity, TDto, TKey> where TEntity : class
    {
        bool Create(TDto entity);

        TEntity Get(TKey key);

    }
}
