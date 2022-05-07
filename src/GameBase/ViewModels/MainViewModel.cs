/*
 * Created by SharpDevelop.
 * User: Home
 * Date: 29/04/2022
 * Time: 21:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using GameBase.Models;
using GameBase.Mvvm;
using GameBase.ViewModels.Elements.Characters;
using GameBase.ViewModels.Elements.Tilesets;
using GameBase.ViewModels.Maps;

namespace GameBase.ViewModels
{
	/// <summary>
	/// Description of MainViewModel.
	/// </summary>
	public class MainViewModel : BindableBase
	{
		public MainViewModel()
		{
			MovePlayer1LeftCommand = new Command(MovePlayer1Left);
			MovePlayer1RightCommand = new Command(MovePlayer1Right);
			MovePlayer1UpCommand = new Command(MovePlayer1Up);
			MovePlayer1DownCommand = new Command(MovePlayer1Down);
			
			Player1 = AtorFactory.CreateDragon(0, 0);
			
			Mundo = new Mapa()
			{
				Panorama = @"Resources\panorama_lava1.webp"
			};
			
			Spawn(Player1);
			
			var inimigo = AtorFactory.CreateDragon(100, 50);
			Spawn(inimigo);
		}
		
		public Command MovePlayer1LeftCommand { get; set; }
		
		public Command MovePlayer1RightCommand { get; set; }
		
		public Command MovePlayer1UpCommand { get; set; }

		public Command MovePlayer1DownCommand { get; set; }
		
		
		Mapa mundo;
		/// <summary>
		/// Representa o mundo que está sendo renderizado
		/// </summary>
		public Mapa Mundo
		{
			get { return mundo; }
			set { SetProperty(ref mundo, value); }
		}
		
		Ator player1;
		/// <summary>
		/// Representa o jogador um
		/// </summary>
		public Ator Player1
		{
			get { return player1; }
			set { SetProperty(ref player1, value); }
		}
		
		
		void MovePlayer1Left()
		{
			Player1.Move(Direcao.Esquerda);
		}
		
		void MovePlayer1Right()
		{
			Player1.Move(Direcao.Direita);
		}
		
		void MovePlayer1Up()
		{
			Player1.Move(Direcao.Cima);
		}
		
		void MovePlayer1Down()
		{
			Player1.Move(Direcao.Baixo);
		}
		
		/// <summary>
		/// Spawna o ator no Mundo
		/// </summary>
		public void Spawn(Ator ator)
		{
			ator.Mapa = Mundo;
			Mundo.Elementos.Add(ator);
		}
	}
}
