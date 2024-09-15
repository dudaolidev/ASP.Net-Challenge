using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTrendApp.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        public double Preco { get; set; }

        public string Descricao { get; set; }

        [Required]
        public int CategoriaProdutoId { get; set; }

        [Required]
        public int CorId { get; set; }

        // Navegação
        //     public CategoriaProduto CategoriaProduto { get; set; }
       // public Cor Cor { get; set; }
    }
}
