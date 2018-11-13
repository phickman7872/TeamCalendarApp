using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamCalendarApp.Data;
using TeamCalendarApp.Models;

namespace TeamCalendarApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly TeamCalendarDataContext _context;

        public EventsController(TeamCalendarDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Event> GetEvents()
        {
            return _context.Events;
        }

        [HttpGet("{month}/{year}")]
        public IEnumerable<Event> GetEvents(int month, int year)
        {
            return _context.Events.Where(x => x.StartsAt.Month >= month &&
            x.StartsAt.Year == year);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEvent([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var @event = await _context.Events.FindAsync(id);

            if (@event == null)
            {
                return NotFound();
            }

            return Ok(@event);
        }

        [HttpPost]
        public async Task<IActionResult> SaveEvent([FromBody] Event @event)
        {
            if (@event.EventId > 0)
            {
                // Update the event.
                var v = await _context.Events.Where(a => a.EventId == @event.EventId).FirstOrDefaultAsync();

                if (v != null)
                {
                    v.EventTypeId = @event.EventTypeId;
                    v.Username = @event.Username;
                    v.Title = await GetTitle(@event);
                    v.Description = @event.Description;
                    v.StartsAt = @event.StartsAt;
                    v.EndsAt = @event.EndsAt;
                    v.IsFullDay = @event.IsFullDay;
                    v.ThemeColor = await GetThemeColor(@event.EventTypeId);
                }
            }
            else
            {
                @event.ThemeColor = await GetThemeColor(@event.EventTypeId);
                @event.Title = await GetTitle(@event);

                _context.Events.Add(@event);
            }

            await _context.SaveChangesAsync();

            return new JsonResult(new { status = true });
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteEvent([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var @event = await _context.Events.FindAsync(id);
            if (@event == null)
            {
                return NotFound();
            }

            _context.Events.Remove(@event);
            await _context.SaveChangesAsync();

            return Ok(@event);
        }

        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.EventId == id);
        }

        private async Task<string> GetThemeColor(int eventTypeId)
        {
            var eventType = await _context.EventTypes.Where(x => x.EventTypeId == eventTypeId).FirstOrDefaultAsync();
            var themeColor = string.Empty;

            if (eventType == null)
            {
                themeColor = "Default";
            }
            else
            {
                themeColor = eventType.ThemeColor;
            }

            return themeColor;
        }

        private async Task<string> GetTitle(Event @event)
        {
            string title = string.Empty;
            var eventType = await _context.EventTypes.Where(x => x.EventTypeId == @event.EventTypeId).FirstOrDefaultAsync();
            var user = await _context.Users.Where(x => x.Username.Equals(@event.Username, StringComparison.OrdinalIgnoreCase)).FirstOrDefaultAsync();

            if (eventType != null && user != null)
            {
                title = $"{eventType.Prefix}-{user.FirstName}";
            }

            return title;
        }
    }
}