using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ticket.Data;
using ticket.Models;

namespace ticket.Services;

public class EventService: IEventService
{
    private readonly AppDbContext _context;

    public EventService(AppDbContext context)
    {
        _context = context;
    }
}