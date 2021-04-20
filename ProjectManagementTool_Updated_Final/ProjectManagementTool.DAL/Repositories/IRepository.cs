using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementTool.DAL.Repositories
{
    public interface IRepository<T> where T: class
    {
        bool Exists(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int Id);
        Task<T> GetByIdAsync(int Id);
        Task<List<T>> GetAllAsync();

    }
}
