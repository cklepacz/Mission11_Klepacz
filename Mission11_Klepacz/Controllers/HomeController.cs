using Microsoft.AspNetCore.Mvc;
using Mission11_Klepacz.Models;
using Mission11_Klepacz.Models.ViewModels;
using System.Diagnostics;

namespace Mission11_Klepacz.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;
        public HomeController(IBookRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;
            var book = new BooksListViewModel
            {
                Books = _repo.Books
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };
            return View(book);
        }
    }
}
