using AutoMapper;
using CoreStart.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreStart.Service
{
    public class BaseService<TEntity, TDto, TKey> : IService<TEntity, TDto, TKey> where TEntity : class
    {
        private readonly IRepository<TEntity, TKey> _baseRepository;

        private readonly IMapper _mapper;

        public BaseService(IRepository<TEntity, TKey> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public bool Create(TDto dto)
        {
            return _baseRepository.Insert(MapToEntity(dto));
        }

        public TEntity Get(TKey key)
        {
            return _baseRepository.Get(key);
        }

        public TEntity MapToEntity(TDto dto)
        {
            return _mapper.Map<TEntity>(dto);
        }

        public TDto MapToDto(TEntity entity)
        {
            return _mapper.Map<TDto>(entity);
        }
    }
}
