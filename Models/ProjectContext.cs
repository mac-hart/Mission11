using Microsoft.EntityFrameworkCore;

namespace Mission11.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext (DbContextOptions<ProjectContext> options) : base(options) { }

        public DbSet<Project> Books { get; set;}
    }
}
