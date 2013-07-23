/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 05/10/2012
 * Time: 09:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Dungeons
{
	/// <summary>
	/// Represents a doorway link between two tiles, which may themselves not be adjacent.
	/// </summary>
	
	public class Door : ITileJoiner
	{
		public Boolean open = false;		// Refers to if door is open or closed.
		public Tile sideA;					// Side A is the location of the Door, for the purposes of 'Direction wallLocation', which anchors the graphics.
		public Tile sideB;					// Side B is 'back' image of Door. N.B. Does not have to be adjacent to Side A!
		public string imageRefSideA;		// Can be open or closed image.
		public string imageRefSideB;		// Is only ever 'back' image.
		public Direction wallLocation;		// Refers to side of Tile the door is on.
		public List<Room> makesVisible;		// List of Rooms that switch to visible when Door opened (for first time only).
		
		// Door constructor is empty but Door is initialised with InitialiseDoor() method. This is so Room(s) and Door(s) can be created before referencing each other.
		public Door()
		{}
		
		public void Initialise(Tile sideA, Direction wallLocation, Tile sideB)
		{
			this.wallLocation = wallLocation;
			this.sideA = sideA;
			this.sideB = sideB;
			makesVisible = new List<Room>();
			
			// Get correct image files for door, due to the wall it is located on.
			switch(wallLocation)
			{
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
			
			// Update Tile adjacencies to reference Door.
			sideA.adjacencies[wallLocation] = this;
			sideB.adjacencies[Opposite(wallLocation)] = this;
		}
		
		// Method to find opposite Direction Enum, for Initialise().
		public Direction Opposite(Direction direction)
		{
			switch(direction)
			{
				case Direction.North: return Direction.South;
				case Direction.East: return Direction.West;
				case Direction.South: return Direction.North;
				case Direction.West: return Direction.East;
				
				default: return Direction.None;
			}
		}
		
		// Method to open/shut door.
		public void OpenShut(MainForm mf)
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
				// Update Rooms and Occupants that are now visible.
				foreach(Room room in makesVisible){
					room.visible = true;
					foreach(Character affectMe in room.occupants){
						mf.visibleBaddies.Add(affectMe);
						mf.remainingBaddies.Remove(affectMe);
					}
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
			if(viewer == sideA) return sideB;
			else return sideA;
		}
		
	}
}
