namespace Mission11.Models.ViewModels
{
    public class BooksListViewModel
    {
        public IQueryable<Project> Projects { get; set; }

        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
