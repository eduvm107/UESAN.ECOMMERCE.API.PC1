// Archivo: USESAN_ECOMMERCE.Core/Infrastructure/ReservaRepository.cs
using USESAN_ECOMMERCE.Core.Core;

namespace USESAN_ECOMMERCE.Core.Infrastructure
{
    public interface IReservaRepository
    {
        Task AddAsync(Reserva reserva);
        Task DeleteAsync(int id);
        Task<IEnumerable<Reserva>> GetAllAsync();
        Task<Reserva> GetByIdAsync(int id);
        Task UpdateAsync(Reserva reserva);
    }
}