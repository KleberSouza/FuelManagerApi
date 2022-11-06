using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FuelManagerApi.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string Perfil { get; set; }
    }    
}
