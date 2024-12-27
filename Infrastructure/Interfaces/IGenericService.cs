using Domain.Entities;
using Domain.Responses;

namespace Infrastructure.Interfaces;

public interface IGenericService<T,CD,UP>
{
    Task<Response<List<T>>> GetAll();
    Task<Response<bool>> Add(CD data);
    Task<Response<bool>> Update(UP data);
    Task<Response<bool>> Delete(int id);
}