using AutoMapper;
using FluentValidation;
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
    public class GenericService<TEntity,TDto> : IGenericService<TEntity, TDto> where TEntity : BaseEntity, new() where TDto : class
    {
        protected readonly IGenericRepository<TEntity> _repository;
        protected readonly IMapper _mapper;
        private readonly IValidator<TDto> _validator;

        public GenericService(IGenericRepository<TEntity> repository, IMapper mapper, IValidator<TDto> validator)
        {
            _repository = repository;
            _mapper = mapper;
            _validator = validator;
        }

        public async Task<IEnumerable<TDto>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }

      

        public async Task<TDto> AddAsync(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            var added = await _repository.AddAsync(entity);
            return _mapper.Map<TDto>(added);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity == null) return false;

            var deleted = await _repository.DeleteAsync(id);
            return deleted;

        }

        public async Task<TDto> GetByIdAsync(int id)
        {
            var data = await _repository.GetByIdAsync(id);
            if (data == null) return null;
            return _mapper.Map<TDto>(data);

        }

        public async Task<TDto> UpdateAsync(int id, TDto dto)
        {
            var existing = await _repository.GetByIdAsync(id);
            if (existing == null)  return null;
            var entity = _mapper.Map(dto, existing);
            var updated = await _repository.UpdateAsync(entity);
            if (updated == null) return null;
            return _mapper.Map<TDto>(updated);
        }
    }
}
