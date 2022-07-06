
using Microsoft.AspNetCore.Mvc;


namespace PlayersList;

public class LeaderboardController : Controller
{

    public class Player
    {
        public int PlayerID { get; set; }
        public string? PlayerFirstName { get; set; }
        public int Age { get; set; }
    

        IList<Player> playersList = new List<Player>() {

                new Player(){ PlayerID=1, PlayerFirstName="Steve", Age = 21 },
                new Player(){ PlayerID=2, PlayerFirstName="Bill", Age = 25 },
                new Player(){ PlayerID=3, PlayerFirstName="Ram", Age = 20 },
                new Player(){ PlayerID=4, PlayerFirstName="Ron", Age = 31 },
                new Player(){ PlayerID=5, PlayerFirstName="Rob", Age = 19 }
            };
    }
    

    public ActionResult Leaderboard()

   {
            ViewBag.Message = "Hello";

            return View();
        }

    
}
