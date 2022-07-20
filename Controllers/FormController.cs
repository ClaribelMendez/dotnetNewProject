using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnetNewProject.Models;


namespace registrationForm.Controllers;

public class FormController : Controller
{

    public IActionResult Login()
    {
        return View();
    }

    // [
    //     'key': value
    //     'FirstName': kyle
    //     'LastName': mit
    //     id: 7
    // ]
    [HttpPost]
    public ActionResult Login(Player player)
    {
        // NOTE: (string LastName)
        TempData["lastName"] = player.LastName;
        TempData["firstName"] = player.FirstName;
        TempData["age"] = player.Age;
        TempData["team"] = player.Team;



        return RedirectToAction("PlayerInfo", "Players");
    }

}





