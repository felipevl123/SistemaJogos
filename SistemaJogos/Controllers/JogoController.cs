using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaJogos.Controllers
{
    // Controller de API que é possivel fazer a inserção, e o retorno de jogos
    [Route("api/[controller]")]
    [ApiController]
    public class JogoController : ControllerBase
    {
        private JogosContext _context;

        public JogoController(JogosContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionaJogo([FromBody] Jogos jogo)
        {
            _context.Jogos.Add(jogo);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaJogosPorId), new { Id = jogo.Id }, jogo);
        }

        [HttpGet]
        public IEnumerable<Jogos> RecuperaJogos()
        {
            return _context.Jogos;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaJogosPorId(int id)
        {
            Jogos jogo = _context.Jogos.FirstOrDefault(jogo => jogo.Id == id);
            if(jogo != null)
            {
                return Ok(jogo);
            }

            return NotFound();
        }


        
    }
}

