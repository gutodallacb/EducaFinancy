using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EducaFinancy.Models
{
    public class Curso
    {
        [Key]
        public int ID_Curso { get; set; }

        [MaxLength(100)]
        public string Nome_Curso { get; set; }

        public string Descricao { get; set; }

        public int Carga_Horaria { get; set; }

        public bool Ativo { get; set; }

        // Relacionamento
        public ICollection<Turma> Turmas { get; set; }
    }
}
