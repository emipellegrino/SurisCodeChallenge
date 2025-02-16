using System.ComponentModel.DataAnnotations;

namespace SurisCodeChallenge.Models.Entidades
{
    public abstract class _Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
