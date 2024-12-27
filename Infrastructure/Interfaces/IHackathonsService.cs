using Domain.Dtos;
using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface IHackathonsService:IGenericService<Hackathons,CreateHackathonsDto,UpdateHackathonsDto>
{
    
}