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
	public enum HeroType{Elf, Warrior, Dwarf, Wizard};
	
	/// <summary>
	/// Hero extends Character and represents the forces of good.
	/// </summary>
	public class Hero : Character
	{
		public HeroType type;
		
		public Hero(Tile location, Direction facing, int ws, int bs, int s, int t, int w, HeroType type) 
			: base (location, facing, ws, bs, s, t, w)
		{
			this.type = type;
			UpdateImageRef();
		}
		
		public void UpdateImageRef()
		{
			this.imageRef = string.Format("hero_{0}_{1}", this.type.ToString().ToLower(), this.facing.ToString().ToLower());
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
