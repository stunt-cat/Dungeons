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
		public Tile shotLocation;
		public Character shotVictim;
		
		// Origin for all graphics locations - N.B. All graphics are 100x100 pixels.
		public Point origin;
		
		// Create Board for action to take place in
		public Board board;
		
		// Set scale for Board
		public int scale;			// TODO Make this a user selectable figure (25?, 50, 75?, 100) radio button/drop-down list. Redraw upon change.
	
		ResourceManager resources = new ResourceManager("Dungeons.images", Assembly.GetExecutingAssembly());
		private System.Drawing.Graphics g;
		private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.Blue, 7F);
		private System.Drawing.Pen pen2 = new System.Drawing.Pen(Color.Red, 10F);
		private System.Drawing.Pen pen3 = new System.Drawing.Pen(Color.Magenta, 10F);
		
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
			
			baddies = new List<Character>(numberOfBaddies);
			
			// Get numberOfHeroes from RadioBox in heroSelectorPanel.
			if (heroSelectorButton1.Checked) numberOfHeroes = 1;
			else if (heroSelectorButton2.Checked) numberOfHeroes = 2;
			else if (heroSelectorButton3.Checked) numberOfHeroes = 3;
			else if (heroSelectorButton4.Checked) numberOfHeroes = 4;
			
			heroes = new List<Character>(numberOfHeroes);
			
			// Get scale from RadioBox in scalePanel.
			if (scaleRadioButton_50.Checked) scale = 50;
			if (scaleRadioButton_100.Checked) scale = 100;
			
			// Create board.
			// N.B. All Points are in abstract integer sizes to relate each Room/Tile to each other.
			// 		These sizes are converted to actual pixels in DrawLocation().
			origin = new Point(0,0);
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
			controlsGroupBox.Visible = true;
			controlsGroupBox.Enabled = true;
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
			foreach (Room room in board.rooms)
			{
				foreach (Tile tile in room.tiles)
				{
				
					g.DrawImage((Bitmap)resources.GetObject(tile.imageRef), new Rectangle(tile.tileLocation.X*scale, tile.tileLocation.Y*scale, scale, scale));
				
				// Draw wall images as necessary over the Tile base image.
				if(tile.adjacencies[Direction.North] == null) g.DrawImage((Bitmap)resources.GetObject("tileWallN"), new Rectangle(tile.tileLocation.X*scale, tile.tileLocation.Y*scale, scale, scale));
				if(tile.adjacencies[Direction.East] == null) g.DrawImage((Bitmap)resources.GetObject("tileWallE"), new Rectangle(tile.tileLocation.X*scale, tile.tileLocation.Y*scale, scale, scale));
				if(tile.adjacencies[Direction.South] == null) g.DrawImage((Bitmap)resources.GetObject("tileWallS"), new Rectangle(tile.tileLocation.X*scale, tile.tileLocation.Y*scale, scale, scale));
				if(tile.adjacencies[Direction.West] == null) g.DrawImage((Bitmap)resources.GetObject("tileWallW"), new Rectangle(tile.tileLocation.X*scale, tile.tileLocation.Y*scale, scale, scale));	
				
					// Draw door images as necessary over the Tile base images. N.B. There is a front and a back image for each Door.
					if(tile.adjacencies[Direction.North] is Door)
					{
						// See if front or back image is required.
						if(tile.tileLocation == (tile.adjacencies[Direction.North] as Door).sideA.tileLocation){			// tile is location of Door, so front image required.
							g.DrawImage((Bitmap)resources.GetObject((tile.adjacencies[Direction.North] as Door).imageRefSideA), new Rectangle(tile.tileLocation.X*scale, tile.tileLocation.Y*scale, scale, scale));
						} else {																							// tile is not location of Door, so back image required.
							g.DrawImage((Bitmap)resources.GetObject((tile.adjacencies[Direction.North] as Door).imageRefSideB), new Rectangle(tile.tileLocation.X*scale, tile.tileLocation.Y*scale, scale, scale));
						}
					}
					if(tile.adjacencies[Direction.East] is Door)
						g.DrawImage((Bitmap)resources.GetObject((tile.adjacencies[Direction.East] as Door).imageRefSideA), new Rectangle(tile.tileLocation.X*scale, tile.tileLocation.Y*scale, scale, scale));
					/*
					{
						// See if front or back image is required.
						if(tile.tileLocation == (tile.adjacencies[Direction.East] as Door).sideA.tileLocation){			// tile is location of Door, so front image required.
							g.DrawImage((Bitmap)resources.GetObject((tile.adjacencies[Direction.East] as Door).imageRefSideA), new Rectangle(tile.tileLocation.X*scale, tile.tileLocation.Y*scale, scale, scale));
						} else {																							// tile is not location of Door, so back image required.
							g.DrawImage((Bitmap)resources.GetObject((tile.adjacencies[Direction.East] as Door).imageRefSideB), new Rectangle(tile.tileLocation.X*scale, tile.tileLocation.Y*scale, scale, scale));
						}
					}
					
					*/
					if(tile.adjacencies[Direction.South] is Door)
					{
						// See if front or back image is required.
						if(tile.tileLocation == (tile.adjacencies[Direction.South] as Door).sideA.tileLocation){			// tile is location of Door, so front image required.
							g.DrawImage((Bitmap)resources.GetObject((tile.adjacencies[Direction.South] as Door).imageRefSideA), new Rectangle(tile.tileLocation.X*scale, tile.tileLocation.Y*scale, scale, scale));
						} else {																							// tile is not location of Door, so back image required.
							g.DrawImage((Bitmap)resources.GetObject((tile.adjacencies[Direction.South] as Door).imageRefSideB), new Rectangle(tile.tileLocation.X*scale, tile.tileLocation.Y*scale, scale, scale));
						}
					}
					if(tile.adjacencies[Direction.West] is Door)
					{
						// See if front or back image is required.
						if(tile.tileLocation == (tile.adjacencies[Direction.West] as Door).sideA.tileLocation){			// tile is location of Door, so front image required.
							g.DrawImage((Bitmap)resources.GetObject((tile.adjacencies[Direction.West] as Door).imageRefSideA), new Rectangle(tile.tileLocation.X*scale, tile.tileLocation.Y*scale, scale, scale));
						} else {																							// tile is not location of Door, so back image required.
							g.DrawImage((Bitmap)resources.GetObject((tile.adjacencies[Direction.West] as Door).imageRefSideB), new Rectangle(tile.tileLocation.X*scale, tile.tileLocation.Y*scale, scale, scale));
						}
					}
				}
			}
			
			
			// Draw baddie(s)
			foreach (Baddie baddie in baddies)
			{
				g.DrawImage((Bitmap)resources.GetObject("baddie"), new Rectangle(baddie.location.tileLocation.X*scale, baddie.location.tileLocation.Y*scale, scale, scale));
			}    
			
			// Draw hero(es)
			foreach (Hero hero in heroes) {
				string arrow = string.Format("hero_{0}_{1}", hero.facing.ToString().ToLower(), hero.number.ToString());
				g.DrawImage((Bitmap)resources.GetObject(arrow), new Rectangle(hero.location.tileLocation.X*scale, hero.location.tileLocation.Y*scale, scale, scale));
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
			controlsGroupBox.Enabled = false;
		}
		
		void OutOfBoundsButtonClick(object sender, System.EventArgs e)
		{
			outOfBoundsButton.Visible = false;
			controlsGroupBox.Enabled = true;
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
				g.DrawImage((Bitmap) resources.GetObject("dead_baddie"), new Rectangle(activeBaddie.location.tileLocation.X*scale, activeBaddie.location.tileLocation.Y*scale, scale, scale));
				g.DrawRectangle (pen2, activeBaddie.location.tileLocation.X*scale, activeBaddie.location.tileLocation.Y*scale, scale, scale);
				
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
			controlsGroupBox.Enabled = true;
			DrawLocation();
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
					g.DrawRectangle(pen1, new Rectangle(shotLocation.tileLocation.X*scale, shotLocation.tileLocation.Y*scale, scale, scale));
				}
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
			g.DrawImage((Bitmap) resources.GetObject("dead_baddie"), new Rectangle(activeBaddie.location.tileLocation.X*scale, activeBaddie.location.tileLocation.Y*scale, scale, scale));
			g.DrawRectangle(pen3, shotLocation.tileLocation.X*scale, shotLocation.tileLocation.Y*scale, scale, scale);
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
			//activateHeroButton1.Visible = false;
			//activateHeroButton2.Visible = false;
			//activateHeroButton3.Visible = false;
			//activateHeroButton4.Visible = false;
			
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
				DrawLocation();
			}
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
	}
}


