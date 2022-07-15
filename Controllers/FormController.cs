using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dotnetNewProject.Models;

namespace registrationForm.Controllers;

public class FormController : Controller
{

    public IActionResult Login()
    {
        return View(new Player());
    }


    [HttpPost]
    public ActionResult Login(Player player)
    {

        ViewBag.name = player.PlayerFirstName;

        return View();
    }

}





