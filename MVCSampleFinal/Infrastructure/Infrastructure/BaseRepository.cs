using Infrastructure;

public class BaseRepository
{
    public readonly AppDbContext context;

    public BaseRepository(AppDbContext context)
    {
        this.context = context;
    }

    // GUARDA CAMBIOS
    public async Task Save()
    {
        await context.SaveChangesAsync();
    }

    // INICIO DE TRANSACCIÓN
    public async Task Beguin()
    {
        // Si ya hay una transacción activa, no inicies otra
        if (context.Database.CurrentTransaction == null)
        {
            await context.Database.BeginTransactionAsync();
        }
    }

    // CONFIRMAR TRANSACCIÓN
    public async Task Comit()
    {
        if (context.Database.CurrentTransaction != null)
        {
            await context.Database.CommitTransactionAsync();
        }
    }

    // DESHACER TRANSACCIÓN
    public async Task RollBack()
    {
        if (context.Database.CurrentTransaction != null)
        {
            await context.Database.RollbackTransactionAsync();
        }
    }
}
