using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTrendApp.Models
{

    [Table("Perfis")]
    public class PerfilUsuario
    {
        [Key]
        public int IdPerfilUsuario { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        public string Estilo { get; set; } // Ex: Casual, Formal
        public string Biotipo { get; set; } // Ex: Magro, Musculoso
        public string Preferencias { get; set; } // Preferências gerais do usuário

        // Navegação
       // public Usuario Usuario { get; set; }
    }
}
