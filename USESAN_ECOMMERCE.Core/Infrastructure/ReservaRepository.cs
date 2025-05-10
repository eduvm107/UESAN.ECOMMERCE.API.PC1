// Archivo: USESAN_ECOMMERCE.Core/Infrastructure/ReservaRepository.cs
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using USESAN_ECOMMERCE.Core.Core;
using USESAN_ECOMMERCE.Core.Models;

namespace USESAN_ECOMMERCE.Core.Infrastructure
{m
    public class ReservaRepository(ReservasDeportivasDbContext context) : IReservaRepository, IReservaRepository
    {
        private readonly ReservasDeportivasDbContext _context = context;

        public async Task<IEnumerable<Reserva>> GetAllAsync()
        {
            return await _context.Reservas.ToListAsync();
        }

        public async Task<Reserva> GetByIdAsync(int id)
        {
            return await _context.Reservas.FindAsync(id);
        }

        public async Task AddAsync(Reserva reserva)
        {
            _context.Reservas.Add(reserva);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Reserva reserva)
        {
            _context.Entry(reserva).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }


        public async Task DeleteAsync(int id)
        {
            var reserva = await _context.Reservas.FindAsync(id);
            if (reserva != null)
            {
                _context.Reservas.Remove(reserva);
                await _context.SaveChangesAsync();
            }
        }
    }
}