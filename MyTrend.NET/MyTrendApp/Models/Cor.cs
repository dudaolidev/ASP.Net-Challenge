using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTrendApp.Models
{

    [Table("Cores")]
    public class Cor
    {
        [Key]
        public int IdCor { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; } // Nome da cor, ex: Vermelho, Azul

        public string CodigoHex { get; set; } // Código hexadecimal da cor
    }
}
