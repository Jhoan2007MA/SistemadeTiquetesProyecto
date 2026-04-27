using MyInventory2026.src.shared.context;
using MyInventory2026.src.shared.helpers;
using SistemadeTiquetess.src.shared.ui.Menus;

try
{
    using var context = DbContextFactory.Create();
    if (context.Database.CanConnect())
    {
        Console.WriteLine("Conexión exitosa a la base de datos.");
        new ConsoleMenuOrchestrator().Start();
    }
    else
    {
        Console.WriteLine("No se pudo conectar con la base de datos.");
    }
}
catch (Exception ex)
{
    Console.Error.WriteLine($"Error al conectar con la base de datos: {ex.Message}");
    if (ex.InnerException is not null)
    {
        Console.Error.WriteLine($"Detalle: {ex.InnerException.Message}");
    }
}
