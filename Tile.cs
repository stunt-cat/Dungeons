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
using System.Drawing;

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
		public Dictionary<Direction, ITileJoiner> adjacent = new Dictionary<Direction, ITileJoiner>();
		public Point tileLocation = new Point(0,0);			// Locates Tile w.r.t. game area origin.
		public string imageRef;								// Basic image for Tile
		public TileType type;
		
		public Tile(Point offset){
			this.tileLocation = offset;						// Adds room origin location to point locations.
		}
		
		public void InitialiseTile(TileType type, Point tileLocationOffset, string imageRef, ITileJoiner north, ITileJoiner east, ITileJoiner south, ITileJoiner west)
		{
			this.type = type;
			tileLocation.Offset(tileLocationOffset);
			this.imageRef = imageRef;
			this.adjacent.Add(Direction.North, north);
			this.adjacent.Add(Direction.East, east);
			this.adjacent.Add(Direction.South, south);
			this.adjacent.Add(Direction.West, west);
		}
		
		
		// Method to find out which Tile, if any, is adjacent to the one in question.
		// Returns null if there is no adjacent Tile.
		// N.B. It can return an occupied Tile!!.
		public Tile Adjacent(Direction intendedDirection){
			ITileJoiner potentialAdjacent = this.adjacent[intendedDirection];
			if(potentialAdjacent != null){
				if(potentialAdjacent is Tile) return (Tile)potentialAdjacent;
				if(potentialAdjacent is Door){
					Door door = (Door)potentialAdjacent;
					// If Door open, return Tile on the other side.
					if (door.open) return door.OtherSide(this);
				}
			}
			return null; // There is no adjacent move.
		}
	}
}
