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

    public async Task<Event?> GetEventByIdAsync(int eventId)
    {
      return await _context.Events
          .Include(e=>e.Tickets)
          .FirstOrDefaultAsync(e=>e.Id==eventId);
    }

    public Task<List<Event>> GetAllEventsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Event> CreateEventAsync(Event newEvent)
    {
        throw new NotImplementedException();
    }

    public Task<Event> UpdateEventAsync(int eventId, Event updatedEvent)
    {
        throw new NotImplementedException();
    }

    public Task DeleteEventAsync(int eventId)
    {
        throw new NotImplementedException();
    }

    public Task<List<EventTicketCountDto>> GetEventsBySoldTicketAsync()
    {
throw  new NotImplementedException();
    }

    public Task<List<Event>> GetEventsByIncomeAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Event>> GetFutureEventsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<string>> GetPastEventStatisticsAsync()
    {
        throw new NotImplementedException();
    }
}