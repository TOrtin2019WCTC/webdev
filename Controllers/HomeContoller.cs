using Microsoft.AspNetCore.Mvc;
using Client.Models;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        private INorthwindRepository repository;
        public HomeController(INorthwindRepository repo) => repository = repo;


        public IActionResult Index()
        {
            return View(repository.Categories.OrderBy(c => c.CategoryName));
        }
    }
}
