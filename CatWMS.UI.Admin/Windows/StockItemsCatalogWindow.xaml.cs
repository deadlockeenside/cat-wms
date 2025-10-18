using CatWMS.UI.Admin.Common;
using CatWMS.UI.Admin.ViewModels;
using System.Windows;

namespace CatWMS.UI.Admin.Windows
{
    /// <summary>
    /// Логика взаимодействия для StockItemsCatalogWindow.xaml
    /// </summary>
    public partial class StockItemsCatalogWindow : Window
    {
        private readonly StockItemsCatalogViewModel _vm;

        public StockItemsCatalogWindow()
        {
            InitializeComponent();
            Title = Labels.StockItemsCatalogWindowTitle;

            _vm = new StockItemsCatalogViewModel();
            DataContext = _vm;

            Loaded += async (_, _) => await _vm.LoadAsync();
        }
    }
}
