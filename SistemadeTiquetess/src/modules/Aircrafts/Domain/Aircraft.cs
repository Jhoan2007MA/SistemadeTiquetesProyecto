namespace SistemadeTiquetess.src.modules.Aircrafts.Domain;

public class Aircraft
{
    public Guid Id { get; set; }
    public string RegistrationNumber { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public int Capacity { get; set; }
}
