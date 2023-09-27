using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.EntityFrameworkCore;
using REF.Application.Interfaces;
using REF.Domain.Entities;
using REF.Persistence.EntityTypeConfigurations;

namespace REF.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<RealEstate> RealEstates => Set<RealEstate>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
    
}