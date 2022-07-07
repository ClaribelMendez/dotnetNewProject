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






    [HttpGet]
    public ActionResult Leaderboard()
    {
        IList<Player> playersList = new List<Player>() {

                new Player(){ PlayerID=1, PlayerFirstName="Steve", Age = 21 },
                new Player(){ PlayerID=2, PlayerFirstName="Bill", Age = 25 },
                new Player(){ PlayerID=3, PlayerFirstName="Ram", Age = 20 },
                new Player(){ PlayerID=4, PlayerFirstName="Ron", Age = 31 },
                new Player(){ PlayerID=5, PlayerFirstName="Rob", Age = 19 }
            };

        ViewData["players"] = playersList;

        return View();
    }






    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

