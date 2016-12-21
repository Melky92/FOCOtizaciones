using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace FOCOtizaciones.ViewModel.Converters
{
    public class BackgroundConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            //if(true)
            {
                if (value.ToString() == "true")
                //if(true)
                {
                    return new SolidColorBrush(new Color()
                    {
                        A = 255,
                        R = 27,
                        G = 161,
                        B = 226
                    });
                }
                else
                {
                    return new SolidColorBrush(new Color()
                    {
                        A = 255,
                        R = 216,
                        G = 0,
                        B = 115
                    });
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
