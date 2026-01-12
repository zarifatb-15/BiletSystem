using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
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

    public async Task<Event> GetEventByIdAsync(int eventId)
    {
      var eventEntity=  await _context.Events.FindAsync(eventId);
      if (eventEntity == null)
          return null;
      return eventEntity;
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
}