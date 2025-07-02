using AutoMapper;
using PFLApp.BLL.Service.Interface;
using PFLApp.DAL.Entity;
using PFLApp.DAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFLApp.BLL.Service.Repository
{
    public class GenericService<TEntity, TDto> : IGenericService<TEntity, TDto>
    where TEntity : BaseEntity, new()
    where TDto : class
    {
        protected readonly IGenericRepository<TEntity> _repository;
        private readonly IMapper _mapper;

        public GenericService(IMapper mapper, IGenericRepository<TEntity> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<TDto> AddAsync(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            var addedEntity = await _repository.AddAsync(entity);
            var result = _mapper.Map<TDto>(addedEntity);
            return result;

        }

        public async Task<bool> DeleteAsync(int id)
        {
            var data = await _repository.GetByIdAsync(id);
            if (data == null)
            {
                return false;
            }
            var isDeleted = await _repository.DeleteAsync(id);
            if (!isDeleted)
            {
                return false;
            }
            return isDeleted;
        }

        public async Task<IEnumerable<TDto>> GetAllAsync()
        {
           var datas = await _repository.GetAllAsync();

            if (datas == null || !datas.Any())
            {
                return Enumerable.Empty<TDto>();
            }
            var result = _mapper.Map<IEnumerable<TDto>>(datas);
            return result;

        }

        public async Task<TDto> GetByIdAsync(int id)
        {
           var data = await _repository.GetByIdAsync(id);
            if (data == null)
            {
                return null;
            }
            var dto = _mapper.Map<TDto>(data);
            return dto;
        }

        public async Task<TDto> UpdateAsync(TDto dto)
        {
            var data = _mapper.Map<TEntity>(dto);
            var updatedEntity = await _repository.UpdateAsync(data);
            if (updatedEntity == null)
            {
                return null;
            }
            var result = _mapper.Map<TDto>(updatedEntity);
            return result;

        }
    }
}
