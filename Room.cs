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
	/// Rooms are composed of Tiles, which are the smallest denomination of location representation.
	/// </summary>
	public class Room
	{
		public List<Tile> tiles;
		public Point roomOrigin = new Point();		// This is used to locate room w.r.t. game area origin (in Mainform).
		public Boolean visible;
		public List<Character> occupants;			// This is used to specify initial baddies in Room. Filled from calls from Board.
		
		Random random = new Random();
		
		public Room(Point roomOrigin, int switchSelector, Boolean visible)
		{
			// Locate the room for graphical display purposes.
			this.roomOrigin = roomOrigin;
			this.visible = visible;
			
			tiles = new List<Tile>();
			// TODO XML input to contain tile/door etc layout.
			
			// Create empty List of occupants. This is populated from Board.
			occupants = new List<Character>();
			
			// Create correct room from switchSelector value
			
			switch(switchSelector){
				case 1:
					// Stairs. 2x2 tiles.
					
					for (int i=0; i<4; i++)
					{
						tiles.Add(new Tile(roomOrigin));
					}
					
					// Initialise trial room tiles.
					tiles[0].Initialise(TileType.clear, new Point(0,0), "tile_stairs", null, tiles[1], tiles[2], null);
					tiles[1].Initialise(TileType.clear, new Point(1,0), "tile_stairs", null, null, tiles[3], tiles[0]);
					tiles[2].Initialise(TileType.clear, new Point(0,1), "tile_stairs", tiles[0], tiles[3], null, null);
					tiles[3].Initialise(TileType.clear, new Point(1,1), "tile_stairs", tiles[1], null, null, tiles[2]);
					
					break;
					
					
				case 2:
					// Corridor. 2x5 tiles.
					
					for (int i=0; i<10; i++)
					{
						tiles.Add(new Tile(roomOrigin));
					}
					
					// Initialise trial room tiles
					tiles[0].Initialise(TileType.clear, new Point(0,0), "tile1", null, tiles[1], tiles[2], null);
					tiles[1].Initialise(TileType.clear, new Point(1,0), "tile1", null, null, tiles[3],tiles[0]);
					tiles[2].Initialise(TileType.clear, new Point(0,1), "tile1", tiles[0], tiles[3], tiles[4],null);
					tiles[3].Initialise(TileType.clear, new Point(1,1), "tile1", tiles[1], null, tiles[5],tiles[2]);
					tiles[4].Initialise(TileType.clear, new Point(0,2), "tile1", tiles[2], tiles[5], tiles[6], null);
					tiles[5].Initialise(TileType.clear, new Point(1,2), "tile1", tiles[3], null, tiles[7],tiles[4]);
					tiles[6].Initialise(TileType.clear, new Point(0,3), "tile1", tiles[4], tiles[7], tiles[8],null);
					tiles[7].Initialise(TileType.clear, new Point(1,3), "tile1", tiles[5], null, tiles[9],tiles[6]);
					tiles[8].Initialise(TileType.clear, new Point(0,4), "tile1", tiles[6], tiles[9], null, null);
					tiles[9].Initialise(TileType.clear, new Point(1,4), "tile1", tiles[7], null, null,tiles[8]);
				
					break;
					
				
				case 3:
					// Corridor. 5x2 tiles.
					
					for (int i=0; i<10; i++)
					{
						tiles.Add(new Tile(roomOrigin));
					}
					
					// Initialise room tiles.
					tiles[0].Initialise(TileType.clear, new Point(0,0), "tile1", null, tiles[1], tiles[5], null);
					tiles[1].Initialise(TileType.clear, new Point(1,0), "tile1", null, tiles[2], tiles[6], tiles[0]);
					tiles[2].Initialise(TileType.clear, new Point(2,0), "tile1", null, tiles[3], tiles[7], tiles[1]);
					tiles[3].Initialise(TileType.clear, new Point(3,0), "tile1", null, tiles[4], tiles[8], tiles[2]);
					tiles[4].Initialise(TileType.clear, new Point(4,0), "tile1", null, null, tiles[9], tiles[3]);
					tiles[5].Initialise(TileType.clear, new Point(0,1), "tile1", tiles[0], tiles[6], null, null);
					tiles[6].Initialise(TileType.clear, new Point(1,1), "tile1", tiles[1], tiles[7], null, tiles[5]);
					tiles[7].Initialise(TileType.clear, new Point(2,1), "tile1", tiles[2], tiles[8], null, tiles[6]);
					tiles[8].Initialise(TileType.clear, new Point(3,1), "tile1", tiles[3], tiles[9], null, tiles[7]);
					tiles[9].Initialise(TileType.clear, new Point(4,1), "tile1", tiles[4], null, null, tiles[8]);
					
					break;
					
					
					
				case 4:
					// Corridor. 2x2 tiles.
					
					for (int i=0; i<4; i++)
					{
						tiles.Add(new Tile(roomOrigin));
					}
					
					// Initialise trial room tiles.
					tiles[0].Initialise(TileType.clear, new Point(0,0), "tile1", null, tiles[1], tiles[2], null);
					tiles[1].Initialise(TileType.clear, new Point(1,0), "tile1", null, null, tiles[3], tiles[0]);
					tiles[2].Initialise(TileType.clear, new Point(0,1), "tile1", tiles[0], tiles[3], null, null);
					tiles[3].Initialise(TileType.clear, new Point(1,1), "tile1", tiles[1], null, null, tiles[2]);
					
					break;
					
				case 5:
					// Room. 5x5 tiles.
				
					for (int i=0; i<25; i++)
					{
						tiles.Add(new Tile(roomOrigin));
					}
					
					// Initialise room tiles.
					tiles[0].Initialise(TileType.clear, new Point(0,0), TileSelector(), null, tiles[1], tiles[5], null);
					tiles[1].Initialise(TileType.clear, new Point(1,0), TileSelector(), null, tiles[2], tiles[6], tiles[0]);
					tiles[2].Initialise(TileType.clear, new Point(2,0), TileSelector(), null, tiles[3], tiles[7], tiles[1]);
					tiles[3].Initialise(TileType.clear, new Point(3,0), TileSelector(), null, tiles[4], tiles[8], tiles[2]);
					tiles[4].Initialise(TileType.clear, new Point(4,0), TileSelector(), null, null, tiles[9], tiles[3]);
					tiles[5].Initialise(TileType.clear, new Point(0,1), TileSelector(), tiles[0], tiles[6], tiles[10], null);
					tiles[6].Initialise(TileType.clear, new Point(1,1), TileSelector(), tiles[1], tiles[7], tiles[11], tiles[5]);
					tiles[7].Initialise(TileType.clear, new Point(2,1), TileSelector(), tiles[2], tiles[8], tiles[12], tiles[6]);
					tiles[8].Initialise(TileType.clear, new Point(3,1), TileSelector(), tiles[3], tiles[9], tiles[13], tiles[7]);
					tiles[9].Initialise(TileType.clear, new Point(4,1), TileSelector(), tiles[4], null, tiles[14], tiles[8]);
					tiles[10].Initialise(TileType.clear, new Point(0,2), TileSelector(), tiles[5], tiles[11], tiles[15], null);
					tiles[11].Initialise(TileType.clear, new Point(1,2), TileSelector(), tiles[6], tiles[12], tiles[16], tiles[10]);
					tiles[12].Initialise(TileType.clear, new Point(2,2), TileSelector(), tiles[7], tiles[13], tiles[17], tiles[11]);
					tiles[13].Initialise(TileType.clear, new Point(3,2), TileSelector(), tiles[8], tiles[14], tiles[18], tiles[12]);
					tiles[14].Initialise(TileType.clear, new Point(4,2), TileSelector(), tiles[9], null, tiles[19], tiles[13]);
					tiles[15].Initialise(TileType.clear, new Point(0,3), TileSelector(), tiles[10], tiles[16], tiles[20], null);
					tiles[16].Initialise(TileType.clear, new Point(1,3), TileSelector(), tiles[11], tiles[17], tiles[21], tiles[15]);
					tiles[17].Initialise(TileType.clear, new Point(2,3), TileSelector(), tiles[12], tiles[18], tiles[22], tiles[16]);
					tiles[18].Initialise(TileType.clear, new Point(3,3), TileSelector(), tiles[13], tiles[19], tiles[23], tiles[17]);
					tiles[19].Initialise(TileType.clear, new Point(4,3), TileSelector(), tiles[14], null, tiles[24], tiles[18]);
					tiles[20].Initialise(TileType.clear, new Point(0,4), TileSelector(), tiles[15], tiles[21], null, null);
					tiles[21].Initialise(TileType.clear, new Point(1,4), TileSelector(), tiles[16], tiles[22], null, tiles[20]);
					tiles[22].Initialise(TileType.clear, new Point(2,4), TileSelector(), tiles[17], tiles[23], null, tiles[21]);
					tiles[23].Initialise(TileType.clear, new Point(3,4), TileSelector(), tiles[18], tiles[24], null, tiles[22]);
					tiles[24].Initialise(TileType.clear, new Point(4,4), TileSelector(), tiles[19], null, null, tiles[23]);
					
					break;
					
					
					
				case 6:
					// Room. 5x10 tiles.
				
					for (int i=0; i<50; i++)
					{
						tiles.Add(new Tile(roomOrigin));
					}
					
					// Initialise room tiles.
					tiles[0].Initialise(TileType.clear, new Point(0,0), TileSelector(), null, tiles[1], tiles[5], null);
					tiles[1].Initialise(TileType.clear, new Point(1,0), TileSelector(), null, tiles[2], tiles[6], tiles[0]);
					tiles[2].Initialise(TileType.clear, new Point(2,0), TileSelector(), null, tiles[3], tiles[7], tiles[1]);
					tiles[3].Initialise(TileType.clear, new Point(3,0), TileSelector(), null, tiles[4], tiles[8], tiles[2]);
					tiles[4].Initialise(TileType.clear, new Point(4,0), TileSelector(), null, null, tiles[9], tiles[3]);
					tiles[5].Initialise(TileType.clear, new Point(0,1), TileSelector(), tiles[0], tiles[6], tiles[10], null);
					tiles[6].Initialise(TileType.clear, new Point(1,1), TileSelector(), tiles[1], tiles[7], tiles[11], tiles[5]);
					tiles[7].Initialise(TileType.clear, new Point(2,1), TileSelector(), tiles[2], tiles[8], tiles[12], tiles[6]);
					tiles[8].Initialise(TileType.clear, new Point(3,1), TileSelector(), tiles[3], tiles[9], tiles[13], tiles[7]);
					tiles[9].Initialise(TileType.clear, new Point(4,1), TileSelector(), tiles[4], null, tiles[14], tiles[8]);
					tiles[10].Initialise(TileType.clear, new Point(0,2), TileSelector(), tiles[5], tiles[11], tiles[15], null);
					tiles[11].Initialise(TileType.clear, new Point(1,2), TileSelector(), tiles[6], tiles[12], tiles[16], tiles[10]);
					tiles[12].Initialise(TileType.clear, new Point(2,2), TileSelector(), tiles[7], tiles[13], tiles[17], tiles[11]);
					tiles[13].Initialise(TileType.clear, new Point(3,2), TileSelector(), tiles[8], tiles[14], tiles[18], tiles[12]);
					tiles[14].Initialise(TileType.clear, new Point(4,2), TileSelector(), tiles[9], null, tiles[19], tiles[13]);
					tiles[15].Initialise(TileType.clear, new Point(0,3), TileSelector(), tiles[10], tiles[16], tiles[20], null);
					tiles[16].Initialise(TileType.clear, new Point(1,3), TileSelector(), tiles[11], tiles[17], tiles[21], tiles[15]);
					tiles[17].Initialise(TileType.clear, new Point(2,3), TileSelector(), tiles[12], tiles[18], tiles[22], tiles[16]);
					tiles[18].Initialise(TileType.clear, new Point(3,3), TileSelector(), tiles[13], tiles[19], tiles[23], tiles[17]);
					tiles[19].Initialise(TileType.clear, new Point(4,3), TileSelector(), tiles[14], null, tiles[24], tiles[18]);
					tiles[20].Initialise(TileType.clear, new Point(0,4), TileSelector(), tiles[15], tiles[21], tiles[25], null);
					tiles[21].Initialise(TileType.clear, new Point(1,4), TileSelector(), tiles[16], tiles[22], tiles[26], tiles[20]);
					tiles[22].Initialise(TileType.clear, new Point(2,4), TileSelector(), tiles[17], tiles[23], tiles[27], tiles[21]);
					tiles[23].Initialise(TileType.clear, new Point(3,4), TileSelector(), tiles[18], tiles[24], tiles[28], tiles[22]);
					tiles[24].Initialise(TileType.clear, new Point(4,4), TileSelector(), tiles[19], null, tiles[29], tiles[23]);
					tiles[25].Initialise(TileType.clear, new Point(0,5), TileSelector(), tiles[20], tiles[26], tiles[30], null);
					tiles[26].Initialise(TileType.clear, new Point(1,5), TileSelector(), tiles[21], tiles[27], tiles[31], tiles[25]);
					tiles[27].Initialise(TileType.clear, new Point(2,5), TileSelector(), tiles[22], tiles[28], tiles[32], tiles[26]);
					tiles[28].Initialise(TileType.clear, new Point(3,5), TileSelector(), tiles[23], tiles[29], tiles[33], tiles[27]);
					tiles[29].Initialise(TileType.clear, new Point(4,5), TileSelector(), tiles[24], null, tiles[34], tiles[28]);
					tiles[30].Initialise(TileType.clear, new Point(0,6), TileSelector(), tiles[25], tiles[31], tiles[35], null);
					tiles[31].Initialise(TileType.clear, new Point(1,6), TileSelector(), tiles[26], tiles[32], tiles[36], tiles[30]);
					tiles[32].Initialise(TileType.clear, new Point(2,6), TileSelector(), tiles[27], tiles[33], tiles[37], tiles[31]);
					tiles[33].Initialise(TileType.clear, new Point(3,6), TileSelector(), tiles[28], tiles[34], tiles[38], tiles[32]);
					tiles[34].Initialise(TileType.clear, new Point(4,6), TileSelector(), tiles[29], null, tiles[39], tiles[33]);
					tiles[35].Initialise(TileType.clear, new Point(0,7), TileSelector(), tiles[30], tiles[36], tiles[40], null);
					tiles[36].Initialise(TileType.clear, new Point(1,7), TileSelector(), tiles[31], tiles[37], tiles[41], tiles[35]);
					tiles[37].Initialise(TileType.clear, new Point(2,7), TileSelector(), tiles[32], tiles[38], tiles[42], tiles[36]);
					tiles[38].Initialise(TileType.clear, new Point(3,7), TileSelector(), tiles[33], tiles[39], tiles[43], tiles[37]);
					tiles[39].Initialise(TileType.clear, new Point(4,7), TileSelector(), tiles[34], null, tiles[44], tiles[38]);
					tiles[40].Initialise(TileType.clear, new Point(0,8), TileSelector(), tiles[35], tiles[41], tiles[45], null);
					tiles[41].Initialise(TileType.clear, new Point(1,8), TileSelector(), tiles[36], tiles[42], tiles[46], tiles[40]);
					tiles[42].Initialise(TileType.clear, new Point(2,8), TileSelector(), tiles[37], tiles[43], tiles[47], tiles[41]);
					tiles[43].Initialise(TileType.clear, new Point(3,8), TileSelector(), tiles[38], tiles[44], tiles[48], tiles[42]);
					tiles[44].Initialise(TileType.clear, new Point(4,8), TileSelector(), tiles[39], null, tiles[49], tiles[43]);
					tiles[45].Initialise(TileType.clear, new Point(0,9), TileSelector(), tiles[40], tiles[46], null, null);
					tiles[46].Initialise(TileType.clear, new Point(1,9), TileSelector(), tiles[41], tiles[47], null, tiles[45]);
					tiles[47].Initialise(TileType.clear, new Point(2,9), TileSelector(), tiles[42], tiles[48], null, tiles[46]);
					tiles[48].Initialise(TileType.clear, new Point(3,9), TileSelector(), tiles[43], tiles[49], null, tiles[47]);
					tiles[49].Initialise(TileType.clear, new Point(4,9), TileSelector(), tiles[44], null, null, tiles[48]);
					
					break;
					
				case 7:
					// Room. 10x5 tiles.
					
					for (int i=0; i<50; i++)
					{
						tiles.Add(new Tile(roomOrigin));
					}
					
					// Initialise room tiles.
					tiles[0].Initialise(TileType.clear, new Point(0,0), TileSelector(), null, tiles[1], tiles[10], null);
					tiles[1].Initialise(TileType.clear, new Point(1,0), TileSelector(), null, tiles[2], tiles[11], tiles[0]);
					tiles[2].Initialise(TileType.clear, new Point(2,0), TileSelector(), null, tiles[3], tiles[12], tiles[1]);
					tiles[3].Initialise(TileType.clear, new Point(3,0), TileSelector(), null, tiles[4], tiles[13], tiles[2]);
					tiles[4].Initialise(TileType.clear, new Point(4,0), TileSelector(), null, tiles[5], tiles[14], tiles[3]);
					tiles[5].Initialise(TileType.clear, new Point(5,0), TileSelector(), null, tiles[6], tiles[15], tiles[4]);
					tiles[6].Initialise(TileType.clear, new Point(6,0), TileSelector(), null, tiles[7], tiles[16], tiles[5]);
					tiles[7].Initialise(TileType.clear, new Point(7,0), TileSelector(), null, tiles[8], tiles[17], tiles[6]);
					tiles[8].Initialise(TileType.clear, new Point(8,0), TileSelector(), null, tiles[9], tiles[18], tiles[7]);
					tiles[9].Initialise(TileType.clear, new Point(9,0), TileSelector(), null, null, tiles[19], tiles[8]);
					tiles[10].Initialise(TileType.clear, new Point(0,1), TileSelector(), tiles[0], tiles[11], tiles[20], null);
					tiles[11].Initialise(TileType.clear, new Point(1,1), TileSelector(), tiles[1], tiles[12], tiles[21], tiles[10]);
					tiles[12].Initialise(TileType.clear, new Point(2,1), TileSelector(), tiles[2], tiles[13], tiles[22], tiles[11]);
					tiles[13].Initialise(TileType.clear, new Point(3,1), TileSelector(), tiles[3], tiles[14], tiles[23], tiles[12]);
					tiles[14].Initialise(TileType.clear, new Point(4,1), TileSelector(), tiles[4], tiles[15], tiles[24], tiles[13]);
					tiles[15].Initialise(TileType.clear, new Point(5,1), TileSelector(), tiles[5], tiles[16], tiles[25], tiles[14]);
					tiles[16].Initialise(TileType.clear, new Point(6,1), TileSelector(), tiles[6], tiles[17], tiles[26], tiles[15]);
					tiles[17].Initialise(TileType.clear, new Point(7,1), TileSelector(), tiles[7], tiles[18], tiles[27], tiles[16]);
					tiles[18].Initialise(TileType.clear, new Point(8,1), TileSelector(), tiles[8], tiles[19], tiles[28], tiles[17]);
					tiles[19].Initialise(TileType.clear, new Point(9,1), TileSelector(), tiles[9], null, tiles[29], tiles[18]);
					tiles[20].Initialise(TileType.clear, new Point(0,2), TileSelector(), tiles[10], tiles[21], tiles[30], null);
					tiles[21].Initialise(TileType.clear, new Point(1,2), TileSelector(), tiles[11], tiles[22], tiles[31], tiles[20]);
					tiles[22].Initialise(TileType.clear, new Point(2,2), TileSelector(), tiles[12], tiles[23], tiles[32], tiles[21]);
					tiles[23].Initialise(TileType.clear, new Point(3,2), TileSelector(), tiles[13], tiles[24], tiles[33], tiles[22]);
					tiles[24].Initialise(TileType.clear, new Point(4,2), TileSelector(), tiles[14], tiles[25], tiles[34], tiles[23]);
					tiles[25].Initialise(TileType.clear, new Point(5,2), TileSelector(), tiles[15], tiles[26], tiles[35], tiles[24]);
					tiles[26].Initialise(TileType.clear, new Point(6,2), TileSelector(), tiles[16], tiles[27], tiles[36], tiles[25]);
					tiles[27].Initialise(TileType.clear, new Point(7,2), TileSelector(), tiles[17], tiles[28], tiles[37], tiles[26]);
					tiles[28].Initialise(TileType.clear, new Point(8,2), TileSelector(), tiles[18], tiles[29], tiles[38], tiles[27]);
					tiles[29].Initialise(TileType.clear, new Point(9,2), TileSelector(), tiles[19], null, tiles[39], tiles[28]);
					tiles[30].Initialise(TileType.clear, new Point(0,3), TileSelector(), tiles[20], tiles[31], tiles[40], null);
					tiles[31].Initialise(TileType.clear, new Point(1,3), TileSelector(), tiles[21], tiles[32], tiles[41], tiles[30]);
					tiles[32].Initialise(TileType.clear, new Point(2,3), TileSelector(), tiles[22], tiles[33], tiles[42], tiles[31]);
					tiles[33].Initialise(TileType.clear, new Point(3,3), TileSelector(), tiles[23], tiles[34], tiles[43], tiles[32]);
					tiles[34].Initialise(TileType.clear, new Point(4,3), TileSelector(), tiles[24], tiles[35], tiles[44], tiles[33]);
					tiles[35].Initialise(TileType.clear, new Point(5,3), TileSelector(), tiles[25], tiles[36], tiles[45], tiles[34]);
					tiles[36].Initialise(TileType.clear, new Point(6,3), TileSelector(), tiles[26], tiles[37], tiles[46], tiles[35]);
					tiles[37].Initialise(TileType.clear, new Point(7,3), TileSelector(), tiles[27], tiles[38], tiles[47], tiles[36]);
					tiles[38].Initialise(TileType.clear, new Point(8,3), TileSelector(), tiles[28], tiles[39], tiles[48], tiles[37]);
					tiles[39].Initialise(TileType.clear, new Point(9,3), TileSelector(), tiles[29], null, tiles[49], tiles[38]);
					tiles[40].Initialise(TileType.clear, new Point(0,4), TileSelector(), tiles[30], tiles[41], null, null);
					tiles[41].Initialise(TileType.clear, new Point(1,4), TileSelector(), tiles[31], tiles[42], null, tiles[40]);
					tiles[42].Initialise(TileType.clear, new Point(2,4), TileSelector(), tiles[32], tiles[43], null, tiles[41]);
					tiles[43].Initialise(TileType.clear, new Point(3,4), TileSelector(), tiles[33], tiles[44], null, tiles[42]);
					tiles[44].Initialise(TileType.clear, new Point(4,4), TileSelector(), tiles[34], tiles[45], null, tiles[43]);
					tiles[45].Initialise(TileType.clear, new Point(5,4), TileSelector(), tiles[35], tiles[46], null, tiles[44]);
					tiles[46].Initialise(TileType.clear, new Point(6,4), TileSelector(), tiles[36], tiles[47], null, tiles[45]);
					tiles[47].Initialise(TileType.clear, new Point(7,4), TileSelector(), tiles[37], tiles[48], null, tiles[46]);
					tiles[48].Initialise(TileType.clear, new Point(8,4), TileSelector(), tiles[38], tiles[49], null, tiles[47]);
					tiles[49].Initialise(TileType.clear, new Point(9,4), TileSelector(), tiles[39], null, null, tiles[48]);
					
					
					break;
			}
		}
		
		public string TileSelector(){
			int selector = random.Next(4);
	
			if(selector == 0){return "tile2";}
			else if(selector == 1){return "tile3";}
			else if (selector == 2){return "tile4";}
			else if (selector == 3){return "tile5";}
			else return "tile6";
		}
		
		
		/*
					EXTRA ROOM SIZES
					***************

					// Trial room is 3x3 tiles. Room decoration.
					
					for (int i=0; i<9; i++)
					{
						tiles.Add(new Tile(roomOrigin));
					}
					
					// Initialise trial room tiles.
					tiles[0].Initialise(TileType.clear, new Point(0,0), TileSelector(), null, tiles[1], tiles[3], null);
					tiles[1].Initialise(TileType.clear, new Point(1,0), TileSelector(), null, tiles[2], tiles[4], tiles[0]);
					tiles[2].Initialise(TileType.clear, new Point(2,0), TileSelector(), null, null, tiles[5], tiles[1]);
					tiles[3].Initialise(TileType.clear, new Point(0,1), TileSelector(), tiles[0], tiles[4], tiles[6], null);
					tiles[4].Initialise(TileType.clear, new Point(1,1), TileSelector(), tiles[1], tiles[5], tiles[7], tiles[3]);
					tiles[5].Initialise(TileType.clear, new Point(2,1), TileSelector(), tiles[2], null, tiles[8], tiles[4]);
					tiles[6].Initialise(TileType.clear, new Point(0,2), TileSelector(), tiles[3], tiles[7], null, null);
					tiles[7].Initialise(TileType.clear, new Point(1,2), TileSelector(), tiles[4], tiles[8], null, tiles[6]);
					tiles[8].Initialise(TileType.clear, new Point(2,2), TileSelector(), tiles[5], null, null, tiles[7]);
					
					break;
					
					// Trial room is 4x4 tiles. Room decoration.
					
					for (int i=0; i<16; i++)
					{
						tiles.Add(new Tile(roomOrigin));
					}
					
					// Initialise trial room tiles
					tiles[0].Initialise(TileType.clear, new Point(0,0), TileSelector(), null, tiles[1], tiles[4], null);
					tiles[1].Initialise(TileType.clear, new Point(1,0), TileSelector(), null, tiles[2], tiles[5],tiles[0]);
					tiles[2].Initialise(TileType.clear, new Point(2,0), TileSelector(), null, tiles[3], tiles[6],tiles[1]);
					tiles[3].Initialise(TileType.clear, new Point(3,0), TileSelector(), null, null, tiles[7],tiles[2]);
					tiles[4].Initialise(TileType.clear, new Point(0,1), TileSelector(), tiles[0], tiles[5], tiles[8], null);
					tiles[5].Initialise(TileType.clear, new Point(1,1), TileSelector(), tiles[1], tiles[6], tiles[9],tiles[4]);
					tiles[6].Initialise(TileType.clear, new Point(2,1), TileSelector(), tiles[2], tiles[7], tiles[10],tiles[5]);
					tiles[7].Initialise(TileType.clear, new Point(3,1), TileSelector(), tiles[3], null, tiles[11],tiles[6]);
					tiles[8].Initialise(TileType.clear, new Point(0,2), TileSelector(), tiles[4], tiles[9], tiles[12], null);
					tiles[9].Initialise(TileType.clear, new Point(1,2), TileSelector(), tiles[5], tiles[10], tiles[13],tiles[8]);
					tiles[10].Initialise(TileType.clear, new Point(2,2), TileSelector(), tiles[6], tiles[11], tiles[14],tiles[9]);
					tiles[11].Initialise(TileType.clear, new Point(3,2), TileSelector(), tiles[7], null, tiles[15],tiles[10]);
					tiles[12].Initialise(TileType.clear, new Point(0,3), TileSelector(), tiles[8], tiles[13], null, null);
					tiles[13].Initialise(TileType.clear, new Point(1,3), TileSelector(), tiles[9], tiles[14], null, tiles[12]);
					tiles[14].Initialise(TileType.clear, new Point(2,3), TileSelector(), tiles[10], tiles[15], null, tiles[13]);
					tiles[15].Initialise(TileType.clear, new Point(3,3), TileSelector(), tiles[11], null, null, tiles[14]);
					
					break;
					*/
	}
}
