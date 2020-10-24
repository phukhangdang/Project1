using global::AutoMapper;
using Project1.Repository.GenericRepository;
using Project1.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Services.BaseService
{
    public abstract class BaseService<TEntity, TDto> : IBaseService<TEntity, TDto>
        where TEntity : class
        where TDto : class
    {
        protected readonly IUnitOfWork _unitOfWork;

        protected abstract IGenericRepository<TEntity> _reponsitory { get; }

        public BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<TDto> CreateAsync(TDto dto)
        {
            var entity = DtoToEntity(dto);

            _reponsitory.Create(entity);

            await _unitOfWork.SaveAsync();

            return EntityToDto(entity);
        }

        public Task<TDto> UpdateAsync(TDto dto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(object keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<TDto> FindByIdAsync(object keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<TDto> Find()
        {
            throw new NotImplementedException();
        }
        protected TDto EntityToDto(TEntity entity)
        {
            return Mapper.Map<TDto>(entity);
        }

        protected TEntity DtoToEntity(TDto dto)
        {
            return Mapper.Map<TEntity>(dto);
        }

        protected TEntity DtoToEntity(TDto dto, TEntity entity)
        {
            return Mapper.Map(dto, entity);
        }

        protected IEnumerable<TDto> EntityToDto(IEnumerable<TEntity> entities)
        {
            return Mapper.Map<IEnumerable<TDto>>(entities);
        }

        protected IEnumerable<TEntity> DtoToEntity(IEnumerable<TDto> dto)
        {
            return Mapper.Map<IEnumerable<TEntity>>(dto);
        }
    }
}
