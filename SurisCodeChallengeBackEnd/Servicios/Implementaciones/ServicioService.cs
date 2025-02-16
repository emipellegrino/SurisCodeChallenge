using SurisCodeChallenge.Models.Entidades;
using SurisCodeChallenge.Repositorios.Interfaces;
using SurisCodeChallenge.Servicios.Interfaces;

namespace SurisCodeChallenge.Servicios.Implementaciones
{
    public class ServicioService : IServicioService
    {
        private readonly IRepository<Servicio> _servicioRepository;

        public ServicioService(IRepository<Servicio> servicioRepository)
        {
            _servicioRepository = servicioRepository;
        }

        public async Task<IEnumerable<Servicio>> GetAllServicios()
        {
            return await _servicioRepository.GetAll();
        }
    }
}
