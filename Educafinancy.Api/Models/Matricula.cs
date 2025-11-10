using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducaFinancy.Models
{
    public class Matricula
    {
        [Key]
        public int ID_Matricula { get; set; }

        [ForeignKey("Aluno")]
        public int ID_Aluno { get; set; }

        [ForeignKey("Turma")]
        public int ID_Turma { get; set; }

        public DateTime Data_Matricula { get; set; }

        public DateTime Data_Vencimento { get; set; }

        [MaxLength(20)]
        public string Status { get; set; }

        // Relacionamentos
        public Aluno Aluno { get; set; }
        public Turma Turma { get; set; }
    }
}
