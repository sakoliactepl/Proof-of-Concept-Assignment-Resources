using ResourceTracker.API.Models;
using ResourceTracker.API.Repositories;

namespace ResourceTracker.API.Services
{
    public class ResourceService : IResourceService
    {
        private readonly IResourceRepository _repo;

        public ResourceService(IResourceRepository repo)
        {
            _repo = repo;
        }

        public Task<IEnumerable<Resource>> GetAllResourcesAsync() => _repo.GetAllAsync();
        public Task<Resource?> GetResourceByIdAsync(int empId) => _repo.GetByIdAsync(empId);
        public Task AddResourceAsync(Resource resource) => _repo.AddAsync(resource);
        public Task UpdateResourceAsync(Resource resource) => _repo.UpdateAsync(resource);
        public Task DeleteResourceAsync(int empId) => _repo.DeleteAsync(empId);
    }
}
