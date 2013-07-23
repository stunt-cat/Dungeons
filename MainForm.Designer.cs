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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.combatCloseButton = new System.Windows.Forms.Button();
			this.forwardButton = new System.Windows.Forms.Button();
			this.startButton = new System.Windows.Forms.Button();
			this.outOfBoundsButton = new System.Windows.Forms.Button();
			this.failedFightButton = new System.Windows.Forms.Button();
			this.leftTurnButton = new System.Windows.Forms.Button();
			this.rightTurnButton = new System.Windows.Forms.Button();
			this.successfulFightButton = new System.Windows.Forms.Button();
			this.combatRangedButton = new System.Windows.Forms.Button();
			this.gameOverButton = new System.Windows.Forms.Button();
			this.heroesSelectorPanel = new System.Windows.Forms.Panel();
			this.heroesSelectorLabel = new System.Windows.Forms.Label();
			this.wizardSelectCheckBox = new System.Windows.Forms.CheckBox();
			this.dwarfSelectCheckBox = new System.Windows.Forms.CheckBox();
			this.elfSelectCheckBox = new System.Windows.Forms.CheckBox();
			this.warriorSelectCheckBox = new System.Windows.Forms.CheckBox();
			this.activateHeroButton2 = new System.Windows.Forms.Button();
			this.activateHeroButton1 = new System.Windows.Forms.Button();
			this.activateHeroButton3 = new System.Windows.Forms.Button();
			this.activateHeroButton4 = new System.Windows.Forms.Button();
			this.useDoorButton = new System.Windows.Forms.Button();
			this.controlsGroupBox = new System.Windows.Forms.GroupBox();
			this.ActiveHeroStatsLabel = new System.Windows.Forms.Label();
			this.ActiveHeroPictureBox = new System.Windows.Forms.PictureBox();
			this.controls_movementLabel = new System.Windows.Forms.Label();
			this.controls_actionsLabel = new System.Windows.Forms.Label();
			this.controls_characterSelectLabel = new System.Windows.Forms.Label();
			this.spellAffectAllButton = new System.Windows.Forms.Button();
			this.spellExplodeButton = new System.Windows.Forms.Button();
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
			this.difficultySelectorPanel = new System.Windows.Forms.Panel();
			this.difficultyLabel = new System.Windows.Forms.Label();
			this.difficultyRadioButton_easy = new System.Windows.Forms.RadioButton();
			this.difficultyRadioButton_medium = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.heroesSelectorPanel.SuspendLayout();
			this.controlsGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ActiveHeroPictureBox)).BeginInit();
			this.scaleSelectorPanel.SuspendLayout();
			this.scrollGroupBox.SuspendLayout();
			this.difficultySelectorPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Location = new System.Drawing.Point(12, 120);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(676, 793);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// combatCloseButton
			// 
			this.combatCloseButton.Image = global::Dungeons.Images.combat_close;
			this.combatCloseButton.Location = new System.Drawing.Point(21, 388);
			this.combatCloseButton.Name = "combatCloseButton";
			this.combatCloseButton.Size = new System.Drawing.Size(100, 100);
			this.combatCloseButton.TabIndex = 1;
			this.combatCloseButton.UseVisualStyleBackColor = true;
			this.combatCloseButton.Visible = false;
			this.combatCloseButton.Click += new System.EventHandler(this.FightButtonClick);
			// 
			// forwardButton
			// 
			this.forwardButton.Image = global::Dungeons.Images.arrow_north;
			this.forwardButton.Location = new System.Drawing.Point(133, 214);
			this.forwardButton.Name = "forwardButton";
			this.forwardButton.Size = new System.Drawing.Size(100, 100);
			this.forwardButton.TabIndex = 5;
			this.forwardButton.UseVisualStyleBackColor = true;
			this.forwardButton.Click += new System.EventHandler(this.ForwardButtonClick);
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(146, 241);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(409, 413);
			this.startButton.TabIndex = 8;
			this.startButton.Text = resources.GetString("startButton.Text");
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.StartButtonClick);
			// 
			// outOfBoundsButton
			// 
			this.outOfBoundsButton.Location = new System.Drawing.Point(715, 819);
			this.outOfBoundsButton.Name = "outOfBoundsButton";
			this.outOfBoundsButton.Size = new System.Drawing.Size(167, 90);
			this.outOfBoundsButton.TabIndex = 9;
			this.outOfBoundsButton.Text = "STOP IT you cretin.\r\nThere is an obstruction. Durr.\r\n\r\nClick to continue.";
			this.outOfBoundsButton.UseVisualStyleBackColor = true;
			this.outOfBoundsButton.Visible = false;
			this.outOfBoundsButton.Click += new System.EventHandler(this.OutOfBoundsButtonClick);
			// 
			// failedFightButton
			// 
			this.failedFightButton.Location = new System.Drawing.Point(903, 819);
			this.failedFightButton.Name = "failedFightButton";
			this.failedFightButton.Size = new System.Drawing.Size(167, 90);
			this.failedFightButton.TabIndex = 10;
			this.failedFightButton.Text = "You miss.\r\nWell done.\r\n\r\nClick to continue.";
			this.failedFightButton.UseVisualStyleBackColor = true;
			this.failedFightButton.Visible = false;
			this.failedFightButton.Click += new System.EventHandler(this.FailedFightButtonClick);
			// 
			// leftTurnButton
			// 
			this.leftTurnButton.Image = global::Dungeons.Images.arrow_turn_left;
			this.leftTurnButton.Location = new System.Drawing.Point(27, 235);
			this.leftTurnButton.Name = "leftTurnButton";
			this.leftTurnButton.Size = new System.Drawing.Size(100, 100);
			this.leftTurnButton.TabIndex = 11;
			this.leftTurnButton.UseVisualStyleBackColor = true;
			this.leftTurnButton.Click += new System.EventHandler(this.LeftTurnButtonClick);
			// 
			// rightTurnButton
			// 
			this.rightTurnButton.Image = global::Dungeons.Images.arrow_turn_right;
			this.rightTurnButton.Location = new System.Drawing.Point(239, 235);
			this.rightTurnButton.Name = "rightTurnButton";
			this.rightTurnButton.Size = new System.Drawing.Size(100, 100);
			this.rightTurnButton.TabIndex = 12;
			this.rightTurnButton.UseVisualStyleBackColor = true;
			this.rightTurnButton.Click += new System.EventHandler(this.RightTurnButtonClick);
			// 
			// successfulFightButton
			// 
			this.successfulFightButton.Location = new System.Drawing.Point(754, 749);
			this.successfulFightButton.Name = "successfulFightButton";
			this.successfulFightButton.Size = new System.Drawing.Size(269, 64);
			this.successfulFightButton.TabIndex = 13;
			this.successfulFightButton.Text = "YOU HIT \'EM!\r\n\r\nClick to continue.";
			this.successfulFightButton.UseVisualStyleBackColor = true;
			this.successfulFightButton.Visible = false;
			this.successfulFightButton.Click += new System.EventHandler(this.SuccessfulFightButtonClick);
			// 
			// combatRangedButton
			// 
			this.combatRangedButton.Image = global::Dungeons.Images.combat_ranged;
			this.combatRangedButton.Location = new System.Drawing.Point(133, 388);
			this.combatRangedButton.Name = "combatRangedButton";
			this.combatRangedButton.Size = new System.Drawing.Size(100, 100);
			this.combatRangedButton.TabIndex = 14;
			this.combatRangedButton.UseVisualStyleBackColor = true;
			this.combatRangedButton.Visible = false;
			this.combatRangedButton.Click += new System.EventHandler(this.RangedCombatButtonClick);
			// 
			// gameOverButton
			// 
			this.gameOverButton.Location = new System.Drawing.Point(159, 256);
			this.gameOverButton.Name = "gameOverButton";
			this.gameOverButton.Size = new System.Drawing.Size(382, 383);
			this.gameOverButton.TabIndex = 18;
			this.gameOverButton.UseVisualStyleBackColor = true;
			this.gameOverButton.Visible = false;
			this.gameOverButton.Click += new System.EventHandler(this.GameOverButtonClick);
			// 
			// heroesSelectorPanel
			// 
			this.heroesSelectorPanel.Controls.Add(this.heroesSelectorLabel);
			this.heroesSelectorPanel.Controls.Add(this.wizardSelectCheckBox);
			this.heroesSelectorPanel.Controls.Add(this.dwarfSelectCheckBox);
			this.heroesSelectorPanel.Controls.Add(this.elfSelectCheckBox);
			this.heroesSelectorPanel.Controls.Add(this.warriorSelectCheckBox);
			this.heroesSelectorPanel.Location = new System.Drawing.Point(75, 12);
			this.heroesSelectorPanel.Name = "heroesSelectorPanel";
			this.heroesSelectorPanel.Size = new System.Drawing.Size(188, 76);
			this.heroesSelectorPanel.TabIndex = 24;
			// 
			// heroesSelectorLabel
			// 
			this.heroesSelectorLabel.Location = new System.Drawing.Point(52, 7);
			this.heroesSelectorLabel.Name = "heroesSelectorLabel";
			this.heroesSelectorLabel.Size = new System.Drawing.Size(81, 22);
			this.heroesSelectorLabel.TabIndex = 23;
			this.heroesSelectorLabel.Text = "Select Heroes";
			// 
			// wizardSelectCheckBox
			// 
			this.wizardSelectCheckBox.Location = new System.Drawing.Point(100, 53);
			this.wizardSelectCheckBox.Name = "wizardSelectCheckBox";
			this.wizardSelectCheckBox.Size = new System.Drawing.Size(71, 18);
			this.wizardSelectCheckBox.TabIndex = 3;
			this.wizardSelectCheckBox.Text = "Wizard";
			this.wizardSelectCheckBox.UseVisualStyleBackColor = true;
			// 
			// dwarfSelectCheckBox
			// 
			this.dwarfSelectCheckBox.Location = new System.Drawing.Point(20, 52);
			this.dwarfSelectCheckBox.Name = "dwarfSelectCheckBox";
			this.dwarfSelectCheckBox.Size = new System.Drawing.Size(74, 18);
			this.dwarfSelectCheckBox.TabIndex = 2;
			this.dwarfSelectCheckBox.Text = "Dwarf";
			this.dwarfSelectCheckBox.UseVisualStyleBackColor = true;
			// 
			// elfSelectCheckBox
			// 
			this.elfSelectCheckBox.Location = new System.Drawing.Point(100, 32);
			this.elfSelectCheckBox.Name = "elfSelectCheckBox";
			this.elfSelectCheckBox.Size = new System.Drawing.Size(71, 18);
			this.elfSelectCheckBox.TabIndex = 1;
			this.elfSelectCheckBox.Text = "Elf";
			this.elfSelectCheckBox.UseVisualStyleBackColor = true;
			// 
			// warriorSelectCheckBox
			// 
			this.warriorSelectCheckBox.Checked = true;
			this.warriorSelectCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.warriorSelectCheckBox.Location = new System.Drawing.Point(20, 30);
			this.warriorSelectCheckBox.Name = "warriorSelectCheckBox";
			this.warriorSelectCheckBox.Size = new System.Drawing.Size(74, 18);
			this.warriorSelectCheckBox.TabIndex = 0;
			this.warriorSelectCheckBox.Text = "Warrior";
			this.warriorSelectCheckBox.UseVisualStyleBackColor = true;
			// 
			// activateHeroButton2
			// 
			this.activateHeroButton2.Enabled = false;
			this.activateHeroButton2.Location = new System.Drawing.Point(133, 46);
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
			this.activateHeroButton1.Location = new System.Drawing.Point(77, 46);
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
			this.activateHeroButton3.Location = new System.Drawing.Point(189, 46);
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
			this.activateHeroButton4.Location = new System.Drawing.Point(245, 46);
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
			this.useDoorButton.Location = new System.Drawing.Point(250, 451);
			this.useDoorButton.Name = "useDoorButton";
			this.useDoorButton.Size = new System.Drawing.Size(100, 100);
			this.useDoorButton.TabIndex = 29;
			this.useDoorButton.UseVisualStyleBackColor = true;
			this.useDoorButton.Visible = false;
			this.useDoorButton.Click += new System.EventHandler(this.UseDoorButtonClick);
			// 
			// controlsGroupBox
			// 
			this.controlsGroupBox.Controls.Add(this.ActiveHeroStatsLabel);
			this.controlsGroupBox.Controls.Add(this.ActiveHeroPictureBox);
			this.controlsGroupBox.Controls.Add(this.controls_movementLabel);
			this.controlsGroupBox.Controls.Add(this.controls_actionsLabel);
			this.controlsGroupBox.Controls.Add(this.controls_characterSelectLabel);
			this.controlsGroupBox.Controls.Add(this.spellAffectAllButton);
			this.controlsGroupBox.Controls.Add(this.spellExplodeButton);
			this.controlsGroupBox.Controls.Add(this.useDoorButton);
			this.controlsGroupBox.Controls.Add(this.activateHeroButton4);
			this.controlsGroupBox.Controls.Add(this.activateHeroButton3);
			this.controlsGroupBox.Controls.Add(this.activateHeroButton1);
			this.controlsGroupBox.Controls.Add(this.activateHeroButton2);
			this.controlsGroupBox.Controls.Add(this.combatRangedButton);
			this.controlsGroupBox.Controls.Add(this.rightTurnButton);
			this.controlsGroupBox.Controls.Add(this.leftTurnButton);
			this.controlsGroupBox.Controls.Add(this.forwardButton);
			this.controlsGroupBox.Controls.Add(this.combatCloseButton);
			this.controlsGroupBox.Location = new System.Drawing.Point(694, 142);
			this.controlsGroupBox.Name = "controlsGroupBox";
			this.controlsGroupBox.Size = new System.Drawing.Size(360, 601);
			this.controlsGroupBox.TabIndex = 30;
			this.controlsGroupBox.TabStop = false;
			this.controlsGroupBox.Text = "Controls";
			this.controlsGroupBox.Visible = false;
			// 
			// ActiveHeroStatsLabel
			// 
			this.ActiveHeroStatsLabel.Location = new System.Drawing.Point(186, 126);
			this.ActiveHeroStatsLabel.Name = "ActiveHeroStatsLabel";
			this.ActiveHeroStatsLabel.Size = new System.Drawing.Size(108, 37);
			this.ActiveHeroStatsLabel.TabIndex = 36;
			this.ActiveHeroStatsLabel.Text = "Wounds";
			// 
			// ActiveHeroPictureBox
			// 
			this.ActiveHeroPictureBox.Location = new System.Drawing.Point(119, 114);
			this.ActiveHeroPictureBox.Name = "ActiveHeroPictureBox";
			this.ActiveHeroPictureBox.Size = new System.Drawing.Size(50, 50);
			this.ActiveHeroPictureBox.TabIndex = 35;
			this.ActiveHeroPictureBox.TabStop = false;
			// 
			// controls_movementLabel
			// 
			this.controls_movementLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.controls_movementLabel.Location = new System.Drawing.Point(127, 184);
			this.controls_movementLabel.Name = "controls_movementLabel";
			this.controls_movementLabel.Size = new System.Drawing.Size(112, 27);
			this.controls_movementLabel.TabIndex = 34;
			this.controls_movementLabel.Text = "MOVEMENT";
			// 
			// controls_actionsLabel
			// 
			this.controls_actionsLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.controls_actionsLabel.Location = new System.Drawing.Point(133, 346);
			this.controls_actionsLabel.Name = "controls_actionsLabel";
			this.controls_actionsLabel.Size = new System.Drawing.Size(103, 27);
			this.controls_actionsLabel.TabIndex = 33;
			this.controls_actionsLabel.Text = "ACTIONS";
			// 
			// controls_characterSelectLabel
			// 
			this.controls_characterSelectLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.controls_characterSelectLabel.Location = new System.Drawing.Point(92, 16);
			this.controls_characterSelectLabel.Name = "controls_characterSelectLabel";
			this.controls_characterSelectLabel.Size = new System.Drawing.Size(181, 27);
			this.controls_characterSelectLabel.TabIndex = 32;
			this.controls_characterSelectLabel.Text = "CHARACTER SELECT";
			// 
			// spellAffectAllButton
			// 
			this.spellAffectAllButton.Image = global::Dungeons.Images.spell_affectAll;
			this.spellAffectAllButton.Location = new System.Drawing.Point(133, 494);
			this.spellAffectAllButton.Name = "spellAffectAllButton";
			this.spellAffectAllButton.Size = new System.Drawing.Size(100, 100);
			this.spellAffectAllButton.TabIndex = 31;
			this.spellAffectAllButton.UseVisualStyleBackColor = true;
			this.spellAffectAllButton.Visible = false;
			this.spellAffectAllButton.Click += new System.EventHandler(this.SpellAffectAllButtonClick);
			// 
			// spellExplodeButton
			// 
			this.spellExplodeButton.Image = global::Dungeons.Images.spell_explode;
			this.spellExplodeButton.Location = new System.Drawing.Point(21, 494);
			this.spellExplodeButton.Name = "spellExplodeButton";
			this.spellExplodeButton.Size = new System.Drawing.Size(100, 100);
			this.spellExplodeButton.TabIndex = 30;
			this.spellExplodeButton.UseVisualStyleBackColor = true;
			this.spellExplodeButton.Visible = false;
			this.spellExplodeButton.Click += new System.EventHandler(this.SpellExplodeButtonClick);
			// 
			// scaleLabel
			// 
			this.scaleLabel.Location = new System.Drawing.Point(58, 2);
			this.scaleLabel.Name = "scaleLabel";
			this.scaleLabel.Size = new System.Drawing.Size(52, 22);
			this.scaleLabel.TabIndex = 31;
			this.scaleLabel.Text = "Scale";
			// 
			// scaleSelectorPanel
			// 
			this.scaleSelectorPanel.Controls.Add(this.scaleRadioButton_25);
			this.scaleSelectorPanel.Controls.Add(this.scaleRadioButton_100);
			this.scaleSelectorPanel.Controls.Add(this.scaleRadioButton_50);
			this.scaleSelectorPanel.Controls.Add(this.scaleLabel);
			this.scaleSelectorPanel.Location = new System.Drawing.Point(703, 44);
			this.scaleSelectorPanel.Name = "scaleSelectorPanel";
			this.scaleSelectorPanel.Size = new System.Drawing.Size(167, 47);
			this.scaleSelectorPanel.TabIndex = 25;
			this.scaleSelectorPanel.Visible = false;
			// 
			// scaleRadioButton_25
			// 
			this.scaleRadioButton_25.Location = new System.Drawing.Point(8, 16);
			this.scaleRadioButton_25.Name = "scaleRadioButton_25";
			this.scaleRadioButton_25.Size = new System.Drawing.Size(49, 25);
			this.scaleRadioButton_25.TabIndex = 2;
			this.scaleRadioButton_25.Text = "25%";
			this.scaleRadioButton_25.UseVisualStyleBackColor = true;
			this.scaleRadioButton_25.CheckedChanged += new System.EventHandler(this.ScaleRadioButton_25CheckedChanged);
			// 
			// scaleRadioButton_100
			// 
			this.scaleRadioButton_100.Checked = true;
			this.scaleRadioButton_100.Location = new System.Drawing.Point(110, 18);
			this.scaleRadioButton_100.Name = "scaleRadioButton_100";
			this.scaleRadioButton_100.Size = new System.Drawing.Size(54, 21);
			this.scaleRadioButton_100.TabIndex = 1;
			this.scaleRadioButton_100.TabStop = true;
			this.scaleRadioButton_100.Text = "100%";
			this.scaleRadioButton_100.UseVisualStyleBackColor = true;
			this.scaleRadioButton_100.CheckedChanged += new System.EventHandler(this.ScaleRadioButton_100CheckedChanged);
			// 
			// scaleRadioButton_50
			// 
			this.scaleRadioButton_50.Location = new System.Drawing.Point(58, 16);
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
			this.scrollGroupBox.Location = new System.Drawing.Point(891, 10);
			this.scrollGroupBox.Name = "scrollGroupBox";
			this.scrollGroupBox.Size = new System.Drawing.Size(149, 128);
			this.scrollGroupBox.TabIndex = 37;
			this.scrollGroupBox.TabStop = false;
			this.scrollGroupBox.Text = "Scroll";
			this.scrollGroupBox.Visible = false;
			// 
			// difficultySelectorPanel
			// 
			this.difficultySelectorPanel.Controls.Add(this.difficultyLabel);
			this.difficultySelectorPanel.Controls.Add(this.difficultyRadioButton_easy);
			this.difficultySelectorPanel.Controls.Add(this.difficultyRadioButton_medium);
			this.difficultySelectorPanel.Location = new System.Drawing.Point(293, 22);
			this.difficultySelectorPanel.Name = "difficultySelectorPanel";
			this.difficultySelectorPanel.Size = new System.Drawing.Size(144, 60);
			this.difficultySelectorPanel.TabIndex = 26;
			// 
			// difficultyLabel
			// 
			this.difficultyLabel.Location = new System.Drawing.Point(30, 5);
			this.difficultyLabel.Name = "difficultyLabel";
			this.difficultyLabel.Size = new System.Drawing.Size(87, 22);
			this.difficultyLabel.TabIndex = 32;
			this.difficultyLabel.Text = "Select Difficulty";
			// 
			// difficultyRadioButton_easy
			// 
			this.difficultyRadioButton_easy.Checked = true;
			this.difficultyRadioButton_easy.Location = new System.Drawing.Point(14, 24);
			this.difficultyRadioButton_easy.Name = "difficultyRadioButton_easy";
			this.difficultyRadioButton_easy.Size = new System.Drawing.Size(49, 25);
			this.difficultyRadioButton_easy.TabIndex = 2;
			this.difficultyRadioButton_easy.TabStop = true;
			this.difficultyRadioButton_easy.Text = "Easy";
			this.difficultyRadioButton_easy.UseVisualStyleBackColor = true;
			// 
			// difficultyRadioButton_medium
			// 
			this.difficultyRadioButton_medium.Location = new System.Drawing.Point(64, 24);
			this.difficultyRadioButton_medium.Name = "difficultyRadioButton_medium";
			this.difficultyRadioButton_medium.Size = new System.Drawing.Size(64, 25);
			this.difficultyRadioButton_medium.TabIndex = 0;
			this.difficultyRadioButton_medium.Text = "Medium";
			this.difficultyRadioButton_medium.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1101, 925);
			this.Controls.Add(this.difficultySelectorPanel);
			this.Controls.Add(this.scrollGroupBox);
			this.Controls.Add(this.scaleSelectorPanel);
			this.Controls.Add(this.controlsGroupBox);
			this.Controls.Add(this.heroesSelectorPanel);
			this.Controls.Add(this.gameOverButton);
			this.Controls.Add(this.successfulFightButton);
			this.Controls.Add(this.failedFightButton);
			this.Controls.Add(this.outOfBoundsButton);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.Text = "Move And Fight";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.heroesSelectorPanel.ResumeLayout(false);
			this.controlsGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ActiveHeroPictureBox)).EndInit();
			this.scaleSelectorPanel.ResumeLayout(false);
			this.scrollGroupBox.ResumeLayout(false);
			this.difficultySelectorPanel.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.RadioButton difficultyRadioButton_medium;
		private System.Windows.Forms.RadioButton difficultyRadioButton_easy;
		private System.Windows.Forms.Label difficultyLabel;
		private System.Windows.Forms.Panel difficultySelectorPanel;
		private System.Windows.Forms.Label ActiveHeroStatsLabel;
		private System.Windows.Forms.PictureBox ActiveHeroPictureBox;
		private System.Windows.Forms.CheckBox warriorSelectCheckBox;
		private System.Windows.Forms.CheckBox elfSelectCheckBox;
		private System.Windows.Forms.CheckBox dwarfSelectCheckBox;
		private System.Windows.Forms.CheckBox wizardSelectCheckBox;
		private System.Windows.Forms.Button spellExplodeButton;
		private System.Windows.Forms.Button spellAffectAllButton;
		private System.Windows.Forms.Label controls_characterSelectLabel;
		private System.Windows.Forms.Label controls_actionsLabel;
		private System.Windows.Forms.Label controls_movementLabel;
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
		private System.Windows.Forms.Button activateHeroButton1;
		private System.Windows.Forms.Panel heroesSelectorPanel;
		private System.Windows.Forms.Label heroesSelectorLabel;
		private System.Windows.Forms.Button gameOverButton;
		private System.Windows.Forms.Button activateHeroButton2;
		private System.Windows.Forms.Button combatRangedButton;
		private System.Windows.Forms.Button successfulFightButton;
		private System.Windows.Forms.Button rightTurnButton;
		private System.Windows.Forms.Button leftTurnButton;
		private System.Windows.Forms.Button failedFightButton;
		private System.Windows.Forms.Button outOfBoundsButton;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Button combatCloseButton;
		private System.Windows.Forms.Button forwardButton;
		private System.Windows.Forms.PictureBox pictureBox1;
		
		}
	}

