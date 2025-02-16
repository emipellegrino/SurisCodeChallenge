using SurisCodeChallenge.Models.Entidades;

namespace SurisCodeChallenge.Servicios.Interfaces
{
    public interface IReservaService
    {
        Task<IEnumerable<Reserva>> GetAllReservas();
        Task<Reserva> GetReservaById(int id);
        Task<bool> CreateReserva(Reserva reserva);
    }
}
