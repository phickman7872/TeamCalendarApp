using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamCalendarApp.Data;
using TeamCalendarApp.Models;

namespace TeamCalendarApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventTypesController : ControllerBase
    {
        private readonly TeamCalendarDataContext _context;

        public EventTypesController(TeamCalendarDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<EventType> GetEventTypes()
        {
            var eventTypes = _context.EventTypes.ToList();

            return eventTypes;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEventType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var eventType = await _context.EventTypes.FindAsync(id);

            if (eventType == null)
            {
                return NotFound();
            }

            return Ok(eventType);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutEventType([FromRoute] int id, [FromBody] EventType eventType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eventType.EventTypeId)
            {
                return BadRequest();
            }

            _context.Entry(eventType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> PostEventType([FromBody] EventType eventType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.EventTypes.Add(eventType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEventType", new { id = eventType.EventTypeId }, eventType);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEventType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var eventType = await _context.EventTypes.FindAsync(id);
            if (eventType == null)
            {
                return NotFound();
            }

            _context.EventTypes.Remove(eventType);
            await _context.SaveChangesAsync();

            return Ok(eventType);
        }

        private bool EventTypeExists(int id)
        {
            return _context.EventTypes.Any(e => e.EventTypeId == id);
        }
    }
}