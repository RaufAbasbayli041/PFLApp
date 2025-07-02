using PFLApp.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFLApp.BLL.Service.Interface
{
    public interface IGenericService<TDto, TEntity>
    {
        Task<IEnumerable<TDto>> GetAllAsync();
        Task<TDto?> GetByIdAsync(int id);
        Task<TDto> AddAsync(TDto dto);
        Task<bool> DeleteAsync(int id);
    }
}
