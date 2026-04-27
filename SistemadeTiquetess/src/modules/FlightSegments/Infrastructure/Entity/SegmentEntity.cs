using System;

namespace SistemadeTiquetess.src.modules.FlightSegments.Infrastructure.Entity;

public class SegmentEntity
{
    public Guid Id { get; set; }
    public Guid FlightId { get; set; }
    public Guid OriginAirportId { get; set; }
    public Guid DestinationAirportId { get; set; }
}
