using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTrendApp.Models
{

    [Table("Avaliacoes")]
    public class Avaliacao
    {
        [Key]
        public int IdAvaliacao { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [Required]
        public int ProdutoId { get; set; }

        [Required]
        public int Nota { get; set; } // Valor da avaliação, por exemplo, de 1 a 5

        public string Comentario { get; set; } // Comentário opcional sobre o produto

        // Navegação
      //  public Usuario Usuario { get; set; }
       // public Produto Produto { get; set; }
    }
}
