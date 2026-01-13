namespace ticket.Models;

public class EventTicketCountDto
{
    public int EventId { get; set; }
    
    public string EventName { get; set; } = null!;
    
    public int SoldTickets{ get; set; }
}
