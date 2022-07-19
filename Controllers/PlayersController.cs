using dotnetNewProject.Models;
using Microsoft.AspNetCore.Mvc;


namespace PlayersList;

public class PlayersController : Controller
{
    // GET /players/PlayerInfo
    public ActionResult PlayerInfo()
    {
        var playersList = new List<Player>() {
            new Player(1, "Olive", "Tree", 21, (Teams)1),
            new Player(2, "Ray", "O'Sun", 25, (Teams)2),
            new Player(3, "Rod", "Knee", 20, (Teams)3),
            new Player(4, "Penelope", "Cruz", 31, (Teams)1)


                // new Player(){ PlayerID=1, FirstName="Olive", LastName="Tree", Age = 21 },
                // new Player(){ PlayerID=2, FirstName="Ray", LastName="O'Sun", Age = 25 },
                // new Player(){ PlayerID=3, FirstName="Rod", LastName="Knee", Age = 20 },
                // new Player(){ PlayerID=4, FirstName="Penelope", LastName="Cruz", Age = 31 },
            };

        ViewData["players"] = playersList;

        return View(); //the view for *this* controller / action combo
        // Views/Players/PlayerInfo.cshtml

        // return View("~/Views/Players/PlayerInfo.cshtml");
        // explicit - specifying manually - written it out
        //   pro - little more obvious / intuitive / easier to follow
        //
        // return View();
        // implicit - specified by convention - not written anywhere / magic
        // use implicit when there's a really strong a convention
        // pro - saves typing, less noisy

    }

}
