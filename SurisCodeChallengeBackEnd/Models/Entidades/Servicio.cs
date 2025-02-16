using System.ComponentModel.DataAnnotations;

namespace SurisCodeChallenge.Models.Entidades
{
    public class Servicio : _Entity
    {
        [Required]
        [MaxLength(100)]
        public required string Nombre { get; set; }

        [MaxLength(500)]
        public string? Descripcion { get; set; }
    }
}