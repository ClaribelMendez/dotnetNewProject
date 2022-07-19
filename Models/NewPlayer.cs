
using System.ComponentModel.DataAnnotations;

namespace dotnetNewProject.Models;


public class Player
{
    // [StringLength(4,ErrorMessage="Name must not be more than 4 char")]
    public int PlayerID { get; set; }
    [Required]
    public string? FirstName { get; set; } 
    public string? LastName { get; set; }
    public int Age { get; set; }
    public Teams Team { get; set; }
    //Is the ViewBag object necessary?
    public object? ViewBag { get; set; }
    public string? TotalPlayers { get; set; }

    public Player(int playerID, string firstName, string lastName, int age, Teams team)
    {
        this.PlayerID = playerID;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Team = team;
    }

    public Player()
    {

    }

}

public enum Teams
{
    Unknown = 0,
    Creators = 1,
    Discover = 2,
    Reach = 3
}