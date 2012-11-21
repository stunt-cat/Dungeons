/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 05/10/2012
 * Time: 09:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace Dungeons
{
	public enum Direction {North, East, South, West, None}; // 'None' is used for default cases in the Opposite() in TileConnector and Door.
	
	/// <summary>
	/// Tile represents the smallest divisor of area on the game Board.
	/// It should have one or zero occupants, but there are no explicit checks for this!
	/// It can have adjacent Tiles (which may be in other Rooms), adjacent Doors or TileConnectors. N.B. these deal with which Tiles they connect!
	/// DrawTile() creates the graphics for the Tile, including adjacent walls or Doors.
	/// </summary>
	
	public enum TileType {clear, water, trap};
	
	public class Tile : ITileJoiner
	{
		public Dictionary <Direction, ITileJoiner> adjacencies = new Dictionary <Direction, ITileJoiner>();
		public Point tileLocation = new Point(0,0);			// Locates Tile w.r.t. game area origin.
		public string imageRef;								// Basic image for Tile
		public TileType type;
		public ResourceManager resources;
		public Graphics g;
		public Point origin;
		public int scale;
		
		public Tile(Point offset){
			this.tileLocation = offset;						// Adds room origin location to point locations.
		}
		
		public void Initialise(TileType type, Point tileLocationOffset, string imageRef, ITileJoiner north, ITileJoiner east, ITileJoiner south, ITileJoiner west)
		{
			this.type = type;
			tileLocation.Offset(tileLocationOffset);
			this.imageRef = imageRef;
			this.adjacencies.Add(Direction.North, north);
			this.adjacencies.Add(Direction.East, east);
			this.adjacencies.Add(Direction.South, south);
			this.adjacencies.Add(Direction.West, west);
		}
		
		
		// Method to find out which Tile, if any, is adjacent to the one in question.
		// Returns null if there is no adjacent Tile.
		// N.B. It can return an occupied Tile!!.
		public Tile Adjacent(Direction intendedDirection)
		{
			ITileJoiner potentialAdjacent = this.adjacencies[intendedDirection];
			
			if(potentialAdjacent != null)
			{
				if(potentialAdjacent is Tile) return (Tile)potentialAdjacent;
				if(potentialAdjacent is Door)
				{
					Door door = (Door)potentialAdjacent;
					// If Door open, return Tile on the other side.
					if (door.open) return door.OtherSide(this);
				}
				if(potentialAdjacent is TileConnector)
				{
					TileConnector connector = (TileConnector)potentialAdjacent;
					return connector.OtherSide(this);
				}
			}
			return null; // There is no adjacent move.
		}
		
		// Method to draw Tile. Also draws correct perimiter artifacts i.e. wall, Door (open/closed).
		public void Draw(ResourceManager resources, Graphics g, Point origin, int scale)
		{
			this.resources = resources;
			this.g = g;
			this.origin = origin;
			this.scale = scale;
			
			g.DrawImage((Bitmap)resources.GetObject(this.imageRef), new Rectangle((this.tileLocation.X*this.scale)+this.origin.X, (this.tileLocation.Y*this.scale)+this.origin.Y, this.scale, this.scale));
				
			// Draw wall images as necessary over the Tile base image.
			if(this.adjacencies[Direction.North] == null)
			{
				g.DrawImage((Bitmap)resources.GetObject("tileWallN"), new Rectangle((this.tileLocation.X*this.scale)+this.origin.X, (this.tileLocation.Y*this.scale)+this.origin.Y, this.scale, this.scale));
			}
			
			if(this.adjacencies[Direction.East] == null)
			{
				g.DrawImage((Bitmap)resources.GetObject("tileWallE"), new Rectangle((this.tileLocation.X*this.scale)+this.origin.X, (this.tileLocation.Y*this.scale)+this.origin.Y, this.scale, this.scale));
			}
			
			if(this.adjacencies[Direction.South] == null)
			{
				g.DrawImage((Bitmap)resources.GetObject("tileWallS"), new Rectangle((this.tileLocation.X*this.scale)+this.origin.X, (this.tileLocation.Y*this.scale)+this.origin.Y, this.scale, this.scale));
			}
			
			if(this.adjacencies[Direction.West] == null)
			{
				g.DrawImage((Bitmap)resources.GetObject("tileWallW"), new Rectangle((this.tileLocation.X*this.scale)+this.origin.X, (this.tileLocation.Y*this.scale)+this.origin.Y, this.scale, this.scale));
			}
			
			
			// Draw door images as necessary over the Tile base images. N.B. There is a front and a back image for each Door.
			
			if(this.adjacencies[Direction.North] is Door)
			{
				// See if front or back image is required.
				if((this.adjacencies[Direction.North] as Door).sideA == this) // tile is location of Door, so front image required.
				{			
					g.DrawImage((Bitmap)resources.GetObject((this.adjacencies[Direction.North] as Door).imageRefSideA), 
					            new Rectangle((this.tileLocation.X*this.scale)+this.origin.X, (this.tileLocation.Y*this.scale)+this.origin.Y, this.scale, this.scale));
				} 
				else   // tile is not location of Door, so back image required.
				{																							
					g.DrawImage((Bitmap)resources.GetObject((this.adjacencies[Direction.North] as Door).imageRefSideB), 
					            new Rectangle((this.tileLocation.X*this.scale)+this.origin.X, (this.tileLocation.Y*this.scale)+this.origin.Y, this.scale, this.scale));
				}
			}
			
			if(this.adjacencies[Direction.East] is Door)
			{
				// See if front or back image is required.
				if((this.adjacencies[Direction.East] as Door).sideA == this) // tile is location of Door, so front image required.
				{			
					g.DrawImage((Bitmap)resources.GetObject((this.adjacencies[Direction.East] as Door).imageRefSideA), 
					            new Rectangle((this.tileLocation.X*this.scale)+this.origin.X, (this.tileLocation.Y*this.scale)+this.origin.Y, this.scale, this.scale));
				} 
				else   // tile is not location of Door, so back image required.
				{																							
					g.DrawImage((Bitmap)resources.GetObject((this.adjacencies[Direction.East] as Door).imageRefSideB), 
					            new Rectangle((this.tileLocation.X*this.scale)+this.origin.X, (this.tileLocation.Y*this.scale)+this.origin.Y, this.scale, this.scale));
				}
			}
			
			if(this.adjacencies[Direction.South] is Door)
			{
				// See if front or back image is required.
				if((this.adjacencies[Direction.South] as Door).sideA == this) // tile is location of Door, so front image required.
				{			
					g.DrawImage((Bitmap)resources.GetObject((this.adjacencies[Direction.South] as Door).imageRefSideA), 
					            new Rectangle((this.tileLocation.X*this.scale)+this.origin.X, (this.tileLocation.Y*this.scale)+this.origin.Y, this.scale, this.scale));
				} 
				else   // tile is not location of Door, so back image required.
				{																							
					g.DrawImage((Bitmap)resources.GetObject((this.adjacencies[Direction.South] as Door).imageRefSideB), 
					            new Rectangle((this.tileLocation.X*this.scale)+this.origin.X, (this.tileLocation.Y*this.scale)+this.origin.Y, this.scale, this.scale));
				}
			}
			
			if(this.adjacencies[Direction.West] is Door)
			{
				// See if front or back image is required.
				if((this.adjacencies[Direction.West] as Door).sideA == this) // tile is location of Door, so front image required.
				{			
					g.DrawImage((Bitmap)resources.GetObject((this.adjacencies[Direction.West] as Door).imageRefSideA), 
					            new Rectangle((this.tileLocation.X*this.scale)+this.origin.X, (this.tileLocation.Y*this.scale)+this.origin.Y, this.scale, this.scale));
				} 
				else   // tile is not location of Door, so back image required.
				{																							
					g.DrawImage((Bitmap)resources.GetObject((this.adjacencies[Direction.West] as Door).imageRefSideB), 
					            new Rectangle((this.tileLocation.X*this.scale)+this.origin.X, (this.tileLocation.Y*this.scale)+this.origin.Y, this.scale, this.scale));
				}
			}
		}
	}
}
