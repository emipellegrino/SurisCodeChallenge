using SurisCodeChallenge.Models.Entidades;

namespace SurisCodeChallenge.Servicios.Interfaces
{
    public interface IServicioService
    {
        Task<IEnumerable<Servicio>> GetAllServicios();
    }
}
