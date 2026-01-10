using ticket.Data;
using ticket.Exceptions;
using ticket.Models;

namespace ticket.Services;

public class TicketService:ITicketService
{
    private readonly AppDbContext _context;
    
    public TicketService(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<Ticket> BuyTicketAsync(int eventId)
    {
        var ev = await _context.Events.FindAsync(eventId);
        if (ev == null)
            throw  new System.Exception("Event not found");
        if (ev.Date < DateTime.UtcNow)
            throw new EventExpiredException();
        var ticket = new Ticket()
        {
            EventId = eventId,
            IsUsed = false,
            Price = ev.Price
        };
        await _context.Tickets.AddAsync(ticket);
        await _context.SaveChangesAsync();
        return ticket;
    }

    public Task UseTicketAsync(int ticketId)
    {
        var ticket = _context.Tickets.Find(ticketId);
        if (ticket == null)
            throw new System.Exception("Ticket not found");
        if (ticket.IsUsed)
            throw new System.Exception("Ticket already used");
        ticket.IsUsed = true;
        _context.Tickets.Update(ticket);
        return _context.SaveChangesAsync();
    }
}