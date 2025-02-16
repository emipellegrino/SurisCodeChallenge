using SurisCodeChallenge.Models.Entidades;
using SurisCodeChallenge.Repositorios.Interfaces;
using SurisCodeChallenge.Servicios.Interfaces;

namespace SurisCodeChallenge.Servicios.Implementaciones
{
    public class ReservaService : IReservaService
    {
        private readonly IRepository<Reserva> _reservaRepository;

        public ReservaService(IRepository<Reserva> reservaRepository)
        {
            _reservaRepository = reservaRepository;
        }

        public async Task<IEnumerable<Reserva>> GetAllReservas()
        {
            return await _reservaRepository.GetAll();
        }

        public async Task<Reserva> GetReservaById(int id)
        {
            return await _reservaRepository.GetById(id);
        }

        public async Task<bool> CreateReserva(Reserva reserva)
        {
            if (reserva.FechaInicial >= reserva.FechaFinal)
            {
                throw new ArgumentException("La fecha de inicio no puede ser posterior o igual a la fecha de fin.");
            }
            var existingReservas = await _reservaRepository.GetAll();
            foreach (var existingReserva in existingReservas)
            {
                if ((reserva.FechaInicial < existingReserva.FechaFinal && reserva.FechaFinal > existingReserva.FechaInicial) ||
                (existingReserva.FechaInicial < reserva.FechaFinal && existingReserva.FechaFinal > reserva.FechaInicial))
                {
                    throw new ArgumentException("El horario seleccionado se superpone con una reserva existente.");
                }

                if (existingReserva.Cliente == reserva.Cliente && existingReserva.FechaInicial.Date == reserva.FechaInicial.Date)
                {
                    throw new ArgumentException("Este cliente ya tiene una reserva el mismo día.");
                }
            }
              
            await _reservaRepository.Add(reserva);
            return true;
        }
    }
}
