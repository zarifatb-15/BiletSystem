namespace ticket.Models;

public class Ticket
{
    public int Id { get; set; }
    
    public decimal Price { get; set; }
    
    public int EventId { get; set; }
    
    public Event Event { get; set; }
    
    public bool IsUsed { get; set; } = false;
    

    public override string ToString()
    {
        return $"Event [Id={Id}, Price={Price}, EventId={EventId}]";
    }

    
}