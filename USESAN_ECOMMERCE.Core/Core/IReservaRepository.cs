// Archivo: USESAN_ECOMMERCE.Core/Core/IReservaRepository.cs
namespace USESAN_ECOMMERCE.Core.Core
{
    public interface IReservaRepository
    {
        Task<IEnumerable<Reserva>> GetAllAsync();
        Task<Reserva> GetByIdAsync(int id);
        Task AddAsync(Reserva reserva);
        Task UpdateAsync(Reserva reserva);
        Task DeleteAsync(int id);
    }
}