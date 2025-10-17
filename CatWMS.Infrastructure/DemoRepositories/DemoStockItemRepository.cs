using CatWMS.Domain.Entities;
using CatWMS.Domain.Interfaces;
using CatWMS.Domain.ValueObjects;

namespace CatWMS.Infrastructure.DemoRepositories;

// Contains demo data
public sealed class DemoStockItemRepository : IStockItemRepository
{
    private readonly List<StockItem> _items = new()
    {
        new StockItem 
        { 
            Id = 1, 
            Name = Title.Create("Balloon (27'' / 69 cm), Cat with Bow Figure, Satin, 1 pc") 
        },
        new StockItem 
        { 
            Id = 2, 
            Name = Title.Create("Balloon (18'' / 46 cm), Round, Cat with Bow, Cream, Satin, 1 pc") 
        },
        new StockItem 
        { 
            Id = 3, 
            Name = Title.Create("Balloon (18'' / 46 cm), Round, Cat with Bow, Pink, Satin, 1 pc") 
        },
        new StockItem 
        {
            Id = 4, 
            Name = Title.Create("Balloons (12'' / 30 cm), Cat with Bow Print, Assorted Pastel, 25 pcs") 
        }
    };

    public async Task<IReadOnlyCollection<StockItem>> GetAllAsync(CancellationToken cancellationToken = default) 
    {
        // Network call simulation
        await Task.Delay(300, cancellationToken);

        // Cancellation check (if the user interrupted the operation)
        cancellationToken.ThrowIfCancellationRequested();

        return _items.AsReadOnly();
    }
}
