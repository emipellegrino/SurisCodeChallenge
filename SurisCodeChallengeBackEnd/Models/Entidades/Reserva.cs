using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SurisCodeChallenge.Models.Entidades
{
    public class Reserva : _Entity
    {
        [Required]
        [ForeignKey("Servicio")]
        public int ServicioId { get; set; }

        [Required]
        public DateTime FechaInicial { get; set; }

        [Required]
        public DateTime FechaFinal { get; set; }

        [Required]
        [MaxLength(100)]
        public string Cliente { get; set; }

        public virtual Servicio? Servicio { get; set; }
    }
}
