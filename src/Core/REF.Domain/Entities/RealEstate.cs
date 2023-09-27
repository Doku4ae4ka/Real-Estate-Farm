
using REF.Domain.Common;

namespace REF.Domain.Entities;

public class RealEstate : BaseEntity
{
    public float? Price { get; set; }
    public string? Adress { get; set; }
    
    public string? KitchenLevel { get; set; }
    public string? BathLevel { get; set; }
    public string? LivingLevel { get; set; }
    
    
}