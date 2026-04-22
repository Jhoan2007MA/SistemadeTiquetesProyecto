using System;

namespace SistemadeTiquetess.src.shared.context;

public sealed class AppContextDesignTimeFactory
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

   public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
{
    return await base.SaveChangesAsync(cancellationToken);
}
}
