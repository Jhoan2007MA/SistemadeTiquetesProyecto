using System;

namespace SistemadeTiquetess.src.modules.ReservationPassengers.Infrastructure.Entity;

public class ReservationPassengerEntity
{
    public Guid Id { get; set; }
    public Guid ReservationId { get; set; }
    public Guid CustomerId { get; set; }
    public string SeatNumber { get; set; } = string.Empty;
}
