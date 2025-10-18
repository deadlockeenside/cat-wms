using CatWMS.Domain.Entities;

namespace CatWMS.Infrastructure.DemoRepositories;

// Demo repository that simulates an empty stock catalog.
public sealed class EmptyStockItemRepository
{
    public async Task<IReadOnlyCollection<StockItem>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        // Network call simulation
        await Task.Delay(300, cancellationToken);

        return Array.Empty<StockItem>();
    }
}
