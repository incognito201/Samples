/*
 * Created by SharpDevelop.
 * User: Home
 * Date: 30/04/2022
 * Time: 01:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace GameBase.ViewModels.Elements.Tilesets
{
	/// <summary>
	/// Description of TilesetFactory.
	/// </summary>
	public static class TilesetFactory
	{
		public static Elemento CreatePedra(int posX, int posY)
		{
			var dragon = new Tileset
			{
				Resource = @"Resources/Tilesets/pedra.png",
				Largura = 32,
				Altura = 32,
				PosX = posX,
				PosY = posY
			};
			return dragon;
		}
	}
}
