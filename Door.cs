﻿/*
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
	/// Represents a doorway link between two tiles, which may themselves not be adjacent.
	/// </summary>
	
	public class Door : ITileJoiner
	{
		public Boolean open = false;		// Refers to if door is open or closed.
		public Tile sideA;					// Side A is the location of the Door, for the purposes of 'Direction wallLocation'.
		public Tile sideB;					// Side B is 'back' image of Door. N.B. Does not have to be adjacent to Side A!
		public string imageRefSideA;		// Can be open or closed image.
		public string imageRefSideB;		// Is only ever 'back' image.
		public Direction wallLocation;			// Refers to side of Tile the door is on.
		
		// Door constructor is empty but Door is initialised with InitialiseDoor() method. This is so Room(s) and Door(s) can be created before referencing each other.
		public Door()
		{}
		
		public void InitialiseDoor(Tile sideA, Direction wallLocation, Tile sideB)
		{
			this.wallLocation = wallLocation;
			this.sideA = sideA;
			this.sideB = sideB;
			
			// Get correct image files for door, due to the wall it is located on.
			switch(wallLocation){
				case Direction.North:
					this.imageRefSideA = "door_n_closed";
					this.imageRefSideB = "door_s_back";
					break;
				case Direction.East:
					this.imageRefSideA = "door_e_closed";
					this.imageRefSideB = "door_w_back";
					break;
				case Direction.South:
					this.imageRefSideA = "door_s_closed";
					this.imageRefSideB = "door_n_back";
					break;
				case Direction.West:
					this.imageRefSideA = "door_w_closed";
					this.imageRefSideB = "door_e_back";
					break;
			}
		}
		
		// Method to open/shut door.
		public void OpenShut()
		{
			if (this.open == false)
			{
				this.open = true;
				switch(this.wallLocation){
					case Direction.North: this.imageRefSideA = "door_n_open"; break;
					case Direction.East: this.imageRefSideA = "door_e_open"; break;
					case Direction.South: this.imageRefSideA = "door_s_open"; break;
					case Direction.West: this.imageRefSideA = "door_w_open"; break;
				}
			} else
			{
				this.open = false;
				switch(this.wallLocation){
					case Direction.North: this.imageRefSideA = "door_n_closed"; break;
					case Direction.East: this.imageRefSideA = "door_e_closed"; break;
					case Direction.South: this.imageRefSideA = "door_s_closed"; break;
					case Direction.West: this.imageRefSideA = "door_w_closed"; break;
				}
			}
		}
		
		// Method to get Tile on other side of door
		public Tile OtherSide(Tile viewer)
		{
			if(viewer == sideA){
				return sideB;
			} else return sideA;
		}
		
	}
}
