namespace Domain.Dtos;

public class CreateTeamsDto
{
    public string Name { get; set; }
    public int HackathonsId { get; set; }
    public DateTime CreatedDate { get; set; }
}