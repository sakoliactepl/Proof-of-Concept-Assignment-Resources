using ResourceTracker.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ResourceTracker.API.Services
{
    public interface IResourceService
    {
        Task<IEnumerable<Resource>> GetAllResourcesAsync();
        Task<Resource?> GetResourceByIdAsync(int empId);
        Task AddResourceAsync(Resource resource);
        Task UpdateResourceAsync(Resource resource);
        Task DeleteResourceAsync(int empId);
    }
}
