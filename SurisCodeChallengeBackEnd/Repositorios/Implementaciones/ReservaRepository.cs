using Microsoft.EntityFrameworkCore;
using SurisCodeChallenge.Models;
using SurisCodeChallenge.Models.Entidades;
using SurisCodeChallenge.Repositorios.Interfaces;

namespace SurisCodeChallenge.Repositorios.Implementaciones
{
    public class ReservaRepository : IRepository<Reserva>
    {
        private readonly ReservasContext _context;

        public ReservaRepository(ReservasContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Reserva>> GetAll()
        {
            return await _context.Reservas
                .Include(r => r.Servicio)
                .ToListAsync();
        }

        public async Task<Reserva> GetById(int id)
        {
            return await _context.Reservas
                .Include(r => r.Servicio)
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task Add(Reserva entity)
        {
            await _context.Reservas.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public void Update(Reserva entity)
        {
            _context.Reservas.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(Reserva entity)
        {
            _context.Reservas.Remove(entity);
            _context.SaveChanges();
        }
    }
}
