using Microsoft.EntityFrameworkCore;
using SurisCodeChallenge.Models;
using SurisCodeChallenge.Models.Entidades;
using SurisCodeChallenge.Repositorios.Interfaces;

namespace SurisCodeChallenge.Repositorios.Implementaciones
{
    public class ServicioRepository : IRepository<Servicio>
    {
        private readonly ReservasContext _context;

        public ServicioRepository(ReservasContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Servicio>> GetAll()
        {
            return await _context.Servicios.ToListAsync();
        }

        public async Task<Servicio> GetById(int id)
        {
            return await _context.Servicios.FindAsync(id);
        }

        public async Task Add(Servicio entity)
        {
            await _context.Servicios.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Update(Servicio entity)
        {
            _context.Servicios.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(Servicio entity)
        {
            _context.Servicios.Remove(entity);
            _context.SaveChanges();
        }
    }
}
