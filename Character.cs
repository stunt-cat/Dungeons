/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 08/03/2012
 * Time: 10:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace Dungeons
{
	
	public enum Direction {North, East, South, West};
	
	/// <summary>
	/// Character contains members common to both Hero and Baddie, which inherit from it.
	/// </summary>
	
	public abstract class Character
	{
		public Tile location;
		public Direction facing;
		
		public Character(Tile location, Direction facing)
		{
			this.location = location;
			this.facing = facing;
		}
	
		public void TurnLeft()
		{
			switch (this.facing)
			{
				case Direction.North: this.facing = Direction.West; break;
				case Direction.East: this.facing = Direction.North; break;
				case Direction.South: this.facing = Direction.East; break;
				case Direction.West: this.facing = Direction.South; break;
			}
		}
		
		public void TurnRight()
		{
			switch (this.facing)
			{
				case Direction.North: this.facing = Direction.East; break;
				case Direction.East: this.facing = Direction.South; break;
				case Direction.South: this.facing = Direction.West; break;
				case Direction.West: this.facing = Direction.North; break;
			}
		}
		
		public void NewFacing(Direction newFacing)
		{
			this.facing = newFacing;
		}
		
		public void MoveTo(ITileJoiner location){	// N.B. Does not have to be adjacent to current location!
			this.location = location;
		}
	}
}
