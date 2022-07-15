namespace dotnetNewProject.Models;


public class Player
{
    public int PlayerID { get; set; }
    public string? PlayerFirstName { get; set; }
    public string? PlayerLastName { get; set; }
    public int Age { get; set; }
    public string? Gender { get; set; }
    //Is the ViewBag object necessary?
    public object? ViewBag { get; set; }
    public string? TotalPlayers { get; set; }
}