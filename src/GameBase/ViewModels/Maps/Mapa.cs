/*
 * Created by SharpDevelop.
 * User: Home
 * Date: 29/04/2022
 * Time: 11:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.ObjectModel;
using System.Windows;
using GameBase.ViewModels.Elements;
using GameBase.ViewModels.Elements.Characters;

namespace GameBase.ViewModels.Maps
{
	/// <summary>
	/// Description of Mapa.
	/// </summary>
	public class Mapa : BindableBase
	{
		public Mapa()
		{
			Elementos = new ObservableCollection<Elemento>();
		}
		
		string panorama;
		/// <summary>
		/// Imagem de fundo do mapa
		/// </summary>
		public string Panorama
		{
			get { return panorama; }
			set { SetProperty(ref panorama, value); }
		}
		
		public ObservableCollection<Elemento> Elementos { get; private set; }
		
		/// <summary>
		/// Verifica se o elemento colide com algum outro elemento da coleção
		/// </summary>
		public bool HasColisao(Elemento elemento, int posX, int posY)
		{
			// TODO Implementar lógica de colisão
			return false;
		}
	}
}
