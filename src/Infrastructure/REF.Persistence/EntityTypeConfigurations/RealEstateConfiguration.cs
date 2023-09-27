using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using REF.Domain.Entities;

namespace REF.Persistence.EntityTypeConfigurations;

public class RealEstateConfiguration : IEntityTypeConfiguration<RealEstate>
{
    public void Configure(EntityTypeBuilder<RealEstate> builder)
    {
        builder.Property(t => t.Adress)
            .HasMaxLength(200);
    }
}