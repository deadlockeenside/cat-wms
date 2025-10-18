using CatWMS.Domain.Entities;
using CatWMS.Domain.Interfaces;

namespace CatWMS.Infrastructure.DemoRepositories;

// Demo repository that simulates an empty stock catalog.
public sealed class EmptyStockItemRepository : IStockItemRepository
{
    public async Task<IReadOnlyCollection<StockItem>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        // Network call simulation
        await Task.Delay(300, cancellationToken);

        return Array.Empty<StockItem>();
    }
}
