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
		public Direction wallLocation;	// Refers to side of sideA Tile that connector is on.
		
		// TileConnector constructor is empty but TileConnector is initialised with InitialiseTileConnector() method.
		public TileConnector()
		{}
		
		public void Initialse(Tile sideA, Direction wallLocation, Tile sideB)
		{
			this.sideA = sideA;
			this.sideB = sideB;
			this.wallLocation = wallLocation;
			
			// Update Tile adjacencies to reference TileConnector.
			sideA.adjacencies[wallLocation] = this;
			sideB.adjacencies[Opposite(wallLocation)] = this;
		}
		
		// Method to find opposite Direction Enum, for Initialise().
		public Direction Opposite(Direction direction)
		{
			Direction opposite = direction; // Dummy value to initialise enum
			
			switch(direction)
			{
				case Direction.North: opposite = Direction.South; break;
				case Direction.East: opposite = Direction.West; break;
				case Direction.South: opposite = Direction.North; break;
				case Direction.West: opposite = Direction.East; break;
			}
			
			return opposite;
		}
		
		public Tile OtherSide(Tile viewer)
		{
			if (viewer == sideA) return sideB;
			else return sideA;
		}
	}
}
