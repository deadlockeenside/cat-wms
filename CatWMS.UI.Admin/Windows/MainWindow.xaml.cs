using CatWMS.UI.Admin.Common;
using System.Windows;

namespace CatWMS.UI.Admin.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = Labels.MainWindowTitle;
        }

        private void OnStockItemsClick(object sender, RoutedEventArgs e)
        {
            var window = new StockItemsCatalogWindow
            {
                Owner = this
            };
            window.ShowDialog();
        }
    }
}
