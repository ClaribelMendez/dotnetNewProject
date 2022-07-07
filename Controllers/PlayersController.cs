
using dotnetNewProject.Models;
using Microsoft.AspNetCore.Mvc;


namespace PlayersList;

public class PlayersController : Controller
{
    // GET /players/leaderboard
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

        return View(); //the view for *this* controller / action combo
        // Views/Players/Leaderboard.cshtml

        // return View("~/Views/Players/Leaderboard.cshtml");
        // explicit - specifying manually - written it out
        //   pro - little more obvious / intuitive / easier to follow
        //
        // return View();
        // implicit - specified by convention - not written anywhere / magic
        // use implicit when there's a really strong a convention
        // pro - saves typing, less noisy

    }


}
