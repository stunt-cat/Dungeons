/*
 * Created by SharpDevelop.
 * User: ed
 * Date: 24/02/2012
 * Time: 15:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Dungeons
	
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.closeCombatButton = new System.Windows.Forms.Button();
			this.forwardButton = new System.Windows.Forms.Button();
			this.startButton = new System.Windows.Forms.Button();
			this.outOfBoundsButton = new System.Windows.Forms.Button();
			this.failedFightButton = new System.Windows.Forms.Button();
			this.leftTurnButton = new System.Windows.Forms.Button();
			this.rightTurnButton = new System.Windows.Forms.Button();
			this.successfulFightButton = new System.Windows.Forms.Button();
			this.rangedCombatButton = new System.Windows.Forms.Button();
			this.scoreLabel = new System.Windows.Forms.Label();
			this.scoreTextBox = new System.Windows.Forms.TextBox();
			this.gameOverButton = new System.Windows.Forms.Button();
			this.gameClock = new System.Windows.Forms.Timer(this.components);
			this.numberOfBaddiesLabel = new System.Windows.Forms.Label();
			this.numberOfHeroesLabel = new System.Windows.Forms.Label();
			this.baddieSelectorPanel = new System.Windows.Forms.Panel();
			this.baddieSelectorButton6 = new System.Windows.Forms.RadioButton();
			this.baddieSelectorButton5 = new System.Windows.Forms.RadioButton();
			this.baddieSelectorButton4 = new System.Windows.Forms.RadioButton();
			this.baddieSelectorButton3 = new System.Windows.Forms.RadioButton();
			this.baddieSelectorButton2 = new System.Windows.Forms.RadioButton();
			this.baddieSelectorButton1 = new System.Windows.Forms.RadioButton();
			this.heroesSelectorPanel = new System.Windows.Forms.Panel();
			this.heroSelectorButton4 = new System.Windows.Forms.RadioButton();
			this.heroSelectorButton3 = new System.Windows.Forms.RadioButton();
			this.heroSelectorButton2 = new System.Windows.Forms.RadioButton();
			this.heroSelectorButton1 = new System.Windows.Forms.RadioButton();
			this.activateHeroButton2 = new System.Windows.Forms.Button();
			this.activateHeroButton1 = new System.Windows.Forms.Button();
			this.activateHeroButton3 = new System.Windows.Forms.Button();
			this.activateHeroButton4 = new System.Windows.Forms.Button();
			this.useDoorButton = new System.Windows.Forms.Button();
			this.controlsGroupBox = new System.Windows.Forms.GroupBox();
			this.scaleLabel = new System.Windows.Forms.Label();
			this.scaleSelectorPanel = new System.Windows.Forms.Panel();
			this.scaleRadioButton_25 = new System.Windows.Forms.RadioButton();
			this.scaleRadioButton_100 = new System.Windows.Forms.RadioButton();
			this.scaleRadioButton_50 = new System.Windows.Forms.RadioButton();
			this.scrollNorthButton = new System.Windows.Forms.Button();
			this.scrollResetButton = new System.Windows.Forms.Button();
			this.scrollEastButton = new System.Windows.Forms.Button();
			this.scrollSouthButton = new System.Windows.Forms.Button();
			this.scrollWestButton = new System.Windows.Forms.Button();
			this.scrollGroupBox = new System.Windows.Forms.GroupBox();
			this.baddieSelectorButton7 = new System.Windows.Forms.RadioButton();
			this.baddieSelectorButton8 = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.baddieSelectorPanel.SuspendLayout();
			this.heroesSelectorPanel.SuspendLayout();
			this.controlsGroupBox.SuspendLayout();
			this.scaleSelectorPanel.SuspendLayout();
			this.scrollGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Location = new System.Drawing.Point(12, 120);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(500, 500);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// closeCombatButton
			// 
			this.closeCombatButton.Image = global::Dungeons.Images.closeCombat;
			this.closeCombatButton.Location = new System.Drawing.Point(17, 227);
			this.closeCombatButton.Name = "closeCombatButton";
			this.closeCombatButton.Size = new System.Drawing.Size(100, 100);
			this.closeCombatButton.TabIndex = 1;
			this.closeCombatButton.UseVisualStyleBackColor = true;
			this.closeCombatButton.Click += new System.EventHandler(this.FightButtonClick);
			// 
			// forwardButton
			// 
			this.forwardButton.Image = global::Dungeons.Images.arrow_north_1;
			this.forwardButton.Location = new System.Drawing.Point(128, 9);
			this.forwardButton.Name = "forwardButton";
			this.forwardButton.Size = new System.Drawing.Size(100, 100);
			this.forwardButton.TabIndex = 5;
			this.forwardButton.UseVisualStyleBackColor = true;
			this.forwardButton.Click += new System.EventHandler(this.ForwardButtonClick);
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(58, 165);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(409, 413);
			this.startButton.TabIndex = 8;
			this.startButton.Text = resources.GetString("startButton.Text");
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.StartButtonClick);
			// 
			// outOfBoundsButton
			// 
			this.outOfBoundsButton.Location = new System.Drawing.Point(534, 555);
			this.outOfBoundsButton.Name = "outOfBoundsButton";
			this.outOfBoundsButton.Size = new System.Drawing.Size(167, 161);
			this.outOfBoundsButton.TabIndex = 9;
			this.outOfBoundsButton.Text = "STOP IT you cretin.\r\nThere is an obstruction. Durr.\r\n\r\nClick to continue.";
			this.outOfBoundsButton.UseVisualStyleBackColor = true;
			this.outOfBoundsButton.Visible = false;
			this.outOfBoundsButton.Click += new System.EventHandler(this.OutOfBoundsButtonClick);
			// 
			// failedFightButton
			// 
			this.failedFightButton.Location = new System.Drawing.Point(722, 555);
			this.failedFightButton.Name = "failedFightButton";
			this.failedFightButton.Size = new System.Drawing.Size(167, 161);
			this.failedFightButton.TabIndex = 10;
			this.failedFightButton.Text = "You miss.\r\nWell done.\r\n\r\nClick to continue.";
			this.failedFightButton.UseVisualStyleBackColor = true;
			this.failedFightButton.Visible = false;
			this.failedFightButton.Click += new System.EventHandler(this.FailedFightButtonClick);
			// 
			// leftTurnButton
			// 
			this.leftTurnButton.Image = global::Dungeons.Images.arrow_leftturn_1;
			this.leftTurnButton.Location = new System.Drawing.Point(9, 44);
			this.leftTurnButton.Name = "leftTurnButton";
			this.leftTurnButton.Size = new System.Drawing.Size(100, 100);
			this.leftTurnButton.TabIndex = 11;
			this.leftTurnButton.UseVisualStyleBackColor = true;
			this.leftTurnButton.Click += new System.EventHandler(this.LeftTurnButtonClick);
			// 
			// rightTurnButton
			// 
			this.rightTurnButton.Image = global::Dungeons.Images.arrow_rightturn_1;
			this.rightTurnButton.Location = new System.Drawing.Point(246, 44);
			this.rightTurnButton.Name = "rightTurnButton";
			this.rightTurnButton.Size = new System.Drawing.Size(100, 100);
			this.rightTurnButton.TabIndex = 12;
			this.rightTurnButton.UseVisualStyleBackColor = true;
			this.rightTurnButton.Click += new System.EventHandler(this.RightTurnButtonClick);
			// 
			// successfulFightButton
			// 
			this.successfulFightButton.Location = new System.Drawing.Point(573, 475);
			this.successfulFightButton.Name = "successfulFightButton";
			this.successfulFightButton.Size = new System.Drawing.Size(269, 64);
			this.successfulFightButton.TabIndex = 13;
			this.successfulFightButton.Text = "YOU KILLED HIM!\r\n\r\nClick to continue.";
			this.successfulFightButton.UseVisualStyleBackColor = true;
			this.successfulFightButton.Visible = false;
			this.successfulFightButton.Click += new System.EventHandler(this.SuccessfulFightButtonClick);
			// 
			// rangedCombatButton
			// 
			this.rangedCombatButton.Image = global::Dungeons.Images.rangedCombat;
			this.rangedCombatButton.Location = new System.Drawing.Point(129, 227);
			this.rangedCombatButton.Name = "rangedCombatButton";
			this.rangedCombatButton.Size = new System.Drawing.Size(100, 100);
			this.rangedCombatButton.TabIndex = 14;
			this.rangedCombatButton.UseVisualStyleBackColor = true;
			this.rangedCombatButton.Click += new System.EventHandler(this.RangedCombatButtonClick);
			// 
			// scoreLabel
			// 
			this.scoreLabel.Location = new System.Drawing.Point(216, 629);
			this.scoreLabel.Name = "scoreLabel";
			this.scoreLabel.Size = new System.Drawing.Size(59, 27);
			this.scoreLabel.TabIndex = 15;
			this.scoreLabel.Text = "SCORE";
			// 
			// scoreTextBox
			// 
			this.scoreTextBox.Location = new System.Drawing.Point(295, 626);
			this.scoreTextBox.Name = "scoreTextBox";
			this.scoreTextBox.ReadOnly = true;
			this.scoreTextBox.Size = new System.Drawing.Size(70, 20);
			this.scoreTextBox.TabIndex = 16;
			this.scoreTextBox.Text = "0";
			// 
			// gameOverButton
			// 
			this.gameOverButton.Location = new System.Drawing.Point(71, 182);
			this.gameOverButton.Name = "gameOverButton";
			this.gameOverButton.Size = new System.Drawing.Size(382, 383);
			this.gameOverButton.TabIndex = 18;
			this.gameOverButton.UseVisualStyleBackColor = true;
			this.gameOverButton.Visible = false;
			this.gameOverButton.Click += new System.EventHandler(this.GameOverButtonClick);
			// 
			// gameClock
			// 
			this.gameClock.Interval = 60000;
			// 
			// numberOfBaddiesLabel
			// 
			this.numberOfBaddiesLabel.Location = new System.Drawing.Point(21, 13);
			this.numberOfBaddiesLabel.Name = "numberOfBaddiesLabel";
			this.numberOfBaddiesLabel.Size = new System.Drawing.Size(103, 22);
			this.numberOfBaddiesLabel.TabIndex = 20;
			this.numberOfBaddiesLabel.Text = "Number of baddies";
			// 
			// numberOfHeroesLabel
			// 
			this.numberOfHeroesLabel.Location = new System.Drawing.Point(201, 12);
			this.numberOfHeroesLabel.Name = "numberOfHeroesLabel";
			this.numberOfHeroesLabel.Size = new System.Drawing.Size(103, 22);
			this.numberOfHeroesLabel.TabIndex = 22;
			this.numberOfHeroesLabel.Text = "Number of heroes";
			// 
			// baddieSelectorPanel
			// 
			this.baddieSelectorPanel.Controls.Add(this.baddieSelectorButton8);
			this.baddieSelectorPanel.Controls.Add(this.baddieSelectorButton7);
			this.baddieSelectorPanel.Controls.Add(this.baddieSelectorButton6);
			this.baddieSelectorPanel.Controls.Add(this.baddieSelectorButton5);
			this.baddieSelectorPanel.Controls.Add(this.baddieSelectorButton4);
			this.baddieSelectorPanel.Controls.Add(this.baddieSelectorButton3);
			this.baddieSelectorPanel.Controls.Add(this.baddieSelectorButton2);
			this.baddieSelectorPanel.Controls.Add(this.baddieSelectorButton1);
			this.baddieSelectorPanel.Location = new System.Drawing.Point(122, 7);
			this.baddieSelectorPanel.Name = "baddieSelectorPanel";
			this.baddieSelectorPanel.Size = new System.Drawing.Size(70, 84);
			this.baddieSelectorPanel.TabIndex = 23;
			// 
			// baddieSelectorButton6
			// 
			this.baddieSelectorButton6.Location = new System.Drawing.Point(37, 19);
			this.baddieSelectorButton6.Name = "baddieSelectorButton6";
			this.baddieSelectorButton6.Size = new System.Drawing.Size(33, 20);
			this.baddieSelectorButton6.TabIndex = 5;
			this.baddieSelectorButton6.Text = "6";
			this.baddieSelectorButton6.UseVisualStyleBackColor = true;
			// 
			// baddieSelectorButton5
			// 
			this.baddieSelectorButton5.Location = new System.Drawing.Point(37, 0);
			this.baddieSelectorButton5.Name = "baddieSelectorButton5";
			this.baddieSelectorButton5.Size = new System.Drawing.Size(33, 20);
			this.baddieSelectorButton5.TabIndex = 4;
			this.baddieSelectorButton5.Text = "5";
			this.baddieSelectorButton5.UseVisualStyleBackColor = true;
			// 
			// baddieSelectorButton4
			// 
			this.baddieSelectorButton4.Location = new System.Drawing.Point(7, 58);
			this.baddieSelectorButton4.Name = "baddieSelectorButton4";
			this.baddieSelectorButton4.Size = new System.Drawing.Size(33, 20);
			this.baddieSelectorButton4.TabIndex = 3;
			this.baddieSelectorButton4.Text = "4";
			this.baddieSelectorButton4.UseVisualStyleBackColor = true;
			// 
			// baddieSelectorButton3
			// 
			this.baddieSelectorButton3.Location = new System.Drawing.Point(7, 38);
			this.baddieSelectorButton3.Name = "baddieSelectorButton3";
			this.baddieSelectorButton3.Size = new System.Drawing.Size(56, 20);
			this.baddieSelectorButton3.TabIndex = 2;
			this.baddieSelectorButton3.Text = "3";
			this.baddieSelectorButton3.UseVisualStyleBackColor = true;
			// 
			// baddieSelectorButton2
			// 
			this.baddieSelectorButton2.Location = new System.Drawing.Point(7, 19);
			this.baddieSelectorButton2.Name = "baddieSelectorButton2";
			this.baddieSelectorButton2.Size = new System.Drawing.Size(56, 20);
			this.baddieSelectorButton2.TabIndex = 1;
			this.baddieSelectorButton2.Text = "2";
			this.baddieSelectorButton2.UseVisualStyleBackColor = true;
			// 
			// baddieSelectorButton1
			// 
			this.baddieSelectorButton1.Checked = true;
			this.baddieSelectorButton1.Location = new System.Drawing.Point(7, 0);
			this.baddieSelectorButton1.Name = "baddieSelectorButton1";
			this.baddieSelectorButton1.Size = new System.Drawing.Size(56, 20);
			this.baddieSelectorButton1.TabIndex = 0;
			this.baddieSelectorButton1.TabStop = true;
			this.baddieSelectorButton1.Text = "1";
			this.baddieSelectorButton1.UseVisualStyleBackColor = true;
			// 
			// heroesSelectorPanel
			// 
			this.heroesSelectorPanel.Controls.Add(this.heroSelectorButton4);
			this.heroesSelectorPanel.Controls.Add(this.heroSelectorButton3);
			this.heroesSelectorPanel.Controls.Add(this.heroSelectorButton2);
			this.heroesSelectorPanel.Controls.Add(this.heroSelectorButton1);
			this.heroesSelectorPanel.Location = new System.Drawing.Point(295, 7);
			this.heroesSelectorPanel.Name = "heroesSelectorPanel";
			this.heroesSelectorPanel.Size = new System.Drawing.Size(84, 59);
			this.heroesSelectorPanel.TabIndex = 24;
			// 
			// heroSelectorButton4
			// 
			this.heroSelectorButton4.Location = new System.Drawing.Point(41, 19);
			this.heroSelectorButton4.Name = "heroSelectorButton4";
			this.heroSelectorButton4.Size = new System.Drawing.Size(32, 22);
			this.heroSelectorButton4.TabIndex = 3;
			this.heroSelectorButton4.TabStop = true;
			this.heroSelectorButton4.Text = "4";
			this.heroSelectorButton4.UseVisualStyleBackColor = true;
			// 
			// heroSelectorButton3
			// 
			this.heroSelectorButton3.Location = new System.Drawing.Point(41, 1);
			this.heroSelectorButton3.Name = "heroSelectorButton3";
			this.heroSelectorButton3.Size = new System.Drawing.Size(32, 22);
			this.heroSelectorButton3.TabIndex = 2;
			this.heroSelectorButton3.TabStop = true;
			this.heroSelectorButton3.Text = "3";
			this.heroSelectorButton3.UseVisualStyleBackColor = true;
			// 
			// heroSelectorButton2
			// 
			this.heroSelectorButton2.Location = new System.Drawing.Point(3, 18);
			this.heroSelectorButton2.Name = "heroSelectorButton2";
			this.heroSelectorButton2.Size = new System.Drawing.Size(32, 21);
			this.heroSelectorButton2.TabIndex = 1;
			this.heroSelectorButton2.TabStop = true;
			this.heroSelectorButton2.Text = "2";
			this.heroSelectorButton2.UseVisualStyleBackColor = true;
			// 
			// heroSelectorButton1
			// 
			this.heroSelectorButton1.Checked = true;
			this.heroSelectorButton1.Location = new System.Drawing.Point(3, -2);
			this.heroSelectorButton1.Name = "heroSelectorButton1";
			this.heroSelectorButton1.Size = new System.Drawing.Size(38, 25);
			this.heroSelectorButton1.TabIndex = 0;
			this.heroSelectorButton1.TabStop = true;
			this.heroSelectorButton1.Text = "1";
			this.heroSelectorButton1.UseVisualStyleBackColor = true;
			// 
			// activateHeroButton2
			// 
			this.activateHeroButton2.Enabled = false;
			this.activateHeroButton2.Image = global::Dungeons.Images.hero_select_2;
			this.activateHeroButton2.Location = new System.Drawing.Point(123, 160);
			this.activateHeroButton2.Name = "activateHeroButton2";
			this.activateHeroButton2.Size = new System.Drawing.Size(50, 50);
			this.activateHeroButton2.TabIndex = 17;
			this.activateHeroButton2.UseVisualStyleBackColor = true;
			this.activateHeroButton2.Visible = false;
			this.activateHeroButton2.Click += new System.EventHandler(this.ActivateHeroButton2Click);
			// 
			// activateHeroButton1
			// 
			this.activateHeroButton1.Enabled = false;
			this.activateHeroButton1.Image = global::Dungeons.Images.hero_select_1;
			this.activateHeroButton1.Location = new System.Drawing.Point(67, 160);
			this.activateHeroButton1.Name = "activateHeroButton1";
			this.activateHeroButton1.Size = new System.Drawing.Size(50, 50);
			this.activateHeroButton1.TabIndex = 25;
			this.activateHeroButton1.UseVisualStyleBackColor = true;
			this.activateHeroButton1.Visible = false;
			this.activateHeroButton1.Click += new System.EventHandler(this.ActivateHeroButton1Click);
			// 
			// activateHeroButton3
			// 
			this.activateHeroButton3.Enabled = false;
			this.activateHeroButton3.Image = global::Dungeons.Images.hero_select_3;
			this.activateHeroButton3.Location = new System.Drawing.Point(179, 160);
			this.activateHeroButton3.Name = "activateHeroButton3";
			this.activateHeroButton3.Size = new System.Drawing.Size(50, 50);
			this.activateHeroButton3.TabIndex = 26;
			this.activateHeroButton3.UseVisualStyleBackColor = true;
			this.activateHeroButton3.Visible = false;
			this.activateHeroButton3.Click += new System.EventHandler(this.ActivateHeroButton3Click);
			// 
			// activateHeroButton4
			// 
			this.activateHeroButton4.Enabled = false;
			this.activateHeroButton4.Image = global::Dungeons.Images.hero_select_4;
			this.activateHeroButton4.Location = new System.Drawing.Point(235, 160);
			this.activateHeroButton4.Name = "activateHeroButton4";
			this.activateHeroButton4.Size = new System.Drawing.Size(50, 50);
			this.activateHeroButton4.TabIndex = 27;
			this.activateHeroButton4.UseVisualStyleBackColor = true;
			this.activateHeroButton4.Visible = false;
			this.activateHeroButton4.Click += new System.EventHandler(this.ActivateHeroButton4Click);
			// 
			// useDoorButton
			// 
			this.useDoorButton.Image = global::Dungeons.Images.useDoor;
			this.useDoorButton.Location = new System.Drawing.Point(246, 227);
			this.useDoorButton.Name = "useDoorButton";
			this.useDoorButton.Size = new System.Drawing.Size(100, 100);
			this.useDoorButton.TabIndex = 29;
			this.useDoorButton.UseVisualStyleBackColor = true;
			this.useDoorButton.Click += new System.EventHandler(this.UseDoorButtonClick);
			// 
			// controlsGroupBox
			// 
			this.controlsGroupBox.Controls.Add(this.useDoorButton);
			this.controlsGroupBox.Controls.Add(this.activateHeroButton4);
			this.controlsGroupBox.Controls.Add(this.activateHeroButton3);
			this.controlsGroupBox.Controls.Add(this.activateHeroButton1);
			this.controlsGroupBox.Controls.Add(this.activateHeroButton2);
			this.controlsGroupBox.Controls.Add(this.rangedCombatButton);
			this.controlsGroupBox.Controls.Add(this.rightTurnButton);
			this.controlsGroupBox.Controls.Add(this.leftTurnButton);
			this.controlsGroupBox.Controls.Add(this.forwardButton);
			this.controlsGroupBox.Controls.Add(this.closeCombatButton);
			this.controlsGroupBox.Location = new System.Drawing.Point(525, 133);
			this.controlsGroupBox.Name = "controlsGroupBox";
			this.controlsGroupBox.Size = new System.Drawing.Size(360, 342);
			this.controlsGroupBox.TabIndex = 30;
			this.controlsGroupBox.TabStop = false;
			this.controlsGroupBox.Text = "Controls";
			this.controlsGroupBox.Visible = false;
			// 
			// scaleLabel
			// 
			this.scaleLabel.Location = new System.Drawing.Point(573, 39);
			this.scaleLabel.Name = "scaleLabel";
			this.scaleLabel.Size = new System.Drawing.Size(103, 22);
			this.scaleLabel.TabIndex = 31;
			this.scaleLabel.Text = "Scale";
			// 
			// scaleSelectorPanel
			// 
			this.scaleSelectorPanel.Controls.Add(this.scaleRadioButton_25);
			this.scaleSelectorPanel.Controls.Add(this.scaleRadioButton_100);
			this.scaleSelectorPanel.Controls.Add(this.scaleRadioButton_50);
			this.scaleSelectorPanel.Location = new System.Drawing.Point(534, 58);
			this.scaleSelectorPanel.Name = "scaleSelectorPanel";
			this.scaleSelectorPanel.Size = new System.Drawing.Size(167, 28);
			this.scaleSelectorPanel.TabIndex = 25;
			this.scaleSelectorPanel.Visible = false;
			// 
			// scaleRadioButton_25
			// 
			this.scaleRadioButton_25.Checked = true;
			this.scaleRadioButton_25.Location = new System.Drawing.Point(8, 2);
			this.scaleRadioButton_25.Name = "scaleRadioButton_25";
			this.scaleRadioButton_25.Size = new System.Drawing.Size(49, 25);
			this.scaleRadioButton_25.TabIndex = 2;
			this.scaleRadioButton_25.TabStop = true;
			this.scaleRadioButton_25.Text = "25%";
			this.scaleRadioButton_25.UseVisualStyleBackColor = true;
			this.scaleRadioButton_25.CheckedChanged += new System.EventHandler(this.ScaleRadioButton_25CheckedChanged);
			// 
			// scaleRadioButton_100
			// 
			this.scaleRadioButton_100.Location = new System.Drawing.Point(110, 4);
			this.scaleRadioButton_100.Name = "scaleRadioButton_100";
			this.scaleRadioButton_100.Size = new System.Drawing.Size(54, 21);
			this.scaleRadioButton_100.TabIndex = 1;
			this.scaleRadioButton_100.Text = "100%";
			this.scaleRadioButton_100.UseVisualStyleBackColor = true;
			this.scaleRadioButton_100.CheckedChanged += new System.EventHandler(this.ScaleRadioButton_100CheckedChanged);
			// 
			// scaleRadioButton_50
			// 
			this.scaleRadioButton_50.Location = new System.Drawing.Point(58, 2);
			this.scaleRadioButton_50.Name = "scaleRadioButton_50";
			this.scaleRadioButton_50.Size = new System.Drawing.Size(46, 25);
			this.scaleRadioButton_50.TabIndex = 0;
			this.scaleRadioButton_50.Text = "50%";
			this.scaleRadioButton_50.UseVisualStyleBackColor = true;
			this.scaleRadioButton_50.CheckedChanged += new System.EventHandler(this.ScaleRadioButton_50CheckedChanged);
			// 
			// scrollNorthButton
			// 
			this.scrollNorthButton.Image = global::Dungeons.Images.arrow_scroll_north;
			this.scrollNorthButton.Location = new System.Drawing.Point(55, 12);
			this.scrollNorthButton.Name = "scrollNorthButton";
			this.scrollNorthButton.Size = new System.Drawing.Size(35, 35);
			this.scrollNorthButton.TabIndex = 30;
			this.scrollNorthButton.UseVisualStyleBackColor = true;
			this.scrollNorthButton.Click += new System.EventHandler(this.ScrollNorthButtonClick);
			// 
			// scrollResetButton
			// 
			this.scrollResetButton.Image = global::Dungeons.Images.arrow_scroll_reset;
			this.scrollResetButton.Location = new System.Drawing.Point(56, 51);
			this.scrollResetButton.Name = "scrollResetButton";
			this.scrollResetButton.Size = new System.Drawing.Size(35, 35);
			this.scrollResetButton.TabIndex = 32;
			this.scrollResetButton.UseVisualStyleBackColor = true;
			this.scrollResetButton.Click += new System.EventHandler(this.ScrollResetButtonClick);
			// 
			// scrollEastButton
			// 
			this.scrollEastButton.Image = global::Dungeons.Images.arrow_scroll_east;
			this.scrollEastButton.Location = new System.Drawing.Point(97, 51);
			this.scrollEastButton.Name = "scrollEastButton";
			this.scrollEastButton.Size = new System.Drawing.Size(35, 35);
			this.scrollEastButton.TabIndex = 33;
			this.scrollEastButton.UseVisualStyleBackColor = true;
			this.scrollEastButton.Click += new System.EventHandler(this.ScrollEastButtonClick);
			// 
			// scrollSouthButton
			// 
			this.scrollSouthButton.Image = global::Dungeons.Images.arrow_scroll_south;
			this.scrollSouthButton.Location = new System.Drawing.Point(56, 91);
			this.scrollSouthButton.Name = "scrollSouthButton";
			this.scrollSouthButton.Size = new System.Drawing.Size(35, 35);
			this.scrollSouthButton.TabIndex = 34;
			this.scrollSouthButton.UseVisualStyleBackColor = true;
			this.scrollSouthButton.Click += new System.EventHandler(this.ScrollSouthButtonClick);
			// 
			// scrollWestButton
			// 
			this.scrollWestButton.Image = global::Dungeons.Images.arrow_scroll_west;
			this.scrollWestButton.Location = new System.Drawing.Point(15, 53);
			this.scrollWestButton.Name = "scrollWestButton";
			this.scrollWestButton.Size = new System.Drawing.Size(35, 35);
			this.scrollWestButton.TabIndex = 35;
			this.scrollWestButton.UseVisualStyleBackColor = true;
			this.scrollWestButton.Click += new System.EventHandler(this.ScrollWestButtonClick);
			// 
			// scrollGroupBox
			// 
			this.scrollGroupBox.Controls.Add(this.scrollWestButton);
			this.scrollGroupBox.Controls.Add(this.scrollSouthButton);
			this.scrollGroupBox.Controls.Add(this.scrollEastButton);
			this.scrollGroupBox.Controls.Add(this.scrollResetButton);
			this.scrollGroupBox.Controls.Add(this.scrollNorthButton);
			this.scrollGroupBox.Location = new System.Drawing.Point(722, 5);
			this.scrollGroupBox.Name = "scrollGroupBox";
			this.scrollGroupBox.Size = new System.Drawing.Size(149, 128);
			this.scrollGroupBox.TabIndex = 37;
			this.scrollGroupBox.TabStop = false;
			this.scrollGroupBox.Text = "Scroll";
			this.scrollGroupBox.Visible = false;
			// 
			// baddieSelectorButton7
			// 
			this.baddieSelectorButton7.Location = new System.Drawing.Point(37, 38);
			this.baddieSelectorButton7.Name = "baddieSelectorButton7";
			this.baddieSelectorButton7.Size = new System.Drawing.Size(33, 20);
			this.baddieSelectorButton7.TabIndex = 6;
			this.baddieSelectorButton7.Text = "7";
			this.baddieSelectorButton7.UseVisualStyleBackColor = true;
			// 
			// baddieSelectorButton8
			// 
			this.baddieSelectorButton8.Location = new System.Drawing.Point(37, 58);
			this.baddieSelectorButton8.Name = "baddieSelectorButton8";
			this.baddieSelectorButton8.Size = new System.Drawing.Size(33, 20);
			this.baddieSelectorButton8.TabIndex = 7;
			this.baddieSelectorButton8.Text = "8";
			this.baddieSelectorButton8.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(897, 736);
			this.Controls.Add(this.scrollGroupBox);
			this.Controls.Add(this.scaleSelectorPanel);
			this.Controls.Add(this.scaleLabel);
			this.Controls.Add(this.controlsGroupBox);
			this.Controls.Add(this.heroesSelectorPanel);
			this.Controls.Add(this.baddieSelectorPanel);
			this.Controls.Add(this.numberOfHeroesLabel);
			this.Controls.Add(this.numberOfBaddiesLabel);
			this.Controls.Add(this.gameOverButton);
			this.Controls.Add(this.scoreTextBox);
			this.Controls.Add(this.scoreLabel);
			this.Controls.Add(this.successfulFightButton);
			this.Controls.Add(this.failedFightButton);
			this.Controls.Add(this.outOfBoundsButton);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.Text = "Move And Fight";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.baddieSelectorPanel.ResumeLayout(false);
			this.heroesSelectorPanel.ResumeLayout(false);
			this.controlsGroupBox.ResumeLayout(false);
			this.scaleSelectorPanel.ResumeLayout(false);
			this.scrollGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.RadioButton baddieSelectorButton7;
		private System.Windows.Forms.RadioButton baddieSelectorButton8;
		private System.Windows.Forms.RadioButton scaleRadioButton_25;
		private System.Windows.Forms.GroupBox scrollGroupBox;
		private System.Windows.Forms.Button scrollWestButton;
		private System.Windows.Forms.Button scrollSouthButton;
		private System.Windows.Forms.Button scrollEastButton;
		private System.Windows.Forms.Button scrollResetButton;
		private System.Windows.Forms.Button scrollNorthButton;
		private System.Windows.Forms.RadioButton scaleRadioButton_50;
		private System.Windows.Forms.RadioButton scaleRadioButton_100;
		private System.Windows.Forms.Panel scaleSelectorPanel;
		private System.Windows.Forms.Label scaleLabel;
		private System.Windows.Forms.GroupBox controlsGroupBox;
		private System.Windows.Forms.Button useDoorButton;
		private System.Windows.Forms.Button activateHeroButton4;
		private System.Windows.Forms.Button activateHeroButton3;
		private System.Windows.Forms.RadioButton baddieSelectorButton4;
		private System.Windows.Forms.RadioButton baddieSelectorButton5;
		private System.Windows.Forms.RadioButton baddieSelectorButton6;
		private System.Windows.Forms.Button activateHeroButton1;
		private System.Windows.Forms.RadioButton heroSelectorButton4;
		private System.Windows.Forms.RadioButton heroSelectorButton1;
		private System.Windows.Forms.RadioButton heroSelectorButton2;
		private System.Windows.Forms.RadioButton heroSelectorButton3;
		private System.Windows.Forms.Panel heroesSelectorPanel;
		private System.Windows.Forms.RadioButton baddieSelectorButton1;
		private System.Windows.Forms.RadioButton baddieSelectorButton2;
		private System.Windows.Forms.RadioButton baddieSelectorButton3;
		private System.Windows.Forms.Panel baddieSelectorPanel;
		private System.Windows.Forms.Label numberOfHeroesLabel;
		private System.Windows.Forms.Label numberOfBaddiesLabel;
		private System.Windows.Forms.Timer gameClock;
		private System.Windows.Forms.Button gameOverButton;
		private System.Windows.Forms.Button activateHeroButton2;
		private System.Windows.Forms.TextBox scoreTextBox;
		private System.Windows.Forms.Label scoreLabel;
		private System.Windows.Forms.Button rangedCombatButton;
		private System.Windows.Forms.Button successfulFightButton;
		private System.Windows.Forms.Button rightTurnButton;
		private System.Windows.Forms.Button leftTurnButton;
		private System.Windows.Forms.Button failedFightButton;
		private System.Windows.Forms.Button outOfBoundsButton;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Button closeCombatButton;
		private System.Windows.Forms.Button forwardButton;
		private System.Windows.Forms.PictureBox pictureBox1;
		
		}
	}

