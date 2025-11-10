using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EducaFinancy.Data;
using EducaFinancy.Models;

namespace Educafinancy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TurmaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Turma>>> GetTurmas() =>
            await _context.Turmas.Include(t => t.Curso).ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Turma>> GetTurma(int id)
        {
            var turma = await _context.Turmas.Include(t => t.Curso)
                                             .FirstOrDefaultAsync(t => t.ID_Turma == id);
            if (turma == null) return NotFound();
            return turma;
        }

        [HttpPost]
        public async Task<ActionResult<Turma>> PostTurma(Turma turma)
        {
            _context.Turmas.Add(turma);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTurma), new { id = turma.ID_Turma }, turma);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTurma(int id, Turma turma)
        {
            if (id != turma.ID_Turma) return BadRequest();
            _context.Entry(turma).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTurma(int id)
        {
            var turma = await _context.Turmas.FindAsync(id);
            if (turma == null) return NotFound();

            _context.Turmas.Remove(turma);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
