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
using System.Collections.Generic;
using System.Resources;
using System.Windows.Forms;

namespace Dungeons
{
	public enum Stats {WS, BS, S, T, W};  // Represent Weapon Skill, Ballistic Skill, Strength, Toughness, Wounds, respectively
	/// <summary>
	/// Character contains members common to both Hero and Baddie, which inherit from it.
	/// </summary>
	
	public abstract class Character
	{
		public Tile location;
		public Direction facing;
		public string imageRef;
		public ResourceManager resources;
		public Graphics g;
		public Point origin;
		public int scale;
		public Dictionary <Stats, int> stats = new Dictionary<Stats, int>();
		
		public Character(Tile location, Direction facing, int ws, int bs, int s, int t, int w)
		{
			this.location = location;
			this.facing = facing;
			this.stats.Add(Stats.WS, ws);
			this.stats.Add(Stats.BS, bs);
			this.stats.Add(Stats.S, s);
			this.stats.Add(Stats.T, t);
			this.stats.Add(Stats.W, w);
		}
	
		public virtual void TurnLeft()
		{
			switch (this.facing)
			{
				case Direction.North: this.facing = Direction.West; break;
				case Direction.East: this.facing = Direction.North; break;
				case Direction.South: this.facing = Direction.East; break;
				case Direction.West: this.facing = Direction.South; break;
			}
		}
		
		public virtual void TurnRight()
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
		
		public void MoveTo(Tile location){	// N.B. Does not have to be adjacent to current location!
			this.location = location;
		}
		
		public void Draw(ResourceManager resources, Graphics g, Point origin, int scale)
		{
			this.resources = resources;
			this.g = g;
			this.origin = origin;
			this.scale = scale;
			
			g.DrawImage((Bitmap)resources.GetObject(this.imageRef),
			            new Rectangle((this.location.tileLocation.X*this.scale)+this.origin.X, (this.location.tileLocation.Y*this.scale)+this.origin.Y, this.scale, this.scale));
		}
	}
}
