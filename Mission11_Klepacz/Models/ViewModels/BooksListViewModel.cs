namespace Mission11_Klepacz.Models.ViewModels
{
    public class BooksListViewModel
    {
        //Get the database and pagination info and pass it to the index
        public IQueryable<Book> Books { get; set;}
        public PaginationInfo PaginationInfo { get; set;} = new PaginationInfo();
    }
}
