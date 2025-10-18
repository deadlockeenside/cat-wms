using CatWMS.Application.DTOs;
using CatWMS.Application.Services;
using CatWMS.Infrastructure.DemoRepositories;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CatWMS.UI.Admin.ViewModels;

public sealed class StockItemsCatalogViewModel : INotifyPropertyChanged
{
    private readonly StockItemService _service = new(new EmptyStockItemRepository());

    private bool _isLoading;

    public bool IsLoading
    {
        get => _isLoading;
        private set
        {
            if (_isLoading != value)
            {
                _isLoading = value;
                OnPropertyChanged();
            }
        }
    }

    public ObservableCollection<StockItemDTO> Items { get; } = new();

    public async Task LoadAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            IsLoading = true;
            Items.Clear();

            var dtos = await _service.GetAllAsync(cancellationToken);

            foreach (var dto in dtos)
                Items.Add(dto);
        }
        finally
        {
            IsLoading = false;
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string? name = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
