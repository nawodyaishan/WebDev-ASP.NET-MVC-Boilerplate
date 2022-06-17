using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers;

public class HelloWorldController : Controller
{
    // GET
    public IActionResult Index()
    {
        DogViewModel doggo = new DogViewModel() {Name = "Cheetah", Age = 2};
        return View(doggo);
    }
    public IActionResult Create()
    {
        var dogVm = new DogViewModel();
        return View(dogVm);
    }

    public IActionResult CreateDog(DogViewModel dogViewModel)
    {
        return View("Index");
    }
    
    public string Hello()
    {
        return "who is there";
    }
}