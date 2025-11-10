using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducaFinancy.Models
{
    public class LogAcesso
    {
        [Key]
        public int ID_Log { get; set; }

        [ForeignKey("Usuario")]
        public int ID_Usuario { get; set; }

        [MaxLength(100)]
        public string Acao { get; set; }

        public DateTime Data { get; set; } = DateTime.Now;

        // Relacionamento
        public Usuario Usuario { get; set; }
    }
}
