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
		}
		
		
	}
}
