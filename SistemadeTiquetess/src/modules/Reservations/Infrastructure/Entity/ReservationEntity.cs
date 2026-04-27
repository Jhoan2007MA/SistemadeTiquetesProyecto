using System;

namespace SistemadeTiquetess.src.modules.Reservations.Infrastructure.Entity;

public class ReservationEntity
{
    public Guid Id { get; set; }
    public Guid CustomerId { get; set; }
    public Guid FlightId { get; set; }
    public DateTime ReservationDate { get; set; }
    public string Status { get; set; } = string.Empty;
}
