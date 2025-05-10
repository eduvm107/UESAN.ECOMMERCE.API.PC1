using System;
using System.Collections.Generic;

namespace UESAN.ECOMMERCE.API.PC1.Models;

public partial class Cancha
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Tipo { get; set; }

    public string? Ubicacion { get; set; }

    public virtual ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}
