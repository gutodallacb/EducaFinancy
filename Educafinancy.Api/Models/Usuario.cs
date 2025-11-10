using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EducaFinancy.Models
{
    public class Usuario
    {
        [Key]
        public int ID_Usuario { get; set; }

        [MaxLength(50)]
        public string Username { get; set; }

        [MaxLength(255)]
        public string Senha { get; set; }

        public DateTime Criado_Em { get; set; } = DateTime.Now;

        // Relacionamento
        public ICollection<LogAcesso> LogsAcesso { get; set; }
    }
}
