/*
 * Created by SharpDevelop.
 * User: Home
 * Date: 29/04/2022
 * Time: 20:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using GameBase.Models;

namespace GameBase.ViewModels.Elements.Characters
{
	/// <summary>
	/// Description of AtorFactory.
	/// </summary>
	public static class AtorFactory
	{
		public static Ator CreateDragon(int posX, int posY)
		{
			var dragon = new Ator
			{
				Resource = @"Resources/Sprites/dragon.png",
				Largura = 96,
				Altura = 96,
				DirecaoAtual = Direcao.Baixo,
				FrameAtual = 1,
				PosX = posX,
				PosY = posY
			};
			return dragon;
		}
	}
}
