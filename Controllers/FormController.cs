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

    [HttpPost]
    public ActionResult Login(Player newPlayer)
    {
        if (ModelState.IsValid)
        {
            TempData["lastName"] = newPlayer.LastName;
            TempData["firstName"] = newPlayer.FirstName;
            TempData["age"] = newPlayer.Age;
            TempData["team"] = newPlayer.Team;
        

        
        return RedirectToAction("PlayerInfo", "Players");
    }
    return View();
    }

}





