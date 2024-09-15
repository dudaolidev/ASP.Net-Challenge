using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTrendApp.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string Senha { get; set; } // Senha do usuário

        
       // public int IdAvaliacao { get; set; }

       // public int IdPedido { get; set; }

       // public int IdPerfilUsuario { get; set; }

        //public ICollection<Avaliacao> Avaliacoes { get; set; }
        // public ICollection<Pedido> Pedidos { get; set; }
        //public PerfilUsuario Perfil { get; set; }
    }
}
