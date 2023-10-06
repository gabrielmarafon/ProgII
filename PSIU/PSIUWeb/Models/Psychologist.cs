using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSIUWeb.Models
{
    public class Psychologist
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome Requerido.")]
        [Display(Name = "Nome")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "CRP requerido.")]
        [Display(Name = "CRP")]
        public string? CRP { get; set; }
        [Required(ErrorMessage = "Especialidade requerida.")]
        [Display(Name = "Especialidade")]
        public string? Specialty { get; set; }

        [ForeignKey("User")]
        public string? UserId { get; set; }
        public AppUser? User { get; set; }
    }
}
