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
		public string imageRef = "door_e_closed";
		public Tile location;
		public Direction wallLocation;			// Refers to side of Tile the door is on.		N.B. Is this necessary??
		
		public Tile OtherSide(Tile viewer)
		{
			if(viewer == sideA){
				return sideB;
			} else return sideA;
		}
		
		public Door(Tile location, Direction wallLocation, Tile sideA, Tile sideB)
		{
			this.location = location;
			this.wallLocation = wallLocation;
			this.sideA = sideA;
			this.sideB = sideB;
			
			// Get correct image file for door.
			switch(wallLocation){
				case Direction.North: this.imageRef = "door_n_closed"; break;
				case Direction.East: this.imageRef = "door_e_closed"; break;
				case Direction.South: this.imageRef = "door_s_closed"; break;
				case Direction.West: this.imageRef = "door_w_closed"; break;
			}
		}
		
		// Method to open/shut door.
		public void OpenShut()
		{
			if (this.open == false)
			{
				this.open = true;
				switch(this.wallLocation){
					case Direction.North: this.imageRef = "door_n_open"; break;
					case Direction.East: this.imageRef = "door_e_open"; break;
					case Direction.South: this.imageRef = "door_s_open"; break;
					case Direction.West: this.imageRef = "door_w_open"; break;
				}
			} else
			{
				this.open = false;
				switch(this.wallLocation){
					case Direction.North: this.imageRef = "door_n_closed"; break;
					case Direction.East: this.imageRef = "door_e_closed"; break;
					case Direction.South: this.imageRef = "door_s_closed"; break;
					case Direction.West: this.imageRef = "door_w_closed"; break;
				}
			}
		}
	}
}
