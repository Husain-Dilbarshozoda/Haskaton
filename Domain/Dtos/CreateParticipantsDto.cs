namespace Domain.Dtos;

public class CreateParticipantsDto
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int TeamsId { get; set; }
    public string Role { get; set; }
    public DateTime JoinedDate { get; set; }
}