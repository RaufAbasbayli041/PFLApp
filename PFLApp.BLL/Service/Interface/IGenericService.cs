using PFLApp.DAL.Entity;

namespace PFLApp.BLL.Service.Interface
{
    public interface IGenericService<TEntity, TDto> where TEntity : BaseEntity, new() where TDto : class
    {
        Task<TDto> GetByIdAsync(int id);
        Task<IEnumerable<TDto>> GetAllAsync();
        Task<TDto> AddAsync(TDto dto);
        Task<TDto> UpdateAsync(TDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
