using System.Diagnostics.Tracing;
namespace ticket.Exceptions;

public class EventExpiredException:Exception
{
    public EventExpiredException() : base("Event has already expired and cannot be accessed.")
    {
        
    }
    

}