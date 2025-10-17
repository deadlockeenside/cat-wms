using CatWMS.Application.Common;

namespace CatWMS.Application.DTOs;

public sealed record StockItemDTO : DTO
{
    public required string Name { get; init; }
}
