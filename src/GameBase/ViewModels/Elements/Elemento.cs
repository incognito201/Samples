/*
 * Created by SharpDevelop.
 * User: Home
 * Date: 29/04/2022
 * Time: 08:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using GameBase.ViewModels.Maps;

namespace GameBase.ViewModels.Elements
{
	/// <summary>
	/// Description of Elemento.
	/// </summary>
	public abstract class Elemento : BindableBase
	{
		Mapa mapa;
		/// <summary>
		/// Mapa atual no qual esse elemento faz parte
		/// </summary>
		public Mapa Mapa
		{
			get { return mapa; }
			set { SetProperty(ref mapa, value); }
		}
		
		string resource;
		/// <summary>
		/// Caminho do arquivo de resource
		/// </summary>
		public string Resource
		{
			get { return resource; }
			set { SetProperty(ref resource, value); }
		}
		
		int largura;
		/// <summary>
		/// Largura em pixels do elemento
		/// </summary>
		public int Largura
		{
			get { return largura; }
			set { SetProperty(ref largura, value); }
		}
		
		int altura;
		/// <summary>
		/// Altura em pixels do elemento
		/// </summary>
		public int Altura
		{
			get { return altura; }
			set { SetProperty(ref altura, value); }
		}
		
		int posX;
		/// <summary>
		/// Posição X do elemento dentro do mundo
		/// </summary>
		public int PosX
		{
			get { return posX; }
			set { SetProperty(ref posX, value); }
		}
		
		int posY;
		/// <summary>
		/// Posição Y do elemento dentro do mundo
		/// </summary>
		public int PosY
		{
			get { return posY; }
			set { SetProperty(ref posY, value); }
		}
	}
}
