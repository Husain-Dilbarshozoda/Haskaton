namespace Domain.Entities;

public class Teams
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int HackathonsId { get; set; }
    public DateTime CreatedDate { get; set; }

    public Hackathons Hackathons { get; set; }
    public List<Participants> Participants { get; set; }
}