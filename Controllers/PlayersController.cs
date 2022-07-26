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
            };
        // var Model = playersList;

        return View(playersList); 
    }

}
