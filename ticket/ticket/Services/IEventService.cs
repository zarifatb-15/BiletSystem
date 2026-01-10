using ticket.Models;

namespace ticket.Services;

public interface IEventService
{
    Task<List<Event>> GetAllAsync();
    Task<Event> GetByIdAsync(int id);

    Task AddAsync(Event ev);
    
    Task UpdateAsync(Event ev);
    
    Task DeleteAsync(int id);
}