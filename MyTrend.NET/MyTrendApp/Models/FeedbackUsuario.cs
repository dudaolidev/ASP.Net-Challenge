using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTrendApp.Models
{
    [Table("Feedbacks")]
    public class FeedbackUsuario
    {
        [Key]
        public int IdFeedbackUsuario { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [Required]
        public string Feedback { get; set; } // Comentário ou feedback do usuário

        public DateTime DataFeedback { get; set; } // Data do feedback

        // Navegação
       // public Usuario Usuario { get; set; }
    }
}
