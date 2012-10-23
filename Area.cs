/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 05/10/2012
 * Time: 10:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Dungeons
{
	/// <summary>
	/// Abstract base class for Board components.
	/// </summary>
	public abstract class Area
	{
		List<Tile> tiles = new List<Tile>();
		Dictionary<Dungeons.Tile, Dungeons.Character> occupants = new Dictionary<Dungeons.Tile, Dungeons.Character>();
		
		public Area()
		{
			
		}
	}
}
