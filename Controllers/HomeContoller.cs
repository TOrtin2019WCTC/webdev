using Microsoft.AspNetCore.Mvc;
using Client.Models;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        private INorthwindRepository repository;
        public HomeController(INorthwindRepository repo) => repository = repo;

        public IActionResult index() => View(repository.Products);
    }
}
