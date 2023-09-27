using Microsoft.EntityFrameworkCore;
using REF.Domain.Entities;

namespace REF.Application.Interfaces;

public interface IApplicationDbContext
{
    DbSet<RealEstate> RealEstates { get;}
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}