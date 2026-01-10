using ticket.Models;

namespace ticket.Services;

public interface ITicketService
{
    Task <Ticket> BuyTicketAsync(int eventId);
    Task UseTicketAsync(int ticketId);
}