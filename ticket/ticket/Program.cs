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
        var ticketService = new TicketService(context);

        // await ticketService.BuyTicketAsync(4);
        // await ticketService.UseTicketAsync(2);
        
        // bool exit = false;
        // while (!exit)
        // {
        //     Console.WriteLine("-------Event Menu-------");  
        //     Console.WriteLine("1. Add Event");
        //     Console.WriteLine("2. Get All Events");
        //     Console.WriteLine("3. Get Event By Id");
        //     Console.WriteLine("4. Update Event");
        //     Console.WriteLine("5. Delete Event");
        //     Console.WriteLine("6. Exit");
        //     Console.Write("Select an option: ");
        //     
        //     string input = Console.ReadLine();
        //
        //
        //     switch (input)
        //     {
        //         case "1": 
        //             await AddEvent(); break;
        //         case "2":
        //             await GetAllEvents();
        //             break;
        //         case "3":
        //             await GetEventById(); break;
        //         case "4":
        //             await UpdateEvent();
        //             break;
        //         case "5":
        //                 await DeleteEvent();
        //                 break;
        //         case "6":
        //             exit = true;
        //             break;
        //             default:
        //                 Console.WriteLine("Invalid option. Please try again.");  
        //                 break;
        //     }
        // }

        Console.WriteLine("Program exited.");
        
        
        // async Task AddEvent()
        // {
        //     Console.Write("Enter Event Name: ");
        //     string name = Console.ReadLine();
        //     
        //     Console.Write("Enter Event Date (yyyy-MM-dd): ");
        //     string dateInput = Console.ReadLine();
        //     DateTime date = DateTime.ParseExact(dateInput, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        //     
        //     var ev = new Event
        //     {
        //         Name = name,
        //         Date = date
        //     };
        //     
        //     await eventService.AddAsync(ev);
        //     Console.WriteLine("Event added successfully!");
        // }
        //
        // async Task GetAllEvents()
        // {
        //     var events = await eventService.GetAllAsync();
        //     Console.WriteLine("All Events:");
        //     foreach (var ev in events)
        //     {
        //         Console.WriteLine(ev);
        //     }
        // }
        //
        // async Task GetEventById()
        // {
        //     Console.Write("Enter Event Id: ");
        //     int id = int.Parse(Console.ReadLine());
        //     var ev = await eventService.GetByIdAsync(id);
        //     if (ev != null)
        //     {
        //         Console.WriteLine("Event Details:");
        //         Console.WriteLine(ev);
        //     }
        //     else
        //     {
        //         Console.WriteLine("Event not found.");
        //     }
        // }
        //
        // async Task UpdateEvent()
        // {
        //     Console.Write("Enter Event Id to Update: ");
        //     int id = int.Parse(Console.ReadLine());
        //     var ev = await eventService.GetByIdAsync(id);
        //     if (ev != null)
        //     {
        //         Console.Write("Enter New Event Name: ");
        //         string name = Console.ReadLine();
        //         
        //         Console.Write("Enter New Event Date (yyyy-MM-dd): ");
        //         string dateInput = Console.ReadLine();
        //         DateTime date = DateTime.ParseExact(dateInput, "yyyy-MM-dd", CultureInfo.InvariantCulture);
        //         
        //         ev.Name = name;
        //         ev.Date = date;
        //         
        //         await eventService.UpdateAsync(ev);
        //         Console.WriteLine("Event updated successfully!");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Event not found.");
        //     }
        // }
        //
        // async Task DeleteEvent()
        // {
        //     Console.Write("Enter Event Id to Delete: ");
        //     int id = int.Parse(Console.ReadLine());
        //     await eventService.DeleteAsync(id);
        //     Console.WriteLine("Event deleted successfully!");
        // }

   
        
        
        
    }

    
}