using E_Ticket.Data.Base;
using E_Ticket.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace E_Ticket.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {

        public ActorsService(AppDbContext context) : base(context) { }


    }
    //public class ActorsService : IActorsService
    //{
    //    private readonly AppDbContext _context;
    //    public ActorsService(AppDbContext context)
    //    {
    //        _context = context;
    //    }
    //    public async Task AddAsync(Actor actor)
    //    {
    //       await _context.Actors.AddAsync(actor);
    //       await _context.SaveChangesAsync();
    //    }

    //    public async Task DeleteAsync(int id)
    //    {
    //        var result = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
    //        _context.Actors.Remove(result);
    //        await _context.SaveChangesAsync();
    //    }

    //    public async Task<Actor> UpdateAsync(int id, Actor newActor)
    //    {
    //        _context.Update(newActor);
    //        await _context.SaveChangesAsync();
    //        return newActor;
    //    }

    //    Task<IEnumerable<Actor>> IActorsService.GetAllAsync()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    Task<Actor> IActorsService.GetByIdAsync(int id)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
