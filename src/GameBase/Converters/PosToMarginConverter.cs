/*
 * Created by SharpDevelop.
 * User: Home
 * Date: 30/04/2022
 * Time: 01:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace GameBase.Converters
{
	/// <summary>
	/// Description of PosToMarginConverter.
	/// </summary>
	public class PosToMarginConverter : IMultiValueConverter
    {
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{
			int posX = (int)values[0];
			int posY = (int)values[1];
			
			var margin = new Thickness(posX, posY, 0, 0);
			return margin;
		}
		
		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		{
			throw new NotSupportedException();
		}
    }
}
