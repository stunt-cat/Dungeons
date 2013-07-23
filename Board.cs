/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 02/11/2012
 * Time: 11:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Dungeons
{
	/// <summary>
	/// Board is used to generate and represent the playing area, which is made of Rooms.
	/// Currently, Board must be manually set up to choose the playing area, by selecting which rooms are required
	/// and where the doors are (and where they connect), and deciding how many baddies (and of which type) are in which room.
	/// </summary>
	
	public class Board
	{
		public List<Door> doors = new List<Door>();
		public List<Room> rooms = new List<Room>();
		public List<TileConnector> connectors = new List<TileConnector>();
		
		public Direction startDirection = Direction.East;
		
		Random random = new Random();
		
		public Board(int difficultySelection)
		{
			switch(difficultySelection)
			{
				case 1:			//easy setting
					
					// Create any Door(s)
					for (int i=0; i<5; i++)
					{
						doors.Add(new Door());
					}
					
					// Create any TileConnector(s)
					for (int i=0; i<14; i++)
					{
						connectors.Add(new TileConnector());
					}
					
					// Create Room(s)
					// N.B. 2nd arg in constructor relates to;
					// 1 - 2x2 stairs
					// 2 - 2x5 corridor
					// 3 - 5x2 corridor
					// 4 - 2x2 corridor
					// 5 - 5x5 room
					// 6 - 5 x 10 room
					// 7 - 10 x 5 room
		
					rooms.Add(new Room(new Point(0,0), 1, true));
					rooms.Add(new Room(new Point(2,0), 3, true));
					rooms.Add(new Room(new Point(7,0), 4, true));
					rooms.Add(new Room(new Point(7,-5), 2, true));
					rooms.Add(new Room(new Point(5,-10), 5, false));
					rooms.Add(new Room(new Point(9,0), 3, true));
					rooms.Add(new Room(new Point(14,0), 4, true));
					rooms.Add(new Room(new Point(14,-5), 2, true));
					rooms.Add(new Room(new Point(13,-10), 7, false));
					rooms.Add(new Room(new Point(19,-5), 5, false));
					rooms.Add(new Room(new Point(24,-2), 3, false));
					rooms.Add(new Room(new Point(29,-2), 3, false));
					rooms.Add(new Room(new Point(29,-12), 6, false));
					
					
					          
					// Initialise any Door(s). N.B. This updates relevant Tiles in relevant Rooms to point to it/them.
					doors[0].Initialise(rooms[4].tiles[22], Direction.South, rooms[3].tiles[0]);
					doors[1].Initialise(rooms[8].tiles[41], Direction.South, rooms[7].tiles[0]);
					doors[2].Initialise(rooms[8].tiles[48], Direction.South, rooms[9].tiles[2]);
					doors[3].Initialise(rooms[9].tiles[24], Direction.East, rooms[10].tiles[5]);
					doors[4].Initialise(rooms[12].tiles[47], Direction.South, rooms[11].tiles[2]);
					
					
					// Initialise any TileConnector(s). N.B. This updates relevant Tiles in relevant Rooms to point to it/them.
					connectors[0].Initialse(rooms[0].tiles[1], Direction.East, rooms[1].tiles[0]);
					connectors[1].Initialse(rooms[0].tiles[3], Direction.East, rooms[1].tiles[5]);
					connectors[2].Initialse(rooms[1].tiles[4], Direction.East, rooms[2].tiles[0]);
					connectors[3].Initialse(rooms[1].tiles[9], Direction.East, rooms[2].tiles[2]);
					connectors[4].Initialse(rooms[3].tiles[8], Direction.South, rooms[2].tiles[0]);
					connectors[5].Initialse(rooms[3].tiles[9], Direction.South, rooms[2].tiles[1]);
					connectors[6].Initialse(rooms[2].tiles[1], Direction.East, rooms[5].tiles[0]);
					connectors[7].Initialse(rooms[2].tiles[3], Direction.East, rooms[5].tiles[5]);
					connectors[8].Initialse(rooms[5].tiles[4], Direction.East, rooms[6].tiles[0]);
					connectors[9].Initialse(rooms[5].tiles[9], Direction.East, rooms[6].tiles[2]);
					connectors[10].Initialse(rooms[7].tiles[8], Direction.South, rooms[6].tiles[0]);
					connectors[11].Initialse(rooms[7].tiles[9], Direction.South, rooms[6].tiles[1]);
					connectors[12].Initialse(rooms[10].tiles[4], Direction.East, rooms[11].tiles[0]);
					connectors[13].Initialse(rooms[10].tiles[9], Direction.East, rooms[11].tiles[5]);
					
					
					
					// Populate List<Room> in each Door, that will become visible when Door is opened.
					
					doors[0].makesVisible.Add(rooms[4]);
					doors[1].makesVisible.Add(rooms[8]);
					doors[2].makesVisible.Add(rooms[9]);
					doors[3].makesVisible.Add(rooms[10]);
					doors[3].makesVisible.Add(rooms[11]);
					doors[4].makesVisible.Add(rooms[12]);
					
					
					// Add baddies to rooms
					
					// Baddies for rooms[4]
					rooms[4].occupants = new List<Character>(2);
					for(int i=0; i<2; i++)
						rooms[4].occupants.Add(new Baddie(AssignLocation(rooms[4]), (Direction)random.Next(4), 1, 1, 1, 1, 2));
					
					// Baddies for rooms[8]
					rooms[8].occupants = new List<Character>(5);
					for(int i=0; i<5; i++)
						rooms[8].occupants.Add(new Baddie(AssignLocation(rooms[8]), (Direction)random.Next(4), 1, 1, 1, 1, 2));
					
					// Baddies for rooms[9]
					rooms[9].occupants = new List<Character>(2);
					for(int i=0; i<2; i++)
						rooms[9].occupants.Add(new Baddie(AssignLocation(rooms[9]), (Direction)random.Next(4), 1, 1, 1, 1, 2));
					
					// Baddies for rooms[12]
					rooms[12].occupants = new List<Character>(4);
					for(int i=0; i<3; i++){
						rooms[12].occupants.Add(new Baddie(AssignLocation(rooms[12]), (Direction)random.Next(4), 1, 1, 1, 1, 2));
					}
					rooms[12].occupants.Add(new BaddieLord(AssignLocation(rooms[12]), (Direction)random.Next(4), 1, 1, 1, 1, 4));
					
					break;
					
				case 2:			// medium setting
					
					// Create any Door(s)
					for (int i=0; i<11; i++)
					{
						doors.Add(new Door());
					}
					
					// Create any TileConnector(s)
					for (int i=0; i<22; i++)
					{
						connectors.Add(new TileConnector());
					}
					
					// Create Room(s)
					// N.B. 2nd arg in constructor relates to;
					// 1 - 2x2 stairs
					// 2 - 2x5 corridor
					// 3 - 5x2 corridor
					// 4 - 2x2 corridor
					// 5 - 5x5 room
					// 6 - 5 x 10 room
					// 7 - 10 x 5 room
		
					rooms.Add(new Room(new Point(0,0), 1, true));
					rooms.Add(new Room(new Point(2,0), 3, true));
					rooms.Add(new Room(new Point(7,0), 4, true));
					rooms.Add(new Room(new Point(7,2), 2, true));
					rooms.Add(new Room(new Point(5,7), 5, false));
					rooms.Add(new Room(new Point(0,7), 5, false));
					rooms.Add(new Room(new Point(0,12), 2, false));
					rooms.Add(new Room(new Point(9,0), 3, true));
					rooms.Add(new Room(new Point(14,0), 3, true));
					rooms.Add(new Room(new Point(19,-2), 5, false));
					rooms.Add(new Room(new Point(13,2), 6, false));
					rooms.Add(new Room(new Point(18,10), 3, false));
					rooms.Add(new Room(new Point(23,10), 4, false));
					rooms.Add(new Room(new Point(23,12), 2, false));
					rooms.Add(new Room(new Point(18,14), 5, false));
					rooms.Add(new Room(new Point(13,16), 5, false));
					rooms.Add(new Room(new Point(8,17), 3, false));
					rooms.Add(new Room(new Point(6,17), 4, false));
					rooms.Add(new Room(new Point(6,15), 4, false));
					rooms.Add(new Room(new Point(4,15), 4, false));
					rooms.Add(new Room(new Point(4,17), 2, false));
					rooms.Add(new Room(new Point(2,22), 5, false));
					rooms.Add(new Room(new Point(7,22), 7, false));
					
					          
					// Initialise any Door(s). N.B. This updates relevant Tiles in relevant Rooms to point to it/them.
					doors[0].Initialise(rooms[3].tiles[8], Direction.South, rooms[4].tiles[2]);
					doors[1].Initialise(rooms[5].tiles[9], Direction.East, rooms[4].tiles[5]);
					doors[2].Initialise(rooms[5].tiles[21], Direction.South, rooms[6].tiles[1]);
					doors[3].Initialise(rooms[8].tiles[6], Direction.South, rooms[10].tiles[2]);
					doors[4].Initialise(rooms[8].tiles[4], Direction.East, rooms[9].tiles[10]);
					doors[5].Initialise(rooms[10].tiles[49], Direction.East, rooms[11].tiles[5]);
					doors[6].Initialise(rooms[14].tiles[14], Direction.East, rooms[13].tiles[8]);
					doors[7].Initialise(rooms[15].tiles[9], Direction.East, rooms[14].tiles[15]);
					doors[8].Initialise(rooms[16].tiles[9], Direction.East, rooms[15].tiles[10]);
					doors[9].Initialise(rooms[20].tiles[8], Direction.South, rooms[21].tiles[2]);
					doors[10].Initialise(rooms[21].tiles[14], Direction.East, rooms[22].tiles[20]);
					
					
					// Initialise any TileConnector(s). N.B. This updates relevant Tiles in relevant Rooms to point to it/them.
					connectors[0].Initialse(rooms[0].tiles[1], Direction.East, rooms[1].tiles[0]);
					connectors[1].Initialse(rooms[0].tiles[3], Direction.East, rooms[1].tiles[5]);
					connectors[2].Initialse(rooms[1].tiles[4], Direction.East, rooms[2].tiles[0]);
					connectors[3].Initialse(rooms[1].tiles[9], Direction.East, rooms[2].tiles[2]);
					connectors[4].Initialse(rooms[2].tiles[2], Direction.South, rooms[3].tiles[0]);
					connectors[5].Initialse(rooms[2].tiles[3], Direction.South, rooms[3].tiles[1]);
					connectors[6].Initialse(rooms[2].tiles[1], Direction.East, rooms[7].tiles[0]);
					connectors[7].Initialse(rooms[2].tiles[3], Direction.East, rooms[7].tiles[5]);
					connectors[8].Initialse(rooms[7].tiles[4], Direction.East, rooms[8].tiles[0]);
					connectors[9].Initialse(rooms[7].tiles[5], Direction.East, rooms[8].tiles[5]);
					connectors[10].Initialse(rooms[11].tiles[4], Direction.East, rooms[12].tiles[0]);
					connectors[11].Initialse(rooms[11].tiles[9], Direction.East, rooms[12].tiles[2]);
					connectors[12].Initialse(rooms[12].tiles[2], Direction.South, rooms[13].tiles[0]);
					connectors[13].Initialse(rooms[12].tiles[3], Direction.South, rooms[13].tiles[1]);
					connectors[14].Initialse(rooms[17].tiles[1], Direction.East, rooms[16].tiles[0]);
					connectors[15].Initialse(rooms[17].tiles[3], Direction.East, rooms[16].tiles[5]);
					connectors[16].Initialse(rooms[18].tiles[2], Direction.South, rooms[17].tiles[0]);
					connectors[17].Initialse(rooms[18].tiles[3], Direction.South, rooms[17].tiles[1]);
					connectors[18].Initialse(rooms[19].tiles[1], Direction.East, rooms[18].tiles[0]);
					connectors[19].Initialse(rooms[19].tiles[3], Direction.East, rooms[18].tiles[2]);
					connectors[20].Initialse(rooms[19].tiles[2], Direction.South, rooms[20].tiles[0]);
					connectors[21].Initialse(rooms[19].tiles[3], Direction.South, rooms[20].tiles[1]);
					
					
					// Populate List<Room> in each Door, that will become visible when Door is opened.
					doors[0].makesVisible.Add(rooms[4]);
					doors[1].makesVisible.Add(rooms[5]);
					doors[2].makesVisible.Add(rooms[6]);
					doors[3].makesVisible.Add(rooms[10]);
					doors[4].makesVisible.Add(rooms[9]);
					doors[5].makesVisible.Add(rooms[11]);
					doors[5].makesVisible.Add(rooms[12]);
					doors[5].makesVisible.Add(rooms[13]);
					doors[6].makesVisible.Add(rooms[14]);
					doors[7].makesVisible.Add(rooms[15]);
					doors[8].makesVisible.Add(rooms[16]);
					doors[8].makesVisible.Add(rooms[17]);
					doors[8].makesVisible.Add(rooms[18]);
					doors[8].makesVisible.Add(rooms[19]);
					doors[8].makesVisible.Add(rooms[20]);
					doors[9].makesVisible.Add(rooms[21]);
					doors[10].makesVisible.Add(rooms[22]);
					
					
					// Add baddies to rooms
					
					// Baddies for rooms[4]
					rooms[4].occupants = new List<Character>(3);
					for(int i=0; i<3; i++)
						rooms[4].occupants.Add(new Baddie(AssignLocation(rooms[4]), (Direction)random.Next(4), 1, 1, 1, 1, 2));
					
					// Baddies for rooms[5]
					rooms[5].occupants = new List<Character>(4);
					for(int i=0; i<4; i++)
						rooms[5].occupants.Add(new Baddie(AssignLocation(rooms[5]), (Direction)random.Next(4), 1, 1, 1, 1, 2));
					
					// Baddies for rooms[9]
					rooms[9].occupants = new List<Character>(3);
					for(int i=0; i<3; i++)
						rooms[9].occupants.Add(new Baddie(AssignLocation(rooms[9]), (Direction)random.Next(4), 1, 1, 1, 1, 2));
					
					// Baddies for rooms[10]
					rooms[10].occupants = new List<Character>(9);
					for(int i=0; i<9; i++)
						rooms[10].occupants.Add(new Baddie(AssignLocation(rooms[10]), (Direction)random.Next(4), 1, 1, 1, 1, 2));
					
					// Baddies for rooms[14]
					rooms[14].occupants = new List<Character>(3);
					for(int i=0; i<3; i++)
						rooms[14].occupants.Add(new Baddie(AssignLocation(rooms[14]), (Direction)random.Next(4), 1, 1, 1, 1, 2));
					
					// Baddies for rooms[15]
					rooms[15].occupants = new List<Character>(3);
					for(int i=0; i<3; i++)
						rooms[15].occupants.Add(new Baddie(AssignLocation(rooms[15]), (Direction)random.Next(4), 1, 1, 1, 1, 2));
					
					// Baddies for rooms[21]
					rooms[21].occupants = new List<Character>(2);
					for(int i=0; i<2; i++)
						rooms[21].occupants.Add(new Baddie(AssignLocation(rooms[21]), (Direction)random.Next(4), 1, 1, 1, 1, 2));
					
					// Baddies for rooms[22]
					rooms[22].occupants = new List<Character>(7);
					for(int i=0; i<5; i++)
						rooms[22].occupants.Add(new Baddie(AssignLocation(rooms[22]), (Direction)random.Next(4), 1, 1, 1, 1, 2));
					for(int i=0; i<2; i++)
						rooms[22].occupants.Add(new BaddieLord(AssignLocation(rooms[22]), (Direction)random.Next(4), 1, 1, 1, 1, 4));
					
					break;
					
			}
				
			
		}
			
		// Returns random Tile location from anywhere in specified Room.
		public Tile RandomLocation(Room room)
		{
			Tile randomTile = room.tiles[random.Next(room.tiles.Count)];
			return randomTile;
		}
		
		public Tile AssignLocation(Room locationRoom)
			{
			// Only assigns location if it is not occupied already.
			
				Tile bufferLocation = RandomLocation(locationRoom);
				Boolean tileAvailable = true;
				
				
					// Check other locations and reassign bufferLocation until it is an available location.
					do{
						// Assume location is initially free.
						tileAvailable = true;
						foreach (Character character in locationRoom.occupants)
						{
							if (bufferLocation == character.location)
							{
								// If location not free, chooose another and check everybody again.
								bufferLocation = RandomLocation(locationRoom);
								tileAvailable = false;
								break;
							}
						}
					} while (!tileAvailable);
						
					// bufferLocation is available, so assign it.
					return bufferLocation;
				
			}
			
		}
}
