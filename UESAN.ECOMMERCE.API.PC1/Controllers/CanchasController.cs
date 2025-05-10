using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UESAN.ECOMMERCE.API.PC1.Models;

namespace USESAN_ECOMMERCE_APLIPC1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CanchasController : ControllerBase
    {
        private readonly ReservasDeportivasDbContext _context;

        public CanchasController(ReservasDeportivasDbContext context)
        {
            _context = context;
        }

        // GET: api/Canchas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cancha>>> GetCanchas()
        {
            return await _context.Canchas.ToListAsync();
        }

        // GET: api/Canchas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cancha>> GetCancha(int id)
        {
            var cancha = await _context.Canchas.FindAsync(id);

            if (cancha == null)
            {
                return NotFound();
            }

            return cancha;
        }

        // POST: api/Canchas
        [HttpPost]
        public async Task<ActionResult<Cancha>> PostCancha(Cancha cancha)
        {
            _context.Canchas.Add(cancha);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCancha), new { id = cancha.Id }, cancha);
        }

        // PUT: api/Canchas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCancha(int id, Cancha cancha)
        {
            if (id != cancha.Id)
            {
                return BadRequest();
            }

            _context.Entry(cancha).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CanchaExists(id))
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

        // DELETE: api/Canchas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCancha(int id)
        {
            var cancha = await _context.Canchas.FindAsync(id);
            if (cancha == null)
            {
                return NotFound();
            }

            _context.Canchas.Remove(cancha);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CanchaExists(int id)
        {
            return _context.Canchas.Any(e => e.Id == id);
        }
    }
}