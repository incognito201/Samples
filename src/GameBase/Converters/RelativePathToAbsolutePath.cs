/*
 * Created by SharpDevelop.
 * User: Home
 * Date: 30/04/2022
 * Time: 03:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;
using System.Windows.Data;

namespace GameBase.Converters
{
	/// <summary>
	/// Description of RelativePathToAbsolutePath.
	/// </summary>
	public class RelativePathToAbsolutePath : IValueConverter
	{

		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			string path = (string)value;
			string absolutePath = Path.GetFullPath(path);
			return absolutePath;
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
