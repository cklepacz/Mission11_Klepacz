namespace Mission11_Klepacz.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
