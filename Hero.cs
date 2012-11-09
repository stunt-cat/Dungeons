/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 06/03/2012
 * Time: 10:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;


namespace Dungeons
{
	/// <summary>
	/// Hero extends Character and represents the forces of good.
	/// </summary>
	public class Hero : Character
	{
		public int number;
		
		public Hero(Tile location, Direction facing, int number) : base (location, facing)
		{
			this.number = number;
			UpdateImageRef();
		}
		
		public void UpdateImageRef()
		{
			this.imageRef = string.Format("hero_{0}_{1}", this.facing.ToString().ToLower(), this.number.ToString());
		}
		
		public override void TurnLeft()
		{
			switch (this.facing)
			{
				case Direction.North: this.facing = Direction.West; break;
				case Direction.East: this.facing = Direction.North; break;
				case Direction.South: this.facing = Direction.East; break;
				case Direction.West: this.facing = Direction.South; break;
			}
			UpdateImageRef();
		}
		
		public override void TurnRight()
		{
			switch (this.facing)
			{
				case Direction.North: this.facing = Direction.East; break;
				case Direction.East: this.facing = Direction.South; break;
				case Direction.South: this.facing = Direction.West; break;
				case Direction.West: this.facing = Direction.North; break;
			}
			UpdateImageRef();
		}
	}
}
