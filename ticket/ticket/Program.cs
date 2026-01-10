using System.Globalization;
using ticket.Data;
using ticket.Models;
using ticket.Services;

namespace ticket;

class Program
{
    static async Task Main(string[] args)
    {
        var context = new AppDbContext();
        var eventService = new EventService(context);

        await eventService.AddAsync(new Event()
        {

            Name = "Music Concert",
            Date = DateTime.Now.AddMonths(1),
            Price = 50.0m
        });
        
    var events =await eventService.GetAllAsync();
    Console.WriteLine("All Events:");
    events.ForEach(e=> Console.WriteLine(e));
    
    





    }
}