using System;

namespace SistemadeTiquetess.src.modules.Payments.Infrastructure.Entity;

public class PaymentEntity
{
    public Guid Id { get; set; }
    public Guid ReservationId { get; set; }
    public Guid PaymentMethodId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
}
