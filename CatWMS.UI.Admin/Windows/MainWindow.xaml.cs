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
    }
}
