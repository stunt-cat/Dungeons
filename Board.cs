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
	/// Currently, Board must be manually set up to choose the playing area, by selecting which rooms are requrired
	/// and where the doors are (and where they connect).
	/// </summary>
	
	public class Board
	{
		public List<Door> doors = new List<Door>();
		public List<Room> rooms = new List<Room>();
		public List<TileConnector> connectors = new List<TileConnector>();
		
		public Board()
		{
			// Create any Door(s)
			for (int i=0; i<6; i++)
			{
				doors.Add(new Door());
			}
			
			// Create any TileConnector(s)
			for (int i=0; i<8; i++)
			{
				connectors.Add(new TileConnector());
			}
			
			// Create Room(s)
			rooms.Add(new Room(new Point(0,0), 1));
			rooms.Add(new Room(new Point(2,2), 2));
			rooms.Add(new Room(new Point(6,4), 4));
			rooms.Add(new Room(new Point(8,6), 3));
			rooms.Add(new Room(new Point(3,7), 4));
			rooms.Add(new Room(new Point(-2,7), 4));
			rooms.Add(new Room(new Point(-6,7), 2));
			rooms.Add(new Room(new Point(4,9), 1));
			rooms.Add(new Room(new Point(3,14), 2));
			rooms.Add(new Room(new Point(-1,14), 2));
			          
			// Initialise any Door(s). N.B. This updates relevant Tiles in relevant Rooms to point to it/them.
			doors[0].Initialise(rooms[0].tiles[7], Direction.East, rooms[1].tiles[4]);
			doors[1].Initialise(rooms[1].tiles[11], Direction.East, rooms[2].tiles[0]);
			doors[2].Initialise(rooms[2].tiles[8], Direction.South, rooms[3].tiles[1]);
			doors[3].Initialise(rooms[3].tiles[6], Direction.West, rooms[4].tiles[9]);
			doors[4].Initialise(rooms[5].tiles[0], Direction.West, rooms[6].tiles[3]);
			doors[5].Initialise(rooms[7].tiles[8], Direction.South, rooms[8].tiles[1]);
			
			// Initialise any TileConnector(s). N.B. This updates relevant Tiles in relevant Rooms to point to it/them.
			connectors[0].Initialse(rooms[5].tiles[4], Direction.East, rooms[4].tiles[0]);
			connectors[1].Initialse(rooms[5].tiles[9], Direction.East, rooms[4].tiles[5]);
			connectors[2].Initialse(rooms[4].tiles[6], Direction.South, rooms[7].tiles[0]);
			connectors[3].Initialse(rooms[4].tiles[7], Direction.South, rooms[7].tiles[1]);
			connectors[4].Initialse(rooms[9].tiles[3], Direction.East, rooms[8].tiles[0]);
			connectors[5].Initialse(rooms[9].tiles[7], Direction.East, rooms[8].tiles[4]);
			connectors[6].Initialse(rooms[9].tiles[11], Direction.East, rooms[8].tiles[8]);
			connectors[7].Initialse(rooms[9].tiles[15], Direction.East, rooms[8].tiles[12]);
		}
	}
}
