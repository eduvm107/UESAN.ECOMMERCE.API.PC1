using System;
using System.Collections.Generic;

namespace UESAN.ECOMMERCE.API.PC1.Models;

public partial class Reserva
{
    public int Id { get; set; }

    public DateOnly Fecha { get; set; }

    public TimeOnly HoraInicio { get; set; }

    public TimeOnly HoraFin { get; set; }

    public string ClienteNombre { get; set; } = null!;

    public int CanchId { get; set; }

    public virtual Cancha Canch { get; set; } = null!;
}
