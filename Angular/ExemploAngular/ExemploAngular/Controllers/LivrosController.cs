using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploAngular.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExemploAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        // GET: api/Livros
        [HttpGet]
        public IEnumerable<Livro> Get()
        {
            return new List<Livro>() { 
                new Livro()
                {
                    Titulo = "Harry Potter",
                    Autor = "J K Rowling",
                    Edicao = "Luxo",
                    Preco = 30
                },
                new Livro()
                {
                    Titulo = "Cronicas de Gelo e Fogo",
                    Autor = "R R Martin",
                    Edicao = "Colecionador",
                    Preco = 20
                }
            };
            
        }

        // GET: api/Livros/5
        [HttpGet("{id}", Name = "Get")]
        public Livro Get(int id)
        {
            return new Livro()
            {
                Titulo = "Harry Potter",
                Autor = "J K Rowling",
                Edicao = "Luxo",
                Preco = 30
            };
        }

        // POST: api/Livros
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Livros/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
