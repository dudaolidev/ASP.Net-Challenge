using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTrendApp.Models
{

    [Table("Categorias")]
    public class CategoriaProduto
    {
        [Key]
        public int IdCategoriaProduto { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        // Lista de produtos que pertencem a essa categoria
        public ICollection<Produto> Produtos { get; set; }
    }
}
