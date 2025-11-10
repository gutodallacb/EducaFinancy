using EducaFinancy.Data;
using EducaFinancy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EducaFinancy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AlunoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostAluno([FromBody] Aluno aluno)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Alunos.Add(aluno);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAluno), new { id = aluno.ID_Aluno }, aluno);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAluno(int id)
        {
            var aluno = await _context.Alunos.FindAsync(id);
            if (aluno == null)
                return NotFound();

            return Ok(aluno);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var alunos = await _context.Alunos.ToListAsync();
            return Ok(alunos);
        }
    }
}
