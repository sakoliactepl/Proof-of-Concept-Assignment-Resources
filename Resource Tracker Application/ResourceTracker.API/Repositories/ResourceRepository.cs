using Microsoft.EntityFrameworkCore;
using ResourceTracker.API.Data;
using ResourceTracker.API.Models;

namespace ResourceTracker.API.Repositories
{
    public class ResourceRepository : IResourceRepository
    {
        private readonly ResourceDbContext _context;

        public ResourceRepository(ResourceDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Resource>> GetAllAsync() => await _context.Resources.ToListAsync();
        public async Task<Resource?> GetByIdAsync(int empId) => await _context.Resources.FindAsync(empId);
        public async Task AddAsync(Resource resource)
        {
            _context.Resources.Add(resource);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Resource resource)
        {
            _context.Resources.Update(resource);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int empId)
        {
            var resource = await _context.Resources.FindAsync(empId);
            if (resource != null)
            {
                _context.Resources.Remove(resource);
                await _context.SaveChangesAsync();
            }
        }
    }
}
