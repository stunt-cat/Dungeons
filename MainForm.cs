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
		//public Point shotLocation;
		//public Character shotVictim;
		
		// Origin for all graphics locations - N.B. All graphics are 100x100 pixels.
		public Point origin;
		
		// Create Room for action to take place in
		public Room room;
	
		ResourceManager resources = new ResourceManager("Dungeons.images", Assembly.GetExecutingAssembly());
		private System.Drawing.Graphics g;
		private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue, 7F);
		private System.Drawing.Pen pen2 = new System.Drawing.Pen(Color.Red, 10F);
		private System.Drawing.Pen pen3 = new System.Drawing.Pen(Color.Magenta, 10F);
		
		public int score = 0;
		Random random = new Random();
		
		
		void StartButtonClick(object sender, EventArgs e)
		{
			// Get numberOfBaddies from RadioBox in baddieSelectorPanel
			if (baddieSelectorButton1.Checked) numberOfBaddies = 1;
			else if (baddieSelectorButton2.Checked) numberOfBaddies = 2;
			else if (baddieSelectorButton3.Checked) numberOfBaddies = 3;
			else if (baddieSelectorButton4.Checked) numberOfBaddies = 4;
			else if (baddieSelectorButton5.Checked) numberOfBaddies = 5;
			else if (baddieSelectorButton6.Checked) numberOfBaddies = 6;
			
			baddies = new List<Character>(numberOfBaddies);
			
			// Get numberOfHeroes from RadioBox in heroSelectorPanel
			if (heroSelectorButton1.Checked) numberOfHeroes = 1;
			else if (heroSelectorButton2.Checked) numberOfHeroes = 2;
			else if (heroSelectorButton3.Checked) numberOfHeroes = 3;
			else if (heroSelectorButton4.Checked) numberOfHeroes = 4;
			
			heroes = new List<Character>(numberOfHeroes);
			
			/*
			// Get room parameters from RadioBox in roomSelectorPanel - also select correct background image
			if (roomSelectorButton1.Checked){
				roomSquaresX = 3;
				roomSquaresY = 5;
				this.pictureBox1.BackgroundImage = global::Dungeons.Images.room3x5;
			} else if (roomSelectorButton2.Checked){
				roomSquaresX = 4;
				roomSquaresY = 4;
				this.pictureBox1.BackgroundImage = global::Dungeons.Images.room4x4;
			} else if (roomSelectorButton3.Checked){
				roomSquaresX = 5;
				roomSquaresY = 5;
				this.pictureBox1.BackgroundImage = global::Dungeons.Images.room5x5;
			}
			*/
			origin = new Point(0,0);
			room = new Room(origin);  // Currently room is the only room, so is anchored at origin.
			
			// Randomly select hero start point(s), ensuring there are no conflicts with other heroes (N.B. no baddies exist at this point)
			for (int i = 0; i < numberOfHeroes; i++)
			{
				Tile bufferLocation = RandomLocation();
				Boolean tileAvailable = true;
				
				// Check other Hero locations and reassign bufferLocation until it is an available location
					do{
						// Assume location is initially free
						tileAvailable = true;
						foreach (Character hero in heroes)
						{
							if (bufferLocation == hero.location)
							{
								// If location not free, choose another and check everybody again
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
			
			gameClock.Start();
			gameClock.Tick += new EventHandler(GameTimeUp);
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
			Tile randomTile = (Tile)room.tiles[random.Next(16)];			// EDIT THIS WHEN CHANGING TRIAL ROOM!!!
			return randomTile;
		}
		
		void ResetGame()
		{
			baddieSelectorPanel.Visible = false;
			heroesSelectorPanel.Visible = false;
			roomSizeSelectorPanel.Visible = false;
			gameOverButton.Visible = false;
			startButton.Visible = false;
			forwardButton.Enabled = true;
			leftTurnButton.Enabled = true;
			rightTurnButton.Enabled = true;
			closeCombatButton.Enabled = true;
			rangedCombatButton.Enabled = true;
			useDoorButton.Enabled = true;
			drawHeroSelectorButtons(numberOfHeroes);	
			DrawLocation();
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
		
		private void DrawLocation()
		{
			pictureBox1.Refresh();
			g = pictureBox1.CreateGraphics();
			
			// Draw Room(s)
			foreach (Tile tile in room.tiles){
				
				g.DrawImageUnscaled((Bitmap)resources.GetObject(tile.imageRef), tile.tileLocation);
				
				// Draw wall images as necessary over the Tile base image.
				if(tile.adjacent[Direction.North] == null) g.DrawImageUnscaled((Bitmap)resources.GetObject("tileWallN"), tile.tileLocation);
				if(tile.adjacent[Direction.East] == null) g.DrawImageUnscaled((Bitmap)resources.GetObject("tileWallE"), tile.tileLocation);
				if(tile.adjacent[Direction.South] == null) g.DrawImageUnscaled((Bitmap)resources.GetObject("tileWallS"), tile.tileLocation);
				if(tile.adjacent[Direction.West] == null) g.DrawImageUnscaled((Bitmap)resources.GetObject("tileWallW"), tile.tileLocation);	
				
				// Draw door images as necessary over the Tile base image.
				if(tile.adjacent[Direction.North] is Door) g.DrawImageUnscaled((Bitmap)resources.GetObject((tile.adjacent[Direction.North] as Door).imageRef), (tile.adjacent[Direction.North] as Door).location.tileLocation);
				if(tile.adjacent[Direction.East] is Door) g.DrawImageUnscaled((Bitmap)resources.GetObject((tile.adjacent[Direction.East] as Door).imageRef), (tile.adjacent[Direction.East] as Door).location.tileLocation);
				if(tile.adjacent[Direction.South] is Door) g.DrawImageUnscaled((Bitmap)resources.GetObject((tile.adjacent[Direction.South] as Door).imageRef), (tile.adjacent[Direction.South] as Door).location.tileLocation);
				if(tile.adjacent[Direction.West] is Door) g.DrawImageUnscaled((Bitmap)resources.GetObject((tile.adjacent[Direction.West] as Door).imageRef), (tile.adjacent[Direction.West] as Door).location.tileLocation);
			}
			
			// Draw baddie(s)
			foreach (Baddie baddie in baddies) {
				g.DrawImageUnscaled((Bitmap)resources.GetObject("baddie"), baddie.location.tileLocation);
			}    
			
			// Draw hero(es)
			foreach (Hero hero in heroes) {
				string arrow = string.Format("hero_{0}_{1}", hero.facing.ToString().ToLower(), hero.number.ToString());
				g.DrawImageUnscaled((Bitmap)resources.GetObject(arrow), hero.location.tileLocation);
			}                                       
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
			
			// Resolve move.
			if(directionProblem){				// Problem of some sort - inform user.
				OutOfBounds();
				DrawLocation();
			} else {
				activeHero.MoveTo(moveTarget);  // Move is fine to execute!
				DrawLocation();
				
				// Possibly also move Baddies, 50% chance of running method.
				if(random.Next(2) == 0){
					MoveBaddie();
				}
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
				
				if(!directionProblem)
				{
					// Move is okay to execute!
					movingBaddie.MoveTo(moveTarget);
					// Update movingBaddie facing to reflect completed move.
					movingBaddie.NewFacing(baddieMoveDirection);
					
					DrawLocation();
					
					// N.B. If moveProblem=true movingBaddie doesn't move or change facing.
				} 
			}
		}
		
		private void OutOfBounds()
		{
			outOfBoundsButton.Visible = true;
			forwardButton.Enabled = false;
			leftTurnButton.Enabled = false;
			rightTurnButton.Enabled = false;
			closeCombatButton.Enabled = false;
			rangedCombatButton.Enabled = false;
			activateHeroButton2.Enabled = false;
		}
		
		void OutOfBoundsButtonClick(object sender, System.EventArgs e)
		{
			outOfBoundsButton.Visible = false;
			forwardButton.Enabled = true;
			leftTurnButton.Enabled = true;
			rightTurnButton.Enabled = true;
			closeCombatButton.Enabled = true;
			rangedCombatButton.Enabled = true;
			activateHeroButton2.Enabled = true;
			DrawLocation();
		}
		
		void LeftTurnButtonClick(object sender, EventArgs e)
		{
			activeHero.TurnLeft();
			DrawLocation();
		}
		
		void RightTurnButtonClick(object sender, EventArgs e)
		{
			activeHero.TurnRight();
			DrawLocation();
		}
		
		void FightButtonClick(object sender, System.EventArgs e)
		{
			forwardButton.Enabled = false;
			leftTurnButton.Enabled = false;
			rightTurnButton.Enabled = false;
			closeCombatButton.Enabled = false;
			rangedCombatButton.Enabled = false;
			useDoorButton.Enabled = false;

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
				g.DrawImageUnscaled((Bitmap) resources.GetObject("dead_baddie"), activeBaddie.location.tileLocation);
				g.DrawRectangle (pen2, activeBaddie.location.tileLocation.X, activeBaddie.location.tileLocation.Y, 100, 100);
				
				// Remove baddie from baddies
				baddies.Remove(activeBaddie);
			} else failedFightButton.Visible = true;
		}
		
		void SuccessfulFightButtonClick(object sender, EventArgs e)
		{
			successfulFightButton.Visible = false;
			if (baddies.Count == 0)
			{
				// Get more baddies! N.B. same number as initial user selection
				AssignBaddieLocations();
			}
			ResetGame();
		}
		
		
		void FailedFightButtonClick(object sender, EventArgs e)
		{
			failedFightButton.Visible = false;
			forwardButton.Enabled = true;
			leftTurnButton.Enabled = true;
			rightTurnButton.Enabled = true;
			closeCombatButton.Enabled = true;
			rangedCombatButton.Enabled = true;
			activateHeroButton2.Enabled = true;
			useDoorButton.Enabled = true;
			DrawLocation();
		}
		
		void RangedCombatButtonClick(object sender, EventArgs e){
			// This is just a dummy while I work out how to do it again..
		}
		
		/*  TODO ADD RANGED COMBAT BACK IN!!
		void RangedCombatButtonClick(object sender, EventArgs e)
		{
			shotLocation = activeHero.location;
			activeBaddie = null;
			shotVictim = null;
			everybody = heroes.Concat(baddies);
			
			// Shoot in straight line until hit wall or other Character. If Character encountered, decide outcome based on Type.
			
			switch(activeHero.facing)
			{
					case Direction.North: 
						while ((shotVictim == null) && (shotLocation.Y > 0))
							{
								foreach (Character potentialVictim in everybody)
								{
									if (!CheckAdjacencyAvailable(Direction.North, shotLocation, potentialVictim.location))
									{
										shotVictim = potentialVictim;
										break;
									}
								}
							g.DrawRectangle(pen1, shotLocation.X, shotLocation.Y - 100, 100, 100);
							shotLocation.Y -= 100;
						} break;
					case Direction.East:
						while ((shotVictim == null) && (shotLocation.X < 400))
							{
								foreach (Character potentialVictim in everybody)
								{
									if (!CheckAdjacencyAvailable(Direction.East, shotLocation, potentialVictim.location))
									{
										shotVictim = potentialVictim;
										break;
									}
								}
							g.DrawRectangle(pen1, shotLocation.X + 100, shotLocation.Y, 100, 100);
							shotLocation.X += 100;
						}						
						break;
					case Direction.South: 
						while ((shotVictim == null) && (shotLocation.Y < 400))
							{
								foreach (Character potentialVictim in everybody)
								{
									if (!CheckAdjacencyAvailable(Direction.South, shotLocation, potentialVictim.location))
									{
										shotVictim = potentialVictim;
										break;
									}
								}
							g.DrawRectangle(pen1, shotLocation.X, shotLocation.Y + 100, 100, 100);
							shotLocation.Y += 100;
						}
						break;
					case Direction.West: 
						while ((shotVictim == null) && (shotLocation.X > 0))
							{
								foreach (Character potentialVictim in everybody)
								{
									if (!CheckAdjacencyAvailable(Direction.West, shotLocation, potentialVictim.location))
									{
										shotVictim = potentialVictim;
										break;
									}
								}
							g.DrawRectangle(pen1, shotLocation.X - 100, shotLocation.Y, 100, 100);
							shotLocation.X -= 100;
						}
						break;
			}
			
			// If there is a shotVictim, check its type. If if it a Baddie, kill it! If it is a Hero, shot does nothing.
			if(shotVictim != null)
			{
				if (shotVictim.GetType() != activeHero.GetType())
				{
					activeBaddie = (Baddie) shotVictim;
					KillShot();
				} else FailShot();
			} else FailShot();
		}
		
		void KillShot()
		{
			g.DrawImageUnscaled((Bitmap) resources.GetObject("dead_baddie"), activeBaddie.location);
			g.DrawRectangle(pen3, shotLocation.X, shotLocation.Y, 100, 100);
			this.score += 3;
			scoreTextBox.Clear();
			scoreTextBox.Text = score.ToString();
			forwardButton.Enabled = false;
			leftTurnButton.Enabled = false;
			rightTurnButton.Enabled = false;
			closeCombatButton.Enabled = false;
			rangedCombatButton.Enabled = false;
			successfulFightButton.Visible = true;
			baddies.Remove(activeBaddie);
		}
		
		void FailShot()
		{
			forwardButton.Enabled = false;
			leftTurnButton.Enabled = false;
			rightTurnButton.Enabled = false;
			closeCombatButton.Enabled = false;
			rangedCombatButton.Enabled = false;
			activateHeroButton2.Enabled = false;
			failedFightButton.Visible = true;
		}
		*/
		
		void GameTimeUp(Object o, EventArgs e)
		{
			gameClock.Stop();
			GameOver();
		}
	
		public void GameOver()
		{
			forwardButton.Enabled = false;
			leftTurnButton.Enabled = false;
			rightTurnButton.Enabled = false;
			closeCombatButton.Enabled = false;
			rangedCombatButton.Enabled = false;
			
			// Fire ActivateHeroButton1Click event so correct movement buttons displayed if number of heroes goes from > 1 to 1.
			activateHeroButton1.PerformClick();
			
			// If game stops with the following buttons visible, then GameOver() will hide them
			successfulFightButton.Visible = false;
			outOfBoundsButton.Visible = false;
			failedFightButton.Visible = false;
			activateHeroButton1.Visible = false;
			activateHeroButton2.Visible = false;
			activateHeroButton3.Visible = false;
			activateHeroButton4.Visible = false;
			
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
			roomSizeSelectorPanel.Visible = true;
			gameOverButton.Visible = false;
		}
		
		void UseDoorButtonClick(object sender, EventArgs e)
		{
			if(activeHero.location.adjacent[activeHero.facing] is Door){
				(activeHero.location.adjacent[activeHero.facing] as Door).OpenShut();
				DrawLocation();
			}
		}
	}
}


