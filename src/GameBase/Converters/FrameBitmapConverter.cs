/*
 * Created by SharpDevelop.
 * User: Home
 * Date: 29/04/2022
 * Time: 17:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using GameBase.Models;
using GameBase.ViewModels;

namespace GameBase.Converters
{
	/// <summary>
	/// Description of FrameBitmapConverter.
	/// </summary>
	public class FrameBitmapConverter : IMultiValueConverter
    {
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{
			string resourcePath = (string)values[0];
			int frameAtual = (int)values[1];
			Direcao direcao = (Direcao)values[2];
			int largura = (int)values[3];
			int altura = (int)values[4];
			
			
			int x = 0, y = 0;
			switch(direcao)
			{
				case Direcao.Baixo:
					y = 0;
					break;
				case Direcao.Esquerda:
					y = 1 * altura;
					break;
				case Direcao.Direita:
					y = 2 * altura;
					break;
				case Direcao.Cima:
					y = 3 * altura;
					break;
			}
			if(frameAtual == 0)
			{
				x = 0;
			}
			else
			{
				x = frameAtual * largura;
			}

			
  			var uri = new Uri(resourcePath, UriKind.Relative);
    		var fullImage = new BitmapImage(uri);
    		
    		var imageFrame = new CroppedBitmap(fullImage, new Int32Rect(x, y, largura, altura));
			return imageFrame;
		}
		
		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		{
			throw new NotSupportedException();
		}
    }
}
