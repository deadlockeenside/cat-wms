using CatWMS.Application.DTOs;
using CatWMS.Domain.Interfaces;

namespace CatWMS.Application.Services;

public sealed class StockItemService
{
    private readonly IStockItemRepository _repository;

    public StockItemService(IStockItemRepository repository) => _repository = repository;

    public async Task<IReadOnlyCollection<StockItemDTO>> GetAllAsync(CancellationToken cancellationToken = default) 
    {
        var items = await _repository.GetAllAsync(cancellationToken);

        return items
            .Select(item => new StockItemDTO
            {
                Id = item.Id,
                Name = item.Name.ToString()
            })
            .ToList()
            .AsReadOnly();
    }
}
