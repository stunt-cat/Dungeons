/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 05/10/2012
 * Time: 09:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Dungeons
{
	/// <summary>
	/// Tile represents the smallest divisor of area on the game Board.
	/// It can have one or zero occupants.
	/// It can have adjacent Tiles (which may be in other Rooms) and adjacent Doors. N.B. Door deals with which Tiles it connects!
	/// </summary>
	
	public enum TileType {clear, water, trap};
	
	public class Tile : ITileJoiner
	{
		private Dictionary<Direction, ITileJoiner> adjacent;
		private Character occupant;
		public string imageRef;
		public TileType type;
		
		public Tile(){}
		
		public InitialiseTile(TileType type, string imageRef, ITileJoiner north, ITileJoiner east, ITileJoiner south, ITileJoiner west)
		{
			this.type = type;
			this.imageRef = imageRef;
			adjacent.Add(Direction.North, north);
			adjacent.Add(Direction.East, east);
			adjacent.Add(Direction.South, south);
			adjacent.Add(Direction.West, west);
		}
		
		public ITileJoiner Move(Direction intendedDirection){
			if(this.adjacent.TryGetValue(intendedDirection, out ITileJoiner)){
				if(ITileJoiner is Room){
					return ITileJoiner;
				} else if(ITileJoiner is Door){
					// If Door open, return ITileJoiner on the other side.
					if (ITileJoiner.status){
						return ITileJoiner.OtherSide(this);
					}
					// If Door closed, return current location i.e. no move.
					else return this;
				} else return this; // May add other types of ITile in the future, so update options here!
			} else return this;	// There is no key so return current location of Character attempting move.	
		}
	}
}
