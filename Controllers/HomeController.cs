using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnetNewProject.Models;

namespace dotnetNewProject.Controllers;


public class Person
{
    public string? Name { get; set; }
    public bool IsCat { get; set; }
}


public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;


    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        // var x = 3 + 2;
        // call sql code
        // var data = MyData.getClients();
        // hardcode a person
        var myPerson = new Person();
        myPerson.Name = "Jane Doe";
        myPerson.IsCat = true;

        // passing data to the view
        // view model - all the information the view needs to render
        return View(myPerson);
    }

    [HttpPost]
    public IActionResult Index(bool IsCat)
    {
        // TODO - save data
        // return them to a meaningful new page

        return View();
    }


    public IActionResult Login()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

