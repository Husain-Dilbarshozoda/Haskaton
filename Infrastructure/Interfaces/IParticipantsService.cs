using Domain.Dtos;
using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface IParticipantsService:IGenericService<Participants,CreateParticipantsDto,UpdateParticipantsDto>
{
    
}