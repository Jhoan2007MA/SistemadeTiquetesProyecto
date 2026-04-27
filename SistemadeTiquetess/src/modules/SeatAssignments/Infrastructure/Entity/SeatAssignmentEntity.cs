using System;

namespace SistemadeTiquetess.src.modules.SeatAssignments.Infrastructure.Entity;

public class SeatAssignmentEntity
{
    public Guid Id { get; set; }
    public Guid ReservationPassengerId { get; set; }
    public Guid SeatId { get; set; }
}
