using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EducaFinancy.Models
{
    [Table("ALUNO")]
    public class Aluno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_Aluno { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(100)]
        public string Sobrenome { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Data_Nascimento { get; set; }  // ✅ Agora pode ser nulo

        [MaxLength(14)]
        public string CPF { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Telefone { get; set; }

        [MaxLength(150)]
        public string Endereco { get; set; }

        [MaxLength(100)]
        public string Nome_Mae { get; set; }

        [MaxLength(100)]
        public string Nome_Pai { get; set; }

        public DateTime Data_Cadastro { get; set; } = DateTime.Now;

        // Relacionamento com matrícula
        public virtual ICollection<Matricula>? Matriculas { get; set; }
    }
}
