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
			this.numberOfBaddiesLabel = new System.Windows.Forms.Label();
			this.heroesSelectorLabel = new System.Windows.Forms.Label();
			this.baddieSelectorPanel = new System.Windows.Forms.Panel();
			this.baddieSelectorButton8 = new System.Windows.Forms.RadioButton();
			this.baddieSelectorButton7 = new System.Windows.Forms.RadioButton();
			this.baddieSelectorButton6 = new System.Windows.Forms.RadioButton();
			this.baddieSelectorButton5 = new System.Windows.Forms.RadioButton();
			this.baddieSelectorButton4 = new System.Windows.Forms.RadioButton();
			this.baddieSelectorButton3 = new System.Windows.Forms.RadioButton();
			this.baddieSelectorButton2 = new System.Windows.Forms.RadioButton();
			this.baddieSelectorButton1 = new System.Windows.Forms.RadioButton();
			this.heroesSelectorPanel = new System.Windows.Forms.Panel();
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
			this.pictureBox1.Size = new System.Drawing.Size(676, 723);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// combatCloseButton
			// 
			this.combatCloseButton.Image = global::Dungeons.Images.combat_close;
			this.combatCloseButton.Location = new System.Drawing.Point(16, 308);
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
			this.forwardButton.Location = new System.Drawing.Point(139, 146);
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
			this.outOfBoundsButton.Location = new System.Drawing.Point(699, 753);
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
			this.failedFightButton.Location = new System.Drawing.Point(887, 753);
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
			this.leftTurnButton.Location = new System.Drawing.Point(33, 167);
			this.leftTurnButton.Name = "leftTurnButton";
			this.leftTurnButton.Size = new System.Drawing.Size(100, 100);
			this.leftTurnButton.TabIndex = 11;
			this.leftTurnButton.UseVisualStyleBackColor = true;
			this.leftTurnButton.Click += new System.EventHandler(this.LeftTurnButtonClick);
			// 
			// rightTurnButton
			// 
			this.rightTurnButton.Image = global::Dungeons.Images.arrow_turn_right;
			this.rightTurnButton.Location = new System.Drawing.Point(245, 167);
			this.rightTurnButton.Name = "rightTurnButton";
			this.rightTurnButton.Size = new System.Drawing.Size(100, 100);
			this.rightTurnButton.TabIndex = 12;
			this.rightTurnButton.UseVisualStyleBackColor = true;
			this.rightTurnButton.Click += new System.EventHandler(this.RightTurnButtonClick);
			// 
			// successfulFightButton
			// 
			this.successfulFightButton.Location = new System.Drawing.Point(738, 683);
			this.successfulFightButton.Name = "successfulFightButton";
			this.successfulFightButton.Size = new System.Drawing.Size(269, 64);
			this.successfulFightButton.TabIndex = 13;
			this.successfulFightButton.Text = "YOU KILLED \'EM!\r\n\r\nClick to continue.";
			this.successfulFightButton.UseVisualStyleBackColor = true;
			this.successfulFightButton.Visible = false;
			this.successfulFightButton.Click += new System.EventHandler(this.SuccessfulFightButtonClick);
			// 
			// combatRangedButton
			// 
			this.combatRangedButton.Image = global::Dungeons.Images.combat_ranged;
			this.combatRangedButton.Location = new System.Drawing.Point(128, 308);
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
			// numberOfBaddiesLabel
			// 
			this.numberOfBaddiesLabel.Location = new System.Drawing.Point(21, 13);
			this.numberOfBaddiesLabel.Name = "numberOfBaddiesLabel";
			this.numberOfBaddiesLabel.Size = new System.Drawing.Size(103, 22);
			this.numberOfBaddiesLabel.TabIndex = 20;
			this.numberOfBaddiesLabel.Text = "Number of baddies";
			// 
			// heroesSelectorLabel
			// 
			this.heroesSelectorLabel.Location = new System.Drawing.Point(201, 12);
			this.heroesSelectorLabel.Name = "heroesSelectorLabel";
			this.heroesSelectorLabel.Size = new System.Drawing.Size(103, 22);
			this.heroesSelectorLabel.TabIndex = 22;
			this.heroesSelectorLabel.Text = "Select Heroes";
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
			// baddieSelectorButton8
			// 
			this.baddieSelectorButton8.Location = new System.Drawing.Point(37, 58);
			this.baddieSelectorButton8.Name = "baddieSelectorButton8";
			this.baddieSelectorButton8.Size = new System.Drawing.Size(33, 20);
			this.baddieSelectorButton8.TabIndex = 7;
			this.baddieSelectorButton8.Text = "8";
			this.baddieSelectorButton8.UseVisualStyleBackColor = true;
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
			this.heroesSelectorPanel.Controls.Add(this.wizardSelectCheckBox);
			this.heroesSelectorPanel.Controls.Add(this.dwarfSelectCheckBox);
			this.heroesSelectorPanel.Controls.Add(this.elfSelectCheckBox);
			this.heroesSelectorPanel.Controls.Add(this.warriorSelectCheckBox);
			this.heroesSelectorPanel.Location = new System.Drawing.Point(295, 7);
			this.heroesSelectorPanel.Name = "heroesSelectorPanel";
			this.heroesSelectorPanel.Size = new System.Drawing.Size(138, 81);
			this.heroesSelectorPanel.TabIndex = 24;
			// 
			// wizardSelectCheckBox
			// 
			this.wizardSelectCheckBox.Location = new System.Drawing.Point(25, 54);
			this.wizardSelectCheckBox.Name = "wizardSelectCheckBox";
			this.wizardSelectCheckBox.Size = new System.Drawing.Size(88, 18);
			this.wizardSelectCheckBox.TabIndex = 3;
			this.wizardSelectCheckBox.Text = "Wizard";
			this.wizardSelectCheckBox.UseVisualStyleBackColor = true;
			// 
			// dwarfSelectCheckBox
			// 
			this.dwarfSelectCheckBox.Location = new System.Drawing.Point(25, 21);
			this.dwarfSelectCheckBox.Name = "dwarfSelectCheckBox";
			this.dwarfSelectCheckBox.Size = new System.Drawing.Size(88, 18);
			this.dwarfSelectCheckBox.TabIndex = 2;
			this.dwarfSelectCheckBox.Text = "Dwarf";
			this.dwarfSelectCheckBox.UseVisualStyleBackColor = true;
			// 
			// elfSelectCheckBox
			// 
			this.elfSelectCheckBox.Location = new System.Drawing.Point(25, 37);
			this.elfSelectCheckBox.Name = "elfSelectCheckBox";
			this.elfSelectCheckBox.Size = new System.Drawing.Size(88, 18);
			this.elfSelectCheckBox.TabIndex = 1;
			this.elfSelectCheckBox.Text = "Elf";
			this.elfSelectCheckBox.UseVisualStyleBackColor = true;
			// 
			// warriorSelectCheckBox
			// 
			this.warriorSelectCheckBox.Checked = true;
			this.warriorSelectCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.warriorSelectCheckBox.Location = new System.Drawing.Point(25, 5);
			this.warriorSelectCheckBox.Name = "warriorSelectCheckBox";
			this.warriorSelectCheckBox.Size = new System.Drawing.Size(88, 18);
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
			this.useDoorButton.Location = new System.Drawing.Point(245, 371);
			this.useDoorButton.Name = "useDoorButton";
			this.useDoorButton.Size = new System.Drawing.Size(100, 100);
			this.useDoorButton.TabIndex = 29;
			this.useDoorButton.UseVisualStyleBackColor = true;
			this.useDoorButton.Visible = false;
			this.useDoorButton.Click += new System.EventHandler(this.UseDoorButtonClick);
			// 
			// controlsGroupBox
			// 
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
			this.controlsGroupBox.Size = new System.Drawing.Size(360, 535);
			this.controlsGroupBox.TabIndex = 30;
			this.controlsGroupBox.TabStop = false;
			this.controlsGroupBox.Text = "Controls";
			this.controlsGroupBox.Visible = false;
			// 
			// controls_movementLabel
			// 
			this.controls_movementLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.controls_movementLabel.Location = new System.Drawing.Point(133, 116);
			this.controls_movementLabel.Name = "controls_movementLabel";
			this.controls_movementLabel.Size = new System.Drawing.Size(112, 27);
			this.controls_movementLabel.TabIndex = 34;
			this.controls_movementLabel.Text = "MOVEMENT";
			// 
			// controls_actionsLabel
			// 
			this.controls_actionsLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.controls_actionsLabel.Location = new System.Drawing.Point(139, 278);
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
			this.spellAffectAllButton.Location = new System.Drawing.Point(128, 414);
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
			this.spellExplodeButton.Location = new System.Drawing.Point(16, 414);
			this.spellExplodeButton.Name = "spellExplodeButton";
			this.spellExplodeButton.Size = new System.Drawing.Size(100, 100);
			this.spellExplodeButton.TabIndex = 30;
			this.spellExplodeButton.UseVisualStyleBackColor = true;
			this.spellExplodeButton.Visible = false;
			this.spellExplodeButton.Click += new System.EventHandler(this.SpellExplodeButtonClick);
			// 
			// scaleLabel
			// 
			this.scaleLabel.Location = new System.Drawing.Point(742, 44);
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
			this.scaleSelectorPanel.Location = new System.Drawing.Point(703, 63);
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
			this.scrollGroupBox.Location = new System.Drawing.Point(891, 10);
			this.scrollGroupBox.Name = "scrollGroupBox";
			this.scrollGroupBox.Size = new System.Drawing.Size(149, 128);
			this.scrollGroupBox.TabIndex = 37;
			this.scrollGroupBox.TabStop = false;
			this.scrollGroupBox.Text = "Scroll";
			this.scrollGroupBox.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1077, 856);
			this.Controls.Add(this.scrollGroupBox);
			this.Controls.Add(this.scaleSelectorPanel);
			this.Controls.Add(this.scaleLabel);
			this.Controls.Add(this.controlsGroupBox);
			this.Controls.Add(this.heroesSelectorPanel);
			this.Controls.Add(this.baddieSelectorPanel);
			this.Controls.Add(this.heroesSelectorLabel);
			this.Controls.Add(this.numberOfBaddiesLabel);
			this.Controls.Add(this.gameOverButton);
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
		}
		private System.Windows.Forms.CheckBox warriorSelectCheckBox;
		private System.Windows.Forms.CheckBox elfSelectCheckBox;
		private System.Windows.Forms.CheckBox dwarfSelectCheckBox;
		private System.Windows.Forms.CheckBox wizardSelectCheckBox;
		private System.Windows.Forms.Button spellExplodeButton;
		private System.Windows.Forms.Button spellAffectAllButton;
		private System.Windows.Forms.Label controls_characterSelectLabel;
		private System.Windows.Forms.Label controls_actionsLabel;
		private System.Windows.Forms.Label controls_movementLabel;
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
		private System.Windows.Forms.Panel heroesSelectorPanel;
		private System.Windows.Forms.RadioButton baddieSelectorButton1;
		private System.Windows.Forms.RadioButton baddieSelectorButton2;
		private System.Windows.Forms.RadioButton baddieSelectorButton3;
		private System.Windows.Forms.Panel baddieSelectorPanel;
		private System.Windows.Forms.Label heroesSelectorLabel;
		private System.Windows.Forms.Label numberOfBaddiesLabel;
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

