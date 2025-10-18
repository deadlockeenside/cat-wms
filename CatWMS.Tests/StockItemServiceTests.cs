using CatWMS.Application.Services;
using CatWMS.Infrastructure.DemoRepositories;

namespace CatWMS.Tests.Application;

public class StockItemServiceTests
{
    [Fact]
    public async Task GetAllAsync_ShouldReturnDtos_WithSameCountAsEntities()
    {
        // Arrange
        var repo = new DemoStockItemRepository();
        var service = new StockItemService(repo);

        // Act
        var dtos = await service.GetAllAsync();

        // Assert
        Assert.NotNull(dtos);
        Assert.Equal(4, dtos.Count);
        Assert.All(dtos, dto => Assert.False(string.IsNullOrWhiteSpace(dto.Name)));
    }
}
