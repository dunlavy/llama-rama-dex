using System;
using System.Globalization;
using System.Windows.Data;

namespace LlamaRamaDex.Converters {
	public class PrefixConverter: IValueConverter {
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture) =>
			parameter + " " + value;

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
			throw new NotImplementedException();
	}
}
