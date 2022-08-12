using dotnetNewProject.Models;
using Microsoft.AspNetCore.Mvc;


namespace PlayersList;

public class PlayersController : Controller
{
     List<Player> playersList = new List<Player>() {
            new Player(1, "Olive", "Tree", 21, (Teams)1),
            new Player(2, "Ray", "O'Sun", 25, (Teams)2),
            new Player(3, "Rod", "Knee", 20, (Teams)3),
            new Player(4, "Penelope", "Cruz", 31, (Teams)1)
            };

    // GET /players/PlayerInfo
    public ActionResult PlayerInfo()
    {
       
        return View(playersList); 
    }

    public ActionResult Profile(int id)
    {
        var player = playersList.FirstOrDefault( x=> x.PlayerID == id);

        return View(player);
    }
}
