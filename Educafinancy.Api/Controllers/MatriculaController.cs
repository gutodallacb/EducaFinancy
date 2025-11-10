using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EducaFinancy.Data;
using EducaFinancy.Models;

namespace Educafinancy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatriculaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MatriculaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Matricula>>> GetMatriculas() =>
            await _context.Matriculas
                          .Include(m => m.Aluno)
                          .Include(m => m.Turma)
                          .ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Matricula>> GetMatricula(int id)
        {
            var matricula = await _context.Matriculas
                                          .Include(m => m.Aluno)
                                          .Include(m => m.Turma)
                                          .FirstOrDefaultAsync(m => m.ID_Matricula == id);
            if (matricula == null) return NotFound();
            return matricula;
        }

        [HttpPost]
        public async Task<ActionResult<Matricula>> PostMatricula(Matricula matricula)
        {
            _context.Matriculas.Add(matricula);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetMatricula), new { id = matricula.ID_Matricula }, matricula);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMatricula(int id, Matricula matricula)
        {
            if (id != matricula.ID_Matricula) return BadRequest();
            _context.Entry(matricula).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMatricula(int id)
        {
            var matricula = await _context.Matriculas.FindAsync(id);
            if (matricula == null) return NotFound();

            _context.Matriculas.Remove(matricula);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
