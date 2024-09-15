using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTrendApp.Models
{

    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        public int IdPedido { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [Required]
        public DateTime DataPedido { get; set; }

        [Required]
        public double Total { get; set; }

        public ICollection<Produto> Produtos { get; set; } // Produtos no pedido

        // Navegação
      //  public Usuario Usuario { get; set; }
    }
}

