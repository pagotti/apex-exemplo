using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BlogBack.Models;

namespace BlogBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostagensController : ControllerBase
    {
        private readonly BlogDbContext _context;

        public PostagensController(BlogDbContext context)
        {
            _context = context;
        }

        // GET: api/Postagens
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Postagem>>> GetPostagems()
        {
            return await _context.Postagems.
                Include(p => p.Autor).ToListAsync();
        }

        // GET: api/Postagens/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Postagem>> GetPostagem(int id)
        {
            var postagem = await _context.Postagems.
                Include(p => p.Autor).
                Include(p => p.Categorias).ThenInclude(p => p.Categoria).
                Include(p => p.Comentarios).
                FirstOrDefaultAsync(x => x.Id == id);

            if (postagem == null)
            {
                return NotFound();
            }

            return postagem;
        }

        // PUT: api/Postagens/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPostagem(int id, Postagem postagem)
        {
            if (id != postagem.Id)
            {
                return BadRequest();
            }

            _context.Entry(postagem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PostagemExists(id))
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

        // POST: api/Postagens
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Postagem>> PostPostagem(Postagem postagem)
        {
            _context.Postagems.Add(postagem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPostagem", new { id = postagem.Id }, postagem);
        }

        // DELETE: api/Postagens/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Postagem>> DeletePostagem(int id)
        {
            var postagem = await _context.Postagems.FindAsync(id);
            if (postagem == null)
            {
                return NotFound();
            }

            _context.Postagems.Remove(postagem);
            await _context.SaveChangesAsync();

            return postagem;
        }

        private bool PostagemExists(int id)
        {
            return _context.Postagems.Any(e => e.Id == id);
        }
    }
}
