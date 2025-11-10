using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducaFinancy.Models
{
    public class Turma
    {
        [Key]
        public int ID_Turma { get; set; }

        [ForeignKey("Curso")]
        public int ID_Curso { get; set; }

        [MaxLength(100)]
        public string Nome_Turma { get; set; }

        public int Ano_Letivo { get; set; }

        [MaxLength(20)]
        public string Periodo { get; set; }

        public DateTime Data_Inicio { get; set; }

        public DateTime Data_Fim { get; set; }

        // Relacionamento
        public Curso Curso { get; set; }

        public ICollection<Matricula> Matriculas { get; set; }
    }
}
