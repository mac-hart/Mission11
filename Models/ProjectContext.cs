using Microsoft.EntityFrameworkCore;

namespace Mission11.Models
{
    public class ProjectContext : DbContext
    {
        public ProjectContext (DbContextOptions<ProjectContext> options) : base(options) { }
        
        // set the database
        public DbSet<Project> Books { get; set;}
    }
}
