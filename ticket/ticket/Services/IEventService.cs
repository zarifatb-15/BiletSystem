using ticket.Models;

namespace ticket.Services;

public interface IEventService
{
    Task<Event> GetEventByIdAsync(int eventId);
    
    Task<List<Event>> GetAllEventsAsync();
    
    Task<Event> CreateEventAsync(Event newEvent);
    
    Task<Event> UpdateEventAsync(int eventId, Event updatedEvent);
    
    Task DeleteEventAsync(int eventId);
    
    
}