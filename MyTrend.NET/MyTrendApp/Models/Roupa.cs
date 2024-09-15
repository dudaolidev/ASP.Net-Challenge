using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTrendApp.Models
{
    [Table("Roupas")]
    public class Roupa
    {
        [Key]
        public int IdRoupa{ get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        [Required]
        public int CorId { get; set; }

        // Navegação
       // public Cor Cor { get; set; }
    }
}
