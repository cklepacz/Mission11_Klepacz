using Microsoft.AspNetCore.Mvc;
using Mission11_Klepacz.Models;
using System.Diagnostics;

namespace Mission11_Klepacz.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
}
