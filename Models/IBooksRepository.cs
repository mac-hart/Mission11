namespace Mission11.Models
{
    public interface IBooksRepository
    {
        public IQueryable<Project> Books { get; }
    }
}
