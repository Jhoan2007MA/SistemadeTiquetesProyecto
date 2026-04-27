using System;

namespace SistemadeTiquetess.src.modules.SeatAvailability.Infrastructure.Entity;

public class SeatAvailabilityEntity
{
    public Guid Id { get; set; }
    public Guid SeatId { get; set; }
    public Guid FlightId { get; set; }
    public bool IsAvailable { get; set; }
}
