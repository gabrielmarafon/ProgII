using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSIUWeb.Models
{
    public enum Race { Asiático, Branco, Índio, Negro, Pardo, Outros }
    public class Patient
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome Requerido.")]
        [Display(Name = "Nome")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Data de nascimento requerida.")]
        [Display(Name = "Data de Nascimento")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Peso Requerido.")]
        [Display(Name = "Peso")]
        public decimal Weight { get; set; }

        [Required(ErrorMessage = "Altura Requerida.")]
        [Display(Name = "Atura")]
        public decimal Height { get; set; }

        [Required(ErrorMessage = "Raça Requerida.")]
        [Display(Name = "Raça")]
        public Race Race { get; set; }

        [ForeignKey("User")]
        public string? UserId { get; set; }
        public AppUser? User { get; set; }
    }
}
