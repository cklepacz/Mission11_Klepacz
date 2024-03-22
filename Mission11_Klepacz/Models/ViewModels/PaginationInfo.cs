namespace Mission11_Klepacz.Models.ViewModels
{
    //Model for Pagination
    public class PaginationInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int) (Math.Ceiling((decimal)TotalItems / ItemsPerPage));
    }
}
