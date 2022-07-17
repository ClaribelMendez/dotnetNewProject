using dotnetNewProject.Models;
using Microsoft.AspNetCore.Mvc;


namespace PlayersList;

public class PlayersController : Controller
{
    // GET /players/PlayerInfo
    public ActionResult PlayerInfo()
    {
        var playersList = new List<NewPlayer>() {

                new NewPlayer(){ PlayerID=1, PlayerFirstName="Olive", PlayerLastName="Tree", Age = 21 },
                new NewPlayer(){ PlayerID=2, PlayerFirstName="Ray", PlayerLastName="O'Sun", Age = 25 },
                new NewPlayer(){ PlayerID=3, PlayerFirstName="Rod", PlayerLastName="Knee", Age = 20 },
                new NewPlayer(){ PlayerID=4, PlayerFirstName="Penelope", PlayerLastName="Cruz", Age = 31 },
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
