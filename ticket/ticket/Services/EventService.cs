using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ticket.Data;
using ticket.Models;

namespace ticket.Services;

public class EventService: IEventService
{
    private readonly AppDbContext _context;

    public EventService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Event>> GetAllAsync()
    {
        return await _context.Events.ToListAsync();
    }

    public async Task<Event> GetByIdAsync(int id)
    {
        return await _context.Events.FindAsync(id);
    }

    public async Task AddAsync(Event ev)
    {
        await _context.Events.AddAsync(ev);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Event ev)
    {
        _context.Events.Update(ev);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var ev = await _context.Events.FindAsync(id);
        if (ev != null)
        {
            _context.Events.Remove(ev);
            await _context.SaveChangesAsync();
        }
    }

}