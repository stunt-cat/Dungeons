/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 12/03/2012
 * Time: 09:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Dungeons
{
	/// <summary>
	/// Room in which amazing action takes place.
	/// </summary>
	public class Room : Area
	{
		List<Tile> tiles;
		
		public Room()
		{
			tiles = new List<Tile>();
			// TODO XML input to contain tile/door etc layout.
			
			// Trial room is 4x4 tiles
			for (int i=0; i<16; i++){
				tiles.Add(new Tile());
			}
			// Initialise trial room tiles 
			tiles[0].InitialiseTile(clear, "tile1.gif", null, tiles[1], tiles[4],null);
			tiles[1].InitialiseTile(clear, "tile1.gif", null, tiles[2], tiles[2],tiles[0]);
			tiles[2].InitialiseTile(clear, "tile1.gif", null, tiles[3], tiles[6],tiles[1]);
			tiles[3].InitialiseTile(clear, "tile1.gif", null, null, tiles[7],tiles[2]);
			tiles[4].InitialiseTile(clear, "tile1.gif", tiles[0], tiles[5], tiles[8],null);
			tiles[5].InitialiseTile(clear, "tile1.gif", tiles[1], tiles[6], tiles[9],tiles[4]);
			tiles[6].InitialiseTile(clear, "tile1.gif", tiles[2], tiles[7], tiles[10],tiles[5]);
			tiles[7].InitialiseTile(clear, "tile1.gif", tiles[3], null, tiles[11],tiles[6]);
			tiles[8].InitialiseTile(clear, "tile1.gif", tiles[4], tiles[9], tiles[12],null);
			tiles[9].InitialiseTile(clear, "tile1.gif", tiles[5], tiles[10], tiles[13],tiles[8]);
			tiles[10].InitialiseTile(clear, "tile1.gif", tiles[6], tiles[11], tiles[14],tiles[9]);
			tiles[11].InitialiseTile(clear, "tile1.gif", tiles[7], null, tiles[15],tiles[10]);
			tiles[12].InitialiseTile(clear, "tile1.gif", tiles[8], tiles[13], null, null);
			tiles[13].InitialiseTile(clear, "tile1.gif", tiles[9], tiles[14], null, tiles[12]);
			tiles[14].InitialiseTile(clear, "tile1.gif", tiles[10], tiles[15], null, tiles[13]);
			tiles[15].InitialiseTile(clear, "tile1.gif", tiles[11], null, null, tiles[14]);
			
		}
		
		public Boolean Move(Character mover, Direction intendedDirection) 
		{
			if(mover.location.adjacent.TryGetValue(intendedDirection, out ITileJoiner) == null){
				return false;
			} else {
				mover.location = mover.location.adjacent.TryGetValue(intendedDirection, out ITileJoiner);
				return true;
			}
		}
		
		/*
		public Boolean WallCollision(Character character, Direction direction)
		{
			Boolean result = false;
			if (direction == Direction.North && character.location.Y == 0
			    || direction == Direction.East && character.location.X == this.pixelsX - 100
			    || direction == Direction.South && character.location.Y == this.pixelsY - 100
			    || direction == Direction.West && character.location.X == 0)
			{
				result = true;
			}
			return result;
		}
		*/
	}
}
