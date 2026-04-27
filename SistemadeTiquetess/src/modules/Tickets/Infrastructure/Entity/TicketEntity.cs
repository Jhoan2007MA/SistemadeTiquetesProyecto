using System;

namespace SistemadeTiquetess.src.modules.Tickets.Infrastructure.Entity;

public class TicketEntity
{
    public Guid Id { get; set; }
    public Guid ReservationPassengerId { get; set; }
    public Guid StatusId { get; set; }
    public string TicketNumber { get; set; } = string.Empty;
    public DateTime IssueDate { get; set; }
}
