using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSIUWeb.Models
{
    public class Psaico
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome Requerido.")]
        [Display(Name = "Nome")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "CRP requerida.")]
        [Display(Name = "CRP")]
        public string? CRP { get; set; }
        [Required(ErrorMessage = "Liberado Requerido.")]
        [Display(Name = "Liberado")]
        public bool Liberado { get; set; }

        [ForeignKey("User")]
        public string? UserId { get; set; }
        public AppUser? User { get; set; }
    }
}