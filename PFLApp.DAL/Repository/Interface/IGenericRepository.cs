using Microsoft.Extensions.Options;
using PFLApp.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFLApp.DAL.Repository.Interface
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity , new()
    {
        Task<IQueryable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id); 
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<bool> DeleteAsync(int id);
    }
}
