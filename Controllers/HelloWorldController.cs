using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers;

public class HelloWorldController : Controller
{
    // GET

    private List<DogViewModel> dogs = new List<DogViewModel>(); 
    public IActionResult Index()
    {
        return View(dogs);
    }
    public IActionResult Create()
    {
        var dogVm = new DogViewModel();
        return View(dogVm);
    }

    public IActionResult CreateDog(DogViewModel dogViewModel)
    {
        // return View("Index");

        return RedirectToAction(nameof(Index));
    }
    
    public string Hello()
    {
        return "who is there";
    }
}