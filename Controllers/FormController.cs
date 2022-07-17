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
    //     'PlayerFirstName': kyle
    //     'PlayerLastName': mit
    //     id: 7
    // ]
    [HttpPost]
    public ActionResult Login(NewPlayer player)
    {
        // NOTE: (string PlayerLastName)
        TempData["lastName"] = player.PlayerLastName;

        TempData["firstName"] = player.PlayerFirstName;


        return RedirectToAction("PlayerInfo", "Players");
    }

}





