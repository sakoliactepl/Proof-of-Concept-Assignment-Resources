using Microsoft.EntityFrameworkCore;
using ResourceTracker.API.Models;

namespace ResourceTracker.API.Data
{
    public class ResourceDbContext : DbContext
    {
        public ResourceDbContext(DbContextOptions<ResourceDbContext> options)
            : base(options) { }

        public DbSet<Resource> Resources { get; set; }
    }
}
