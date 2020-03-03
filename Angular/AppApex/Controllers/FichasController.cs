using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppApex.Models;

namespace AppApex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FichasController : ControllerBase
    {
        private readonly AppApexDbContext _context;

        public FichasController(AppApexDbContext context)
        {
            _context = context;
        }

        // GET: api/Fichas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ficha>>> GetFichas()
        {
            return await _context.Fichas.ToListAsync();
        }

        // GET: api/Fichas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ficha>> GetFicha(int id)
        {
            var ficha = await _context.Fichas.FindAsync(id);

            if (ficha == null)
            {
                return NotFound();
            }

            return ficha;
        }

        // PUT: api/Fichas/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFicha(int id, Ficha ficha)
        {
            if (id != ficha.Id)
            {
                return BadRequest();
            }

            _context.Entry(ficha).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FichaExists(id))
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

        // POST: api/Fichas
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Ficha>> PostFicha(Ficha ficha)
        {
            _context.Fichas.Add(ficha);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFicha", new { id = ficha.Id }, ficha);
        }

        // DELETE: api/Fichas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ficha>> DeleteFicha(int id)
        {
            var ficha = await _context.Fichas.FindAsync(id);
            if (ficha == null)
            {
                return NotFound();
            }

            _context.Fichas.Remove(ficha);
            await _context.SaveChangesAsync();

            return ficha;
        }

        private bool FichaExists(int id)
        {
            return _context.Fichas.Any(e => e.Id == id);
        }
    }
}
