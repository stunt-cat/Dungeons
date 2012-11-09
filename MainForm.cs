/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 24/02/2012
 * Time: 15:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
using System.Timers;
using System.Linq;

namespace Dungeons
{
	public enum Direction {North, East, South, West, None}; // 'None' is used for default cases in the Opposite() in TileConnector and Door.
	
	/// <summary>
	/// MainForm is where all the jazz goes down.
	/// </summary>
	

	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//	
		}
		
		// list populated in StartButtonClick(), from user parameters
		public List<Character> heroes;
		Hero activeHero;
		int numberOfHeroes;
		
		// list populated in StartButtonClick(), from user parameters
		public List<Character> baddies;
		Baddie activeBaddie;
		int numberOfBaddies;
		public Direction baddieMoveDirection;
		
		public IEnumerable<Character> everybody;
		public Tile shotLocation;
		public Character shotVictim;
		
		// origin is the root of all graphics locations.
		// initialOrigin is used for resetting graphics area with scrollResetButton.
		public Point initialOrigin;
		public Point origin;
		
		// Create Board for action to take place in
		public Board board;
		
		// Lists to help with minimising redraw after something happens e.g. movement, open/close door, fight
		public List<Tile> tilesForRedraw = new List<Tile>();
		public List<Character> charactersForRedraw = new List<Character>();
		
		// Set scale for Board - N.B. All graphics are initially 100x100 pixels.
		// Currently starting at default of 25% to accommodate trial Board
		public int scale = 25;
	
		ResourceManager resources = new ResourceManager("Dungeons.images", Assembly.GetExecutingAssembly());
		public System.Drawing.Graphics g;
		
		public int score = 0;
		Random random = new Random();
		
		
		void StartButtonClick(object sender, EventArgs e)
		{
			// Get numberOfBaddies from RadioBox in baddieSelectorPanel.
			if (baddieSelectorButton1.Checked) numberOfBaddies = 1;
			else if (baddieSelectorButton2.Checked) numberOfBaddies = 2;
			else if (baddieSelectorButton3.Checked) numberOfBaddies = 3;
			else if (baddieSelectorButton4.Checked) numberOfBaddies = 4;
			else if (baddieSelectorButton5.Checked) numberOfBaddies = 5;
			else if (baddieSelectorButton6.Checked) numberOfBaddies = 6;
			else if (baddieSelectorButton7.Checked) numberOfBaddies = 7;
			else if (baddieSelectorButton8.Checked) numberOfBaddies = 8;
			
			baddies = new List<Character>(numberOfBaddies);
			
			// Get numberOfHeroes from RadioBox in heroSelectorPanel.
			if (heroSelectorButton1.Checked) numberOfHeroes = 1;
			else if (heroSelectorButton2.Checked) numberOfHeroes = 2;
			else if (heroSelectorButton3.Checked) numberOfHeroes = 3;
			else if (heroSelectorButton4.Checked) numberOfHeroes = 4;
			
			heroes = new List<Character>(numberOfHeroes);
			
			// Create board.
			// N.B. All Points are in abstract integer sizes to relate each Room/Tile to each other.
			// 		These sizes are converted to actual pixels in DrawLocation().
			initialOrigin = new Point(7*scale,0*scale);	//N.B. Origin is currently selected to display trial board centered in graphics window!;
			origin = initialOrigin;
			board = new Board();
			
			// Randomly select hero start point(s), ensuring there are no conflicts with other heroes (N.B. no baddies exist at this point).
			for (int i = 0; i < numberOfHeroes; i++)
			{
				Tile bufferLocation = RandomLocation();
				Boolean tileAvailable = true;
				
				// Check other Hero locations and reassign bufferLocation until it is an available location.
					do{
						// Assume location is initially free
						tileAvailable = true;
						foreach (Character hero in heroes)
						{
							if (bufferLocation == hero.location)
							{
								// If location not free, choose another and check everybody again.
								bufferLocation = RandomLocation();
								tileAvailable = false;
								break;
							}
						}
					} while (!tileAvailable);	
				
				// bufferLocation is available, so assign it to new Hero
				heroes.Add(new Hero (bufferLocation, (Direction) random.Next(4), i+1));
			}
			
			// Randomly select baddie start point(s), ensuring there are no conflicts with heroes or other baddies
			AssignBaddieLocations();
			
			// Assign active hero (green/1)
			activeHero = (Hero) heroes[0];
			
			// Start timer.
			gameClock.Start();
			gameClock.Tick += new EventHandler(GameTimeUp);
			
			// Set up GUI controls.
			ResetGame();
			
		}

		// This method is called from multiple locations, so is not part of StartButtonClick() (unlike Hero location assignment)
		void AssignBaddieLocations()
			{
			// Only assigns location if it is not occupied already by hero or preceding baddie
			for (int i = 0; i < numberOfBaddies; i++) {
				
				Tile bufferLocation = RandomLocation();
				Boolean tileAvailable = true;
				IEnumerable<Character> everybody = heroes.Concat(baddies);
				
				// Check other locations and reassign bufferLocation until it is an available location
				do{
					// Assume location is initially free
					tileAvailable = true;
					foreach (Character anybody in everybody)
					{
						if (bufferLocation == anybody.location)
						{
							// If location not free, chooose another and check everybody again
							bufferLocation = RandomLocation();
							tileAvailable = false;
							break;
						}
					}
				} while (!tileAvailable);
					
				// bufferLocation is available, so assign it to new Baddie
				baddies.Add(new Baddie (bufferLocation, (Direction)random.Next(4)));
			}
		}
		
		public Tile RandomLocation()
		{
			Room randomRoom = board.rooms[random.Next(board.rooms.Count)];
			Tile randomTile = randomRoom.tiles[random.Next(randomRoom.tiles.Count)];
			return randomTile;
		}
		
		void ResetGame()
		{
			baddieSelectorPanel.Visible = false;
			heroesSelectorPanel.Visible = false;
			gameOverButton.Visible = false;
			startButton.Visible = false;
			scrollGroupBox.Visible = true;
			scaleSelectorPanel.Visible = true;
			controlsGroupBox.Visible = true;
			controlsGroupBox.Enabled = true;
			drawHeroSelectorButtons(numberOfHeroes);	
			DrawLocation();
			DrawCharacter();
		}
		
		private void drawHeroSelectorButtons(int i)
		{
			// Display correct active hero selector buttons for number of heroes
			switch (i)
			{	
				case 1 : break;
				case 2 : activateHeroButton1.Visible = true;
				activateHeroButton1.Enabled = true;
				activateHeroButton2.Visible = true;
				activateHeroButton2.Enabled = true;
				break;
				
				case 3 : 
				activateHeroButton3.Visible = true;
				activateHeroButton3.Enabled = true;
				goto case 2;
				
				case 4: 
				activateHeroButton4.Visible = true;
				activateHeroButton4.Enabled = true;
				goto case 3;
			}
		}
		
		// Method to draw entire board.
		private void DrawLocation()
		{
			pictureBox1.Refresh();
			g = pictureBox1.CreateGraphics();
			
			// Draw Room(s)
			foreach (Room room in board.rooms)
			{
				foreach (Tile tile in room.tiles)
				{
					tile.Draw(resources, g, origin, scale);
				}
			}
			
			// Draw all Characters on the board.
			DrawCharacter();
		}
		
		// Overloaded method to only draw specified Tile(s).
		private void DrawLocation(List<Tile> tilesForRedraw)
		{
			foreach(Tile tile in tilesForRedraw)
			{
				tile.Draw(resources, g, origin, scale);
			}
			
			// Clear List for next use.
			tilesForRedraw.Clear();
		}
		
		// Method to draw all characters.
		private void DrawCharacter()
		{
			everybody = heroes.Concat(baddies);
			
			foreach (Character anybody in everybody)
			{
				anybody.Draw(resources, g, origin, scale);
			}                             
		}
		
		// Method to only draw specified Character(s).
		private void DrawCharacter(List<Character> charactersForRedraw)
		{
			foreach (Character character in charactersForRedraw)
			{
				character.Draw(resources, g, origin, scale);
			}
			
			// Clear list for next use.
			charactersForRedraw.Clear();
		}
		
		void ActivateHeroButton1Click(object sender, EventArgs e)
		{
			leftTurnButton.Image = global::Dungeons.Images.arrow_leftturn_1;
			rightTurnButton.Image = global::Dungeons.Images.arrow_rightturn_1;
			forwardButton.Image = global::Dungeons.Images.arrow_north_1;
			activeHero = (Hero) heroes[0];
		}
		
		void ActivateHeroButton2Click(object sender, EventArgs e)
		{
			leftTurnButton.Image = global::Dungeons.Images.arrow_leftturn_2;
			rightTurnButton.Image = global::Dungeons.Images.arrow_rightturn_2;
			forwardButton.Image = global::Dungeons.Images.arrow_north_2;
			activeHero = (Hero) heroes[1];
		}
		
		void ActivateHeroButton3Click(object sender, EventArgs e)
		{
			leftTurnButton.Image = global::Dungeons.Images.arrow_leftturn_3;
			rightTurnButton.Image = global::Dungeons.Images.arrow_rightturn_3;
			forwardButton.Image = global::Dungeons.Images.arrow_north_3;
			activeHero = (Hero) heroes[2];
		}

		void ActivateHeroButton4Click(object sender, EventArgs e)
		{
			leftTurnButton.Image = global::Dungeons.Images.arrow_leftturn_4;
			rightTurnButton.Image = global::Dungeons.Images.arrow_rightturn_4;
			forwardButton.Image = global::Dungeons.Images.arrow_north_4;
			activeHero = (Hero) heroes[3];
		}
		
		void ForwardButtonClick(object sender, System.EventArgs e)
		
		{
			Tile moveTarget = activeHero.location.Adjacent(activeHero.facing);
			Boolean directionProblem = false;
			everybody = heroes.Concat(baddies);
			
			// Check there is an adjacent Tile (could be occupied at this point).
			if(moveTarget == null)
			{
				directionProblem = true;
			}
			
			else
			{
				// Check to see if the tile is occupied.
				foreach(Character anybody in everybody)
				{
					if(anybody.location == moveTarget)
					{
						directionProblem = true;
						break;
					}
				}
			}
			
			// Resolve move.
			if(directionProblem)
			{				// Problem of some sort - inform user.
				OutOfBounds();
			}
			
			else
			{
				// Invalidate areas of graphics to be redrawn (activeHero's current location and intended location).
				pictureBox1.Invalidate(new Rectangle((activeHero.location.tileLocation.X*scale)+origin.X, (activeHero.location.tileLocation.Y*scale)+origin.Y, scale, scale));
				pictureBox1.Invalidate(new Rectangle((moveTarget.tileLocation.X*scale)+origin.X, (moveTarget.tileLocation.Y*scale)+origin.Y, scale, scale));
				// Add tiles and character to redraw lists.
				tilesForRedraw.Add(activeHero.location);
				tilesForRedraw.Add(moveTarget);
				charactersForRedraw.Add(activeHero);
				
				// Move is now fine to execute!
				activeHero.MoveTo(moveTarget);
				
				// Possibly also move Baddies, 50% chance of running method.
				if(random.Next(2) == 0)
				{
					MoveBaddie();
				}
				
				// Redraw invalidated regions and redraw activeHero i.e. update Hero location graphically.
				pictureBox1.Update();
				DrawLocation(tilesForRedraw);
				DrawCharacter(charactersForRedraw);
			}
		}
		
		void MoveBaddie()
		{
			// N.B. Baddies only have one chance to move - if the baddieMoveDirection turns out to not be possible
			// 		the baddie doesn't move i.e. they don't get to keep trying directions until they can move.
			
			// TODO Add some AI to the baddie/baddies so they move more intelligently!
			// Currently the MoveBaddie() routine copies the Hero movement one - this will change when Baddies have brains..
			
			everybody = heroes.Concat(baddies);
			
			foreach (Baddie movingBaddie in baddies)
			{
				Boolean directionProblem = false;
				
				// Choose random direction for baddie move.
				baddieMoveDirection = (Direction)(random.Next(4));
				
				// Get adjacent tile in chosen (random) direction.
				Tile moveTarget = movingBaddie.location.Adjacent(baddieMoveDirection);
				
				// <start> CODE FROM HERO MOVEMENT
				// Check there is an adjacent Tile (could be occupied at this point).
				if(moveTarget == null){
					directionProblem = true;
				} else {
					// Check to see if the tile is occupied.
					foreach(Character anybody in everybody){
						if(anybody.location == moveTarget){
							directionProblem = true;
							break;
						}
					}
				}
				// <end> CODE FROM HERO MOVEMENT
				
				if(!directionProblem)		// N.B. If directionProblem=true movingBaddie doesn't move or change facing.
				{
					// Invalidate areas of graphics to be redrawn (baddie's current location and intended location).
					pictureBox1.Invalidate(new Rectangle((movingBaddie.location.tileLocation.X*scale)+origin.X, (movingBaddie.location.tileLocation.Y*scale)+origin.Y, scale, scale));
					//pictureBox1.Invalidate(new Rectangle((moveTarget.tileLocation.X*scale)+origin.X, (moveTarget.tileLocation.Y*scale)+origin.Y, scale, scale));
					
					// Add tile to redraw list.
					tilesForRedraw.Add(movingBaddie.location);
					// Add character to redraw list.
					charactersForRedraw.Add(movingBaddie);
					
					// Move is okay to execute!
					movingBaddie.MoveTo(moveTarget);
					// Update movingBaddie facing to reflect completed move.
					movingBaddie.NewFacing(baddieMoveDirection);
				} 
			}
				
				// Redraw invalidated regions i.e. update all locations graphically for the baddies who moved.
				pictureBox1.Update();
				DrawLocation(tilesForRedraw);
				DrawCharacter(charactersForRedraw);
		}
		
		private void OutOfBounds()
		{
			outOfBoundsButton.Visible = true;
			controlsGroupBox.Enabled = false;
		}
		
		void OutOfBoundsButtonClick(object sender, System.EventArgs e)
		{
			outOfBoundsButton.Visible = false;
			controlsGroupBox.Enabled = true;
			//DrawLocation();
		}
		
		void LeftTurnButtonClick(object sender, EventArgs e)
		{
			activeHero.TurnLeft();
			
			// Invalidate areas of graphics to be redrawn - activeHero's current location.
			pictureBox1.Invalidate(new Rectangle((activeHero.location.tileLocation.X*scale)+origin.X, (activeHero.location.tileLocation.Y*scale)+origin.Y, scale, scale));
			// Add tile and activeHero to redraw list.
			tilesForRedraw.Add(activeHero.location);
			charactersForRedraw.Add(activeHero);
			
			pictureBox1.Update();
			DrawLocation(tilesForRedraw);
			DrawCharacter(charactersForRedraw);
		}
		
		void RightTurnButtonClick(object sender, EventArgs e)
		{
			activeHero.TurnRight();
			
			// Invalidate areas of graphics to be redrawn - activeHero's current location.
			pictureBox1.Invalidate(new Rectangle((activeHero.location.tileLocation.X*scale)+origin.X, (activeHero.location.tileLocation.Y*scale)+origin.Y, scale, scale));
			// Add tile and activeHero to redraw list.
			tilesForRedraw.Add(activeHero.location);
			charactersForRedraw.Add(activeHero);
			
			pictureBox1.Update();
			DrawLocation(tilesForRedraw);
			DrawCharacter(charactersForRedraw);
		}
		
		void FightButtonClick(object sender, System.EventArgs e)
		{
			controlsGroupBox.Enabled = false;
			
			// Find if there is a baddie adjacent to activeHero, and if so set activeBaddie to it.
			activeBaddie = null;
			Tile attackLocation = null;
			
			// If there is an adjacent Tile set attackLocation to it.
			switch(activeHero.facing){
				case Direction.North: if(activeHero.location.Adjacent(Direction.North) != null){
						attackLocation = activeHero.location.Adjacent(Direction.North);
					} break;
				case Direction.East : if(activeHero.location.Adjacent(Direction.East) != null){
						attackLocation = activeHero.location.Adjacent(Direction.East);
					} break;
				case Direction.South : if(activeHero.location.Adjacent(Direction.South) != null){
						attackLocation = activeHero.location.Adjacent(Direction.South);
					} break;
				case Direction.West : if(activeHero.location.Adjacent(Direction.West) != null){
						attackLocation = activeHero.location.Adjacent(Direction.West);
					} break;
			}
			
			// If attackLocation exists see who is in it. If nobody, fight is over.
			if (attackLocation !=null){
				foreach (Baddie baddie in baddies){
					if(baddie.location == attackLocation){
						activeBaddie = baddie;
						break;
					}
				}
			} else failedFightButton.Visible = true;
			
			// If there is a baddie infront of activeHero, kill it
			if (activeBaddie !=null)
			{
				successfulFightButton.Visible = true;
				this.score += 5;
				scoreTextBox.Clear();
				scoreTextBox.Text = score.ToString();
		
				// Draw dead baddie, with wide-lined red square round!
				g.DrawImage((Bitmap) resources.GetObject("dead_baddie"), 
				            new Rectangle((activeBaddie.location.tileLocation.X*scale)+origin.X, (activeBaddie.location.tileLocation.Y*scale)+origin.Y, scale, scale));
				g.DrawImage((Bitmap) resources.GetObject("square_red"), 
				            new Rectangle((activeBaddie.location.tileLocation.X*scale)+origin.X, (activeBaddie.location.tileLocation.Y*scale)+origin.Y, scale, scale));
				
				// Remove baddie from baddies and add activeBaddie and activeBaddie.location to redraw lists.
				baddies.Remove(activeBaddie);
				charactersForRedraw.Add(activeBaddie);
				tilesForRedraw.Add(activeBaddie.location);
				
			} else failedFightButton.Visible = true;
		}
		
		void SuccessfulFightButtonClick(object sender, EventArgs e)
		{
			successfulFightButton.Visible = false;
			if (baddies.Count == 0)
			{
				// Get more baddies! N.B. same number as initial user selection
				AssignBaddieLocations();
				// Add new baddies to redraw list.
				foreach(Baddie baddie in baddies)
				{
					charactersForRedraw.Add(baddie);
				}
			}
			
			controlsGroupBox.Enabled = true;
			DrawCharacter(charactersForRedraw);
			DrawLocation(tilesForRedraw);
		}
		
		
		void FailedFightButtonClick(object sender, EventArgs e)
		{
			failedFightButton.Visible = false;
			controlsGroupBox.Enabled = true;
			DrawLocation(tilesForRedraw);
			if(charactersForRedraw.Count != 0)
			{
				DrawCharacter(charactersForRedraw);
			}
		}
		
		void RangedCombatButtonClick(object sender, EventArgs e){
			// This is just a dummy while I work out how to do it again..
			
			// See if there is an adjacent Tile in activeHero.facing direction, next to activeHero.location
			//   if (adjacent = null), fail shot
			//	 if (adjacent != null) see who is in location
			//   	if(nobody) continue shot
			//		if baddie, kill it
			//		if hero, fail shot
			
			shotLocation = activeHero.location;
			Boolean shotOver = false;
			activeBaddie = null;
			shotVictim = null;
			everybody = heroes.Concat(baddies);
			
			// Shoot in straight line until hit wall or other Character. If Character encountered, decide outcome based on Type.
			
			while (!shotOver){
				if(shotLocation.Adjacent(activeHero.facing) == null) shotOver = true;
				else
				{
					shotLocation = shotLocation.Adjacent(activeHero.facing);
					foreach(Character potentialVictim in everybody)
					{
						if(potentialVictim.location == shotLocation)
						{
							shotVictim = potentialVictim;
							shotOver = true;
							break;
						}
					}
					// Draw a square round the location to show it is the shot path, and add to redraw list
					g.DrawImage((Bitmap) resources.GetObject("square_blue"),
				            new Rectangle((shotLocation.tileLocation.X*scale)+origin.X, (shotLocation.tileLocation.Y*scale)+origin.Y, scale, scale));
					tilesForRedraw.Add(shotLocation);
				}
			}
			
			// If there is a shotVictim, check its type. If if it a Baddie, kill it! If it is a Hero, shot does nothing.
			if(shotVictim != null)
			{
				if (shotVictim.GetType() != activeHero.GetType())
				{
					activeBaddie = (Baddie) shotVictim;
					KillShot();
				}
				else
				{
					// shotVictim is a Hero, so add to redraw list.
					charactersForRedraw.Add(shotVictim);
					FailShot();
				}
			}
			else FailShot();
		}
		
		void KillShot()
		{
			g.DrawImage((Bitmap) resources.GetObject("dead_baddie"), 
			            new Rectangle((activeBaddie.location.tileLocation.X*scale)+origin.X, (activeBaddie.location.tileLocation.Y*scale)+origin.Y, scale, scale));
			g.DrawImage((Bitmap) resources.GetObject("square_magenta"), 
				            new Rectangle((shotLocation.tileLocation.X*scale)+origin.X, (shotLocation.tileLocation.Y*scale)+origin.Y, scale, scale));
			this.score += 3;
			scoreTextBox.Clear();
			scoreTextBox.Text = score.ToString();
			controlsGroupBox.Enabled = false;
			successfulFightButton.Visible = true;
			baddies.Remove(activeBaddie);
		}
		
		void FailShot()
		{
			controlsGroupBox.Enabled = false;
			failedFightButton.Visible = true;
		}
		
		void GameTimeUp(Object o, EventArgs e)
		{
			gameClock.Stop();
			GameOver();
		}
	
		public void GameOver()
		{
			controlsGroupBox.Enabled = false;
			
			// Fire ActivateHeroButton1Click event so correct movement buttons displayed if number of heroes goes from > 1 to 1.
			activateHeroButton1.PerformClick();
			
			// If game stops with the following buttons visible, then GameOver() will hide them
			controlsGroupBox.Visible = false;
			successfulFightButton.Visible = false;
			outOfBoundsButton.Visible = false;
			failedFightButton.Visible = false;
			gameOverButton.Visible = true;
			gameOverButton.Enabled = true;
			gameOverButton.Text = "GAME OVER!\rYou scored " + score + "\r Click to play again!";
		}
		
		void GameOverButtonClick(object sender, EventArgs e)
		{
			this.score = 0;
			scoreTextBox.Clear();
			scoreTextBox.Text = score.ToString();
			startButton.Visible = true;
			heroesSelectorPanel.Visible = true;
			baddieSelectorPanel.Visible = true;
			gameOverButton.Visible = false;
		}
		
		void UseDoorButtonClick(object sender, EventArgs e)
		{
			if(activeHero.location.adjacencies[activeHero.facing] is Door){
				(activeHero.location.adjacencies[activeHero.facing] as Door).OpenShut();
				
				// Add both sides of door to Tile redraw list (one of which is activeHero.location).
				tilesForRedraw.Add(activeHero.location);
				tilesForRedraw.Add((activeHero.location.adjacencies[activeHero.facing] as Door).OtherSide(activeHero.location));
				
				// Add activeHero to the Character redraw list.
				charactersForRedraw.Add(activeHero);
				
				// If any other Character is behind door, at it to Character redraw list.
				everybody = heroes.Concat(baddies);
				foreach(Character anybody in everybody)
				{
					if(anybody.location == (activeHero.location.adjacencies[activeHero.facing] as Door).OtherSide(activeHero.location))
					{
						charactersForRedraw.Add(anybody);
					}
				}
				
				// Redraw both lists.
				DrawLocation(tilesForRedraw);
				DrawCharacter(charactersForRedraw);
			}
		}
		
		void ScaleRadioButton_25CheckedChanged(object sender, EventArgs e)
		{
			scale = 25;
			DrawLocation();
		}
		
		void ScaleRadioButton_50CheckedChanged(object sender, EventArgs e)
		{
			scale = 50;
			DrawLocation();
		}
		
		void ScaleRadioButton_100CheckedChanged(object sender, EventArgs e)
		{
			scale = 100;
			DrawLocation();
		}
		
		
		void ScrollNorthButtonClick(object sender, EventArgs e)
		{
			origin.Offset(0, scale);
			DrawLocation();
		}
		
		void ScrollEastButtonClick(object sender, EventArgs e)
		{
			origin.Offset(-scale, 0);
			DrawLocation();
		}
		
		void ScrollSouthButtonClick(object sender, EventArgs e)
		{
			origin.Offset(0, -scale);
			DrawLocation();
		}
		
		void ScrollWestButtonClick(object sender, EventArgs e)
		{
			origin.Offset(scale, 0);
			DrawLocation();
		}
		
		void ScrollResetButtonClick(object sender, EventArgs e)
		{
			origin = initialOrigin;
			DrawLocation();
		}
		
	}
}


