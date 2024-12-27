namespace Domain.Entities;

public class Participants
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int TeamsId { get; set; }
    public string Role { get; set; }
    public DateTime JoinedDate { get; set; }

    public Teams Teams { get; set; }
}