using CatWMS.Domain.Entities;

namespace CatWMS.Domain.Interfaces;

public interface IStockItemRepository
{
    Task<IReadOnlyCollection<StockItem>> GetAllAsync(CancellationToken cancellationToken = default);
}
