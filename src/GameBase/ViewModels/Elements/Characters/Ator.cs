/*
 * Created by SharpDevelop.
 * User: Home
 * Date: 29/04/2022
 * Time: 08:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using GameBase.Models;

namespace GameBase.ViewModels.Elements.Characters
{
	/// <summary>
	/// Description of Ator.
	/// </summary>
	public class Ator : Elemento
	{
		public Ator()
		{
			TotalFrames = 3;
		}
		
		Direcao direcaoAtual;
		/// <summary>
		/// Direção onde o ator está olhando
		/// </summary>
		public Direcao DirecaoAtual
		{
			get { return direcaoAtual; }
			set { SetProperty(ref direcaoAtual, value); }
		}
		
		int frameAtual;
		/// <summary>
		/// Frame atual do sprite
		/// </summary>
		public int FrameAtual
		{
			get { return frameAtual; }
			set { SetProperty(ref frameAtual, value); }
		}
		
		int totalFrames;
		/// <summary>
		/// Quantidade total de frames no sprite desse ator
		/// </summary>
		public int TotalFrames
		{
			get { return totalFrames; }
			set { SetProperty(ref totalFrames, value); }
		}
		
		
		public virtual void Move(Direcao direcao)
		{
			if(DirecaoAtual != direcao)
			{
				FrameAtual = 0;
				DirecaoAtual = direcao;
			}
			
			if(FrameAtual + 1 >= TotalFrames)
			{
				FrameAtual = 0;
			}
			else
			{
				FrameAtual++;
			}
			
			
			switch(DirecaoAtual)
			{
				case Direcao.Baixo:
					if(!Mapa.HasColisao(this, PosX, PosY + 16))
					{
						PosY = PosY + 16;
					}
				break;
				case Direcao.Cima:
					if(!Mapa.HasColisao(this, PosX, PosY - 16))
					{
						PosY = PosY - 16;
					}
				break;
				case Direcao.Direita:
					if(!Mapa.HasColisao(this, PosX + 16, PosY))
					{
						PosX = PosX + 16;
					}
				break;
				case Direcao.Esquerda:
					if(!Mapa.HasColisao(this, PosX - 16, PosY))
					{
						PosX = PosX - 16;
					}
				break;
			}
		}
	}
}
