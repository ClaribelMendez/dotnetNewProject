
using System.ComponentModel.DataAnnotations;

namespace dotnetNewProject.Models;


public class NewPlayer
{
    // [StringLength(4,ErrorMessage="Name must not be more than 4 char")]
    public int PlayerID { get; set; }
    [Required]
    public string? PlayerFirstName { get; set; }
    public string? PlayerLastName { get; set; }
    public int Age { get; set; }
    public Teams PlayerTeam { get; set; }
    //Is the ViewBag object necessary?
    public object? ViewBag { get; set; }
    public string? TotalPlayers { get; set; }
}

public enum Teams
{
    Creators=1,
    Discover=2,
    Reach=3
}