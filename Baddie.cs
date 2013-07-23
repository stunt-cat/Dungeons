/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 08/03/2012
 * Time: 11:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace Dungeons
{
	/// <summary>
	/// Baddie extends Character and represents the forces of evil.
	/// </summary>
	/// 
	public class Baddie : Character
	{
		public Boolean visible;
		
		public Baddie(Tile location, Direction facing, int ws, int bs, int s, int t, int w)
			: base (location, facing, ws, bs, s, t, w)
		{
			this.imageRef = "baddie";
		}
		
	}
}
