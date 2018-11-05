using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamCalendarApp.Data;
using TeamCalendarApp.Models;

namespace TeamCalendarApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusItemsController : ControllerBase
    {
        private readonly TeamCalendarDataContext _context;

        public StatusItemsController(TeamCalendarDataContext context)
        {
            _context = context;
        }

        // GET: api/StatusItems
        [HttpGet]
        public IEnumerable<StatusItem> GetStatusItems()
        {
            return _context.StatusItems;
        }

        // GET: api/StatusItems/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStatusItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var statusItem = await _context.StatusItems.FindAsync(id);

            if (statusItem == null)
            {
                return NotFound();
            }

            return Ok(statusItem);
        }

        // PUT: api/StatusItems/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStatusItem([FromRoute] int id, [FromBody] StatusItem statusItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != statusItem.StatusItemId)
            {
                return BadRequest();
            }

            _context.Entry(statusItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StatusItemExists(id))
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

        // POST: api/StatusItems
        [HttpPost]
        public async Task<IActionResult> PostStatusItem([FromBody] StatusItem statusItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.StatusItems.Add(statusItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStatusItem", new { id = statusItem.StatusItemId }, statusItem);
        }

        // DELETE: api/StatusItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStatusItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var statusItem = await _context.StatusItems.FindAsync(id);
            if (statusItem == null)
            {
                return NotFound();
            }

            _context.StatusItems.Remove(statusItem);
            await _context.SaveChangesAsync();

            return Ok(statusItem);
        }

        private bool StatusItemExists(int id)
        {
            return _context.StatusItems.Any(e => e.StatusItemId == id);
        }
    }
}