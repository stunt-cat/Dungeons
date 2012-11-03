/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 03/11/2012
 * Time: 21:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Dungeons
{
	/// <summary>
	/// TileConnector is a way of connecting Tiles simply.
	/// 	It performs the same function as Door but without any open/shut state i.e. it is always 'open'.
	/// It does not introduce any extra graphics but does remove 'wall' graphics by replacing previously null entries in affected Tile adjacencies Dictionaries.
	/// It can be used to join corridors or rooms without needing doors i.e. make long corridors/bigger rooms from standard smaller ones.
	/// </summary>
	
	public class TileConnector : ITileJoiner
	{
		public Tile sideA;
		public Tile sideB;
		
		// TileConnector constructor is empty but TileConnector is initialised with InitialiseTileConnector() method.
		public TileConnector()
		{}
		
		public void Initialse(Tile sideA, Tile sideB)
		{
			this.sideA = sideA;
			this.sideB = sideB;
		}
		
		public Tile OtherSide(Tile viewer)
		{
			if (viewer == sideA) return sideB;
			else return sideA;
		}
	}
}
