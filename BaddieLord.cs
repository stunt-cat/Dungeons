/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 23/11/2012
 * Time: 16:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Dungeons
{
	/// <summary>
	/// Description of BaddieLord.
	/// </summary>
	public class BaddieLord : Baddie
	{
		public BaddieLord(Tile location, Direction facing, int ws, int bs, int s, int t, int w)
			: base (location, facing, ws, bs, s, t, w)
		{
			this.imageRef = "baddie_lord";
		}
	}
}
