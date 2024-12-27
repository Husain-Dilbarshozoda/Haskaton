using Domain.Dtos;
using Domain.Entities;

namespace Infrastructure.Interfaces;

public interface ITeamsService:IGenericService<Teams,CreateTeamsDto,UpdateTeamsDto>
{
    
}