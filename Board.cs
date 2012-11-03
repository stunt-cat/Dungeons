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
		
		public Board()
		{
			// First create any Door(s)
			doors.Add(new Door());
			
			// Then create Room(s)
			rooms.Add(new Room(new Point(0,0), 1));
			rooms.Add(new Room(new Point(250,0), 1));
			          
			// Then initialise any Door(s) and update relevant Tiles in relevant Room(s) to point to it/them.
			doors[0].InitialiseDoor(rooms[0].tiles[5], Direction.East, rooms[1].tiles[4]);
			rooms[0].tiles[5].adjacencies[Direction.East] = doors[0];
			rooms[1].tiles[4].adjacencies[Direction.West] = doors[0];
		}
	}
}
