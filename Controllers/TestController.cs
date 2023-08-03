using Microsoft.AspNetCore.Mvc;
using MVC_Routing.Models;

namespace MVC_Routing.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index(string name, int id)
        {
            Product product = new Product { Id = id, Name = name };
            return View(product);
        }
    }
}
