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
using System.Drawing;
using System.Resources;

namespace Dungeons
{
	/// <summary>
	/// Room in which amazing action takes place.
	/// </summary>
	public class Room
	{
		public List<Tile> tiles;
		public Point roomOrigin = new Point();		// This is used to locate room w.r.t. game area origin (in Mainform).
		
		Random random = new Random();
		
		public Room(Point roomOrigin, int switchSelector)
		{
			// Locate the room for graphical display purposes.
			this.roomOrigin = roomOrigin;
			
			tiles = new List<Tile>();
			// TODO XML input to contain tile/door etc layout.
			
			// Create correct room from switchSelector value
			
			switch(switchSelector){
				case 1:
					// Room is 2x5 tiles.
					for (int i=0; i<10; i++){
						tiles.Add(new Tile(roomOrigin));
					}
					// Initialise trial room tiles
					tiles[0].InitialiseTile(TileType.clear, new Point(0,0), TileSelector(), null, tiles[1], tiles[2], null);
					tiles[1].InitialiseTile(TileType.clear, new Point(1,0), TileSelector(), null, null, tiles[3],tiles[0]);
					tiles[2].InitialiseTile(TileType.clear, new Point(0,1), TileSelector(), tiles[0], tiles[3], tiles[4],null);
					tiles[3].InitialiseTile(TileType.clear, new Point(1,1), TileSelector(), tiles[1], null, tiles[5],tiles[2]);
					tiles[4].InitialiseTile(TileType.clear, new Point(0,2), TileSelector(), tiles[2], tiles[5], tiles[6], null);
					tiles[5].InitialiseTile(TileType.clear, new Point(1,2), TileSelector(), tiles[3], null, tiles[7],tiles[4]);
					tiles[6].InitialiseTile(TileType.clear, new Point(0,3), TileSelector(), tiles[4], tiles[7], tiles[8],null);
					tiles[7].InitialiseTile(TileType.clear, new Point(1,3), TileSelector(), tiles[5], null, tiles[9],tiles[6]);
					tiles[8].InitialiseTile(TileType.clear, new Point(0,4), TileSelector(), tiles[6], tiles[9], null, null);
					tiles[9].InitialiseTile(TileType.clear, new Point(1,4), TileSelector(), tiles[7], null, null,tiles[8]);
				
					break;
					
				case 2:
					// Trial room is 4x4 tiles.
					for (int i=0; i<16; i++){
						tiles.Add(new Tile(roomOrigin));
					}
					// Initialise trial room tiles
					tiles[0].InitialiseTile(TileType.clear, new Point(0,0), TileSelector(), null, tiles[1], tiles[4], null);
					tiles[1].InitialiseTile(TileType.clear, new Point(1,0), TileSelector(), null, tiles[2], tiles[5],tiles[0]);
					tiles[2].InitialiseTile(TileType.clear, new Point(2,0), TileSelector(), null, tiles[3], tiles[6],tiles[1]);
					tiles[3].InitialiseTile(TileType.clear, new Point(3,0), TileSelector(), null, null, tiles[7],tiles[2]);
					tiles[4].InitialiseTile(TileType.clear, new Point(0,1), TileSelector(), tiles[0], tiles[5], tiles[8], null);
					tiles[5].InitialiseTile(TileType.clear, new Point(1,1), TileSelector(), tiles[1], tiles[6], tiles[9],tiles[4]);
					tiles[6].InitialiseTile(TileType.clear, new Point(2,1), TileSelector(), tiles[2], tiles[7], tiles[10],tiles[5]);
					tiles[7].InitialiseTile(TileType.clear, new Point(3,1), TileSelector(), tiles[3], null, tiles[11],tiles[6]);
					tiles[8].InitialiseTile(TileType.clear, new Point(0,2), TileSelector(), tiles[4], tiles[9], tiles[12], null);
					tiles[9].InitialiseTile(TileType.clear, new Point(1,2), TileSelector(), tiles[5], tiles[10], tiles[13],tiles[8]);
					tiles[10].InitialiseTile(TileType.clear, new Point(2,2), TileSelector(), tiles[6], tiles[11], tiles[14],tiles[9]);
					tiles[11].InitialiseTile(TileType.clear, new Point(3,2), TileSelector(), tiles[7], null, tiles[15],tiles[10]);
					tiles[12].InitialiseTile(TileType.clear, new Point(0,3), TileSelector(), tiles[8], tiles[13], null, null);
					tiles[13].InitialiseTile(TileType.clear, new Point(1,3), TileSelector(), tiles[9], tiles[14], null, tiles[12]);
					tiles[14].InitialiseTile(TileType.clear, new Point(2,3), TileSelector(), tiles[10], tiles[15], null, tiles[13]);
					tiles[15].InitialiseTile(TileType.clear, new Point(3,3), TileSelector(), tiles[11], null, null, tiles[14]);
					
					break;
					
			}
		}
		
		public string TileSelector(){
			int selector = random.Next(4);
	
			if(selector == 0){return "tile1";}
			else if(selector == 1){return "tile2";}
			else if (selector == 2){return "tile3";}
			else return "tile4";
		}
	}
}
