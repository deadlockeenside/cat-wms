using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace CatWMS.UI.Admin.Converters
{
    public class BoolToVisibilityConverter : IMultiValueConverter, IValueConverter
    {
        // Для обычного Binding (IsLoading, HasItems)
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool b)
                return b ? Visibility.Visible : Visibility.Collapsed;
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            => throw new NotImplementedException();

        // Для MultiBinding (HasItems + IsLoading)
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            bool hasItems = values.Length > 0 && values[0] is bool h && h;
            bool isLoading = values.Length > 1 && values[1] is bool l && l;

            bool shouldBeVisible = !hasItems && !isLoading;

            return shouldBeVisible ? Visibility.Visible : Visibility.Collapsed;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
            => throw new NotImplementedException();
    }
}
