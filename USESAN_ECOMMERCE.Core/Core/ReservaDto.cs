namespace USESAN_ECOMMERCE.Core.Core
{
    public class ReservaDto
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin { get; set; }
        public string ClienteNombre { get; set; }
        public int CanchId { get; set; }
    }
}