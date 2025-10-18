using CatWMS.Domain.Common;
using CatWMS.Domain.ValueObjects;

namespace CatWMS.Domain.Entities;

public sealed class StockItem : Entity
{
    private Title _name = null!;

    public required Title Name 
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(Name));
    }
}
