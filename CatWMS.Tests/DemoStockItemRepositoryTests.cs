using CatWMS.Infrastructure.DemoRepositories;

namespace CatWMS.Tests.Infrastructure;

public class DemoStockItemRepositoryTests
{
    [Fact]
    public async Task GetAllAsync_ShouldReturnFourItems()
    {
        // Arrange
        var repo = new DemoStockItemRepository();

        // Act
        var items = await repo.GetAllAsync();

        // Assert
        Assert.NotNull(items);
        Assert.Equal(4, items.Count);
        Assert.All(items, item => Assert.False(string.IsNullOrWhiteSpace(item.Name.ToString())));
    }

    [Fact]
    public async Task GetAllAsync_ShouldThrow_WhenCancelled()
    {
        var repo = new DemoStockItemRepository();
        using var cts = new CancellationTokenSource();
        cts.Cancel();

        await Assert.ThrowsAsync<TaskCanceledException>(
            async () => await repo.GetAllAsync(cts.Token)
        );
    }
}
