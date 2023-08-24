using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PSIUWeb.Models
{
    public enum Gender { Feminino, Masculino, Outros }

    public class AppUser : IdentityUser
    {
        [Required(ErrorMessage = "Nome requerido.")]
        [Display(Name = "Nome completo.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Data de nascimento requerida.")]
        [Display(Name = "Data completa.")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Gênero requerido.")]
        [Display(Name = "Gênero completo.")]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Data de criação requerida.")]
        public DateTime CreationDate { get; set; }
    }
}
