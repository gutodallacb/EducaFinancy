using Microsoft.EntityFrameworkCore;
using EducaFinancy.Models;

namespace EducaFinancy.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<LogAcesso> LogsAcesso { get; set; }
    }
}
