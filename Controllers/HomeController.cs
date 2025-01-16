using System.Diagnostics;
using HelloLabMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloLabMvc.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            Person p1 = new Person();
            p1.FirstName = "John";
            p1.LastName = "Doe";

            return View(p1);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
