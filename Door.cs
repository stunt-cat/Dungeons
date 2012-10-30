/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 05/10/2012
 * Time: 09:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Dungeons
{
	/// <summary>
	/// Represents a link between two tiles, which may themselves not be adjacent.
	/// </summary>
	
	public class Door : ITileJoiner
	{
		public Boolean open = false;		// Refers to if door is open or closed.
		private Tile sideA;
		private Tile sideB;
		private string imageRef;
		private Direction location;			// Refers to side of Tile the door is on.		N.B. Is this necessary??
		
		public Tile OtherSide(ITileJoiner viewer)
		{
			if(viewer == sideA){
				return sideB;
			} else return sideA;
		}
		
		public Door(Direction location, Tile sideA, Tile sideB)
		{
			this.location = location;
			this.sideA = sideA;
			this.sideB = sideB;
			
			// Get correct image file for door.
			switch(location){
				case Direction.North: imageRef = "door_n_closed.gif"; break;
				case Direction.East: imageRef = "door_e_closed.gif"; break;
				case Direction.South: imageRef = "door_s_closed.gif"; break;
				case Direction.West: imageRef = "door_w_closed.gif"; break;
			}
		}
		
		// Method to open/shut door.
		public Boolean OpenShut()
		{
			if (open == false)
			{
				open = true;
				switch(location){
					case Direction.North: imageRef = "door_n_open.gif"; break;
					case Direction.East: imageRef = "door_e_open.gif"; break;
					case Direction.South: imageRef = "door_s_open.gif"; break;
					case Direction.West: imageRef = "door_w_open.gif"; break;
				}
			} else
			{
				open = false;
				switch(location){
					case Direction.North: imageRef = "door_n_closed.gif"; break;
					case Direction.East: imageRef = "door_e_closed.gif"; break;
					case Direction.South: imageRef = "door_s_closed.gif"; break;
					case Direction.West: imageRef = "door_w_closed.gif"; break;
				}
			}
			//TODO redraw door
					return open;
		}
	}
}
