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
			doors.Add(new Door());
			doors.Add(new Door());
			doors.Add(new Door());
			doors.Add(new Door());
			doors.Add(new Door());
			
			
			// Create any TileConnector(s)
			connectors.Add(new TileConnector());
			connectors.Add(new TileConnector());
			
			
			// Create Room(s)
			rooms.Add(new Room(new Point(0,0), 1));
			rooms.Add(new Room(new Point(2,2), 2));
			rooms.Add(new Room(new Point(6,4), 4));
			rooms.Add(new Room(new Point(8,6), 3));
			rooms.Add(new Room(new Point(3,7), 4));
			rooms.Add(new Room(new Point(-2,7), 4));
			rooms.Add(new Room(new Point(-6,7), 2));
			          
			
			// Initialise any Door(s) and update relevant Tiles in relevant Room(s) to point to it/them.
			doors[0].Initialise(rooms[0].tiles[7], Direction.East, rooms[1].tiles[4]);
			rooms[0].tiles[7].adjacencies[Direction.East] = doors[0];
			rooms[1].tiles[4].adjacencies[Direction.West] = doors[0];
			
			doors[1].Initialise(rooms[1].tiles[11], Direction.East, rooms[2].tiles[0]);
			rooms[1].tiles[11].adjacencies[Direction.East] = doors[1];
			rooms[2].tiles[0].adjacencies[Direction.West] = doors[1];
			
			doors[2].Initialise(rooms[2].tiles[8], Direction.South, rooms[3].tiles[1]);
			rooms[2].tiles[8].adjacencies[Direction.South] = doors[2];
			rooms[3].tiles[1].adjacencies[Direction.North] = doors[2];
			
			doors[3].Initialise(rooms[3].tiles[6], Direction.West, rooms[4].tiles[9]);
			rooms[3].tiles[6].adjacencies[Direction.West] = doors[3];
			rooms[4].tiles[9].adjacencies[Direction.East] = doors[3];
			
			doors[4].Initialise(rooms[5].tiles[0], Direction.West, rooms[6].tiles[3]);
			rooms[5].tiles[0].adjacencies[Direction.West] = doors[4];
			rooms[6].tiles[3].adjacencies[Direction.East] = doors[4];
			
			
			// Initialise any TileConnector(s) and update relevant Tiles in relevant Room(s) to reflect connection.
			connectors[0].Initialse(rooms[5].tiles[4], rooms[4].tiles[0]);
			rooms[5].tiles[4].adjacencies[Direction.East] = connectors[0];
			rooms[4].tiles[0].adjacencies[Direction.West] = connectors[0];
			
			connectors[1].Initialse(rooms[5].tiles[9], rooms[4].tiles[5]);
			rooms[5].tiles[9].adjacencies[Direction.East] = connectors[1];
			rooms[4].tiles[5].adjacencies[Direction.West] = connectors[1];
		}
	}
}
