using Microsoft.EntityFrameworkCore;

namespace REF.Persistence;

public class ApplicationDbInitialiser
{
    private readonly ApplicationDbContext _context;
        
    public ApplicationDbInitialiser(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public static void Initialize(ApplicationDbContext context)
    {
        context.Database.EnsureCreated();
    }
    
    public async Task InitialiseAsync()
    {
        try
        {
            await _context.Database.MigrateAsync();
        }
        catch (Exception ex)
        {
            //_logger.LogError(ex, "An error occurred while initialising the database.");
            throw;
        }
    }
}