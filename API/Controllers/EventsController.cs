using System;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers;

public class EventsController(DataContext context) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<Event>>> GetEvents()
    {
        return await context.Events.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Event>> GetEventDetail(string id)
    {
        var eventDetail = await context.Events.FindAsync(id);
        
        if(eventDetail == null) return NotFound();

        return eventDetail!;
    }
}
