using ResourceTracker.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ResourceTracker.API.Repositories
{
    public interface IResourceRepository
    {
        Task<IEnumerable<Resource>> GetAllAsync();
        Task<Resource?> GetByIdAsync(int empId);
        Task AddAsync(Resource resource);
        Task UpdateAsync(Resource resource);
        Task DeleteAsync(int empId);
    }
}
