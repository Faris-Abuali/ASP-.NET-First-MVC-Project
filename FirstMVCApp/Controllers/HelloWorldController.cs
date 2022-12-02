using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        private static List<DogViewModel> dogs = new List<DogViewModel>();

        public IActionResult Index()
        {
            ////return "This is the Index Page of HelloWorldController.cs";
            //DogViewModel doggo = new DogViewModel() { Name = "Sif", Age = 2 };
            return View(dogs);
        }

        public IActionResult Create()
        {
            //return View("Create");
            // 1. Create a clean new instance of the DogViewModel class
            var dogViewModel = new DogViewModel();
            return View(dogViewModel);
        }

        /// <summary>
        /// This receives data from the form in `Create.cshtml` when it is submitted
        /// </summary>
        /// <param name="dogViewModel"></param>
        /// <returns></returns>
        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            dogs.Add(dogViewModel); // add the newly submitted dog to the list
            return RedirectToAction(nameof(Index));
            /*
             Redirect the user to the method Index()
             */
        }

        public string Hello()
        {
            return "Who's there";
        }
    }
}
