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
    public class StatusTypesController : ControllerBase
    {
        private readonly TeamCalendarDataContext _context;

        public StatusTypesController(TeamCalendarDataContext context)
        {
            _context = context;
        }

        // GET: api/StatusTypes
        [HttpGet]
        public IEnumerable<StatusType> GetStatusTypes()
        {
            return _context.StatusTypes;
        }

        // GET: api/StatusTypes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStatusType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var statusType = await _context.StatusTypes.FindAsync(id);

            if (statusType == null)
            {
                return NotFound();
            }

            return Ok(statusType);
        }

        // PUT: api/StatusTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStatusType([FromRoute] int id, [FromBody] StatusType statusType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != statusType.StatusTypeId)
            {
                return BadRequest();
            }

            _context.Entry(statusType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StatusTypeExists(id))
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

        // POST: api/StatusTypes
        [HttpPost]
        public async Task<IActionResult> PostStatusType([FromBody] StatusType statusType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.StatusTypes.Add(statusType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStatusType", new { id = statusType.StatusTypeId }, statusType);
        }

        // DELETE: api/StatusTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStatusType([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var statusType = await _context.StatusTypes.FindAsync(id);
            if (statusType == null)
            {
                return NotFound();
            }

            _context.StatusTypes.Remove(statusType);
            await _context.SaveChangesAsync();

            return Ok(statusType);
        }

        private bool StatusTypeExists(int id)
        {
            return _context.StatusTypes.Any(e => e.StatusTypeId == id);
        }
    }
}