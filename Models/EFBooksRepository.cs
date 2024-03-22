
namespace Mission11.Models
{
    public class EFBooksRepository : IBooksRepository
    {
        private ProjectContext _context;
        public EFBooksRepository(ProjectContext temp) 
        {
            _context = temp;   
        }
        public IQueryable<Project> Books => _context.Books;
    }
}
