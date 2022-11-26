using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            //return "This is the Index Page of HelloWorldController.cs";
            DogViewModel doggo = new DogViewModel() { Name = "Sif", Age = 2 };
            return View(doggo);
        }

        public IActionResult Create()
        {
            //return View("Create");
            return View("Create");
        }

        public string Hello()
        {
            return "Who's there";
        }
    }
}
