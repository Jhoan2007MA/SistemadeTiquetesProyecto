using System;

namespace SistemadeTiquetess.src.modules.Flights.Infrastructure.Entity;

public class FlightEntity
{
    public Guid Id { get; set; }
    public string FlightNumber { get; set; } = string.Empty;
    public Guid StatusId { get; set; }
}
