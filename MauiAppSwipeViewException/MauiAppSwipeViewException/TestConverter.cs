using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls;
using System;
using System.Globalization;

namespace MauiAppSwipeViewException
{
    [AcceptEmptyServiceProvider]
    public class TestConverter : IMultiValueConverter, IMarkupExtension
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] == null || values[1] == null)
            {
                return null;
            }
            var id = (int)values[0];
            var title = (string)values[1];
            return $"{title} - {id}";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
