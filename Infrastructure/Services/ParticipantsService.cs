using System.Net;
using Domain.Dtos;
using Domain.Entities;
using Domain.Responses;
using Infrastructure.Data;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class ParticipantsService(DataContext context):IParticipantsService
{
    public async Task<Response<List<Participants>>> GetAll()
    {
        var res = await context.Participants.ToListAsync();
        return  new Response<List<Participants>>(res);
    }

    public async Task<Response<bool>> Add(CreateParticipantsDto data)
    {
        var participants = new Participants()
        {
            Name = data.Name,
            Email = data.Email,
            TeamsId = data.TeamsId,
            Role = data.Role,
            JoinedDate = data.JoinedDate
        };
        await context.Participants.AddAsync(participants);
        var res =await context.SaveChangesAsync();
        if (res == 0)
        {
            return new Response<bool>(HttpStatusCode.InternalServerError,"Server error!!!");
        }

        return new Response<bool>(true);

    }

    public async Task<Response<bool>> Update(UpdateParticipantsDto data)
    {
        var existingParticipants = await context.Participants.FirstOrDefaultAsync(x=>x.Id==data.Id);

        if (existingParticipants==null)
        {
            return new Response<bool>(HttpStatusCode.NotFound,"Participants not found!!!");
        }

        existingParticipants.Name = data.Name;
        existingParticipants.JoinedDate = data.JoinedDate;
        existingParticipants.Email = data.Email;
        existingParticipants.TeamsId = data.TeamsId;
        existingParticipants.Role = data.Role;
        
        var res =await context.SaveChangesAsync();
        if (res == 0)
        {
            return new Response<bool>(HttpStatusCode.InternalServerError,"Server error!!!");
        }

        return new Response<bool>(true);
    }

    public async Task<Response<bool>> Delete(int id)
    {
        var existingParticipants = await context.Participants.FirstOrDefaultAsync(x=>x.Id==id);

        if (existingParticipants==null)
        {
            return new Response<bool>(HttpStatusCode.NotFound,"Participants not found!!!");
        }

        context.Participants.Remove(existingParticipants);
        var res = await context.SaveChangesAsync();
        if (res == 0)
        {
            return new Response<bool>(HttpStatusCode.InternalServerError,"Server error!!!");
        }

        return new Response<bool>(true);
        
    }
}