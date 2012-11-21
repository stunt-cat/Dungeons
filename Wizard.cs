/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 21/11/2012
 * Time: 20:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Dungeons
{
	/// <summary>
	/// Wizard is a special Hero who can cast spells, but only in limited supply.
	/// </summary>
	public class Wizard : Hero
	{
		public int spellAffectAllRemaining;
		public int spellExplodeRemaining;
			
		public Wizard(Tile location, Direction facing, int ws, int bs, int s, int t, int w, HeroType type)
			: base (location, facing, ws, bs, s, t, w, type)
		{
			this.spellAffectAllRemaining = 2;
			this.spellExplodeRemaining = 2;
		}
		
	}
}
