namespace ticket.Exceptions;

public class TicketAlreadyUsedException:Exception
{
    public TicketAlreadyUsedException (string message): base(message)
    {

       throw new TicketAlreadyUsedException("This ticket has already been used and cannot be used again.");

    }
}