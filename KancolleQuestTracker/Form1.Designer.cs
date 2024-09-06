namespace KancolleQuestTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ImportQuests = new System.Windows.Forms.Button();
            this.mainDiagramControl = new Northwoods.Go.WinForms.DiagramControl();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRemoveFilter = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblRequirenments = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblQuestUnlock = new System.Windows.Forms.Label();
            this.lblQuestRequirement = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblRewardBauxite = new System.Windows.Forms.Label();
            this.lblRewardSteel = new System.Windows.Forms.Label();
            this.lblRewardAmmo = new System.Windows.Forms.Label();
            this.lblRewardFuel = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pFuel = new System.Windows.Forms.PictureBox();
            this.lblReward6 = new System.Windows.Forms.Label();
            this.lblReward5 = new System.Windows.Forms.Label();
            this.lblReward4 = new System.Windows.Forms.Label();
            this.lblReward3 = new System.Windows.Forms.Label();
            this.lblReward2 = new System.Windows.Forms.Label();
            this.lblReward1 = new System.Windows.Forms.Label();
            this.picReward6 = new System.Windows.Forms.PictureBox();
            this.picReward5 = new System.Windows.Forms.PictureBox();
            this.picReward4 = new System.Windows.Forms.PictureBox();
            this.picReward3 = new System.Windows.Forms.PictureBox();
            this.picReward2 = new System.Windows.Forms.PictureBox();
            this.picReward1 = new System.Windows.Forms.PictureBox();
            this.lblRewards = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linklblToWiki = new System.Windows.Forms.LinkLabel();
            this.lblQuestName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuestNotComplete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblQuest = new System.Windows.Forms.Label();
            this.btnSubmitQuests = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFuel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReward6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReward5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReward4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReward3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReward2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReward1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImportQuests
            // 
            this.ImportQuests.Location = new System.Drawing.Point(12, 12);
            this.ImportQuests.Name = "ImportQuests";
            this.ImportQuests.Size = new System.Drawing.Size(192, 55);
            this.ImportQuests.TabIndex = 0;
            this.ImportQuests.Text = "Import Quests From Wiki";
            this.ImportQuests.UseVisualStyleBackColor = true;
            this.ImportQuests.Click += new System.EventHandler(this.ImportQuests_Click);
            // 
            // mainDiagramControl
            // 
            this.mainDiagramControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainDiagramControl.BackColor = System.Drawing.Color.PaleTurquoise;
            this.mainDiagramControl.Location = new System.Drawing.Point(12, 239);
            this.mainDiagramControl.Name = "mainDiagramControl";
            this.mainDiagramControl.Size = new System.Drawing.Size(1606, 823);
            this.mainDiagramControl.TabIndex = 1;
            // 
            // btnPopulate
            // 
            this.btnPopulate.Enabled = false;
            this.btnPopulate.Location = new System.Drawing.Point(330, 12);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(192, 55);
            this.btnPopulate.TabIndex = 2;
            this.btnPopulate.Text = "Populate Viewer";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(1326, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(95, 20);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(1427, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(191, 26);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRemoveFilter
            // 
            this.btnRemoveFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveFilter.Enabled = false;
            this.btnRemoveFilter.Location = new System.Drawing.Point(1427, 44);
            this.btnRemoveFilter.Name = "btnRemoveFilter";
            this.btnRemoveFilter.Size = new System.Drawing.Size(191, 23);
            this.btnRemoveFilter.TabIndex = 7;
            this.btnRemoveFilter.Text = "RemoveFilter";
            this.btnRemoveFilter.UseVisualStyleBackColor = true;
            this.btnRemoveFilter.Click += new System.EventHandler(this.txtRemoveFilter_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PeachPuff;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Location = new System.Drawing.Point(12, 74);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1606, 159);
            this.panel5.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel6.Controls.Add(this.lblRequirenments);
            this.panel6.Location = new System.Drawing.Point(214, 84);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(766, 72);
            this.panel6.TabIndex = 19;
            // 
            // lblRequirenments
            // 
            this.lblRequirenments.AutoSize = true;
            this.lblRequirenments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRequirenments.Location = new System.Drawing.Point(3, 5);
            this.lblRequirenments.Name = "lblRequirenments";
            this.lblRequirenments.Size = new System.Drawing.Size(110, 20);
            this.lblRequirenments.TabIndex = 16;
            this.lblRequirenments.Text = "Requirenment";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Controls.Add(this.lblQuestUnlock);
            this.panel4.Controls.Add(this.lblQuestRequirement);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(4, 84);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(204, 72);
            this.panel4.TabIndex = 18;
            // 
            // lblQuestUnlock
            // 
            this.lblQuestUnlock.AutoSize = true;
            this.lblQuestUnlock.Location = new System.Drawing.Point(58, 45);
            this.lblQuestUnlock.Name = "lblQuestUnlock";
            this.lblQuestUnlock.Size = new System.Drawing.Size(38, 13);
            this.lblQuestUnlock.TabIndex = 3;
            this.lblQuestUnlock.Text = "quests";
            // 
            // lblQuestRequirement
            // 
            this.lblQuestRequirement.AutoSize = true;
            this.lblQuestRequirement.Location = new System.Drawing.Point(58, 13);
            this.lblQuestRequirement.Name = "lblQuestRequirement";
            this.lblQuestRequirement.Size = new System.Drawing.Size(38, 13);
            this.lblQuestRequirement.TabIndex = 2;
            this.lblQuestRequirement.Text = "quests";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Unlocks:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Requires:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3.Controls.Add(this.lblRewardBauxite);
            this.panel3.Controls.Add(this.lblRewardSteel);
            this.panel3.Controls.Add(this.lblRewardAmmo);
            this.panel3.Controls.Add(this.lblRewardFuel);
            this.panel3.Controls.Add(this.pictureBox9);
            this.panel3.Controls.Add(this.pictureBox8);
            this.panel3.Controls.Add(this.pictureBox7);
            this.panel3.Controls.Add(this.pFuel);
            this.panel3.Controls.Add(this.lblReward6);
            this.panel3.Controls.Add(this.lblReward5);
            this.panel3.Controls.Add(this.lblReward4);
            this.panel3.Controls.Add(this.lblReward3);
            this.panel3.Controls.Add(this.lblReward2);
            this.panel3.Controls.Add(this.lblReward1);
            this.panel3.Controls.Add(this.picReward6);
            this.panel3.Controls.Add(this.picReward5);
            this.panel3.Controls.Add(this.picReward4);
            this.panel3.Controls.Add(this.picReward3);
            this.panel3.Controls.Add(this.picReward2);
            this.panel3.Controls.Add(this.picReward1);
            this.panel3.Controls.Add(this.lblRewards);
            this.panel3.Location = new System.Drawing.Point(986, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(617, 152);
            this.panel3.TabIndex = 19;
            // 
            // lblRewardBauxite
            // 
            this.lblRewardBauxite.AutoSize = true;
            this.lblRewardBauxite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblRewardBauxite.Location = new System.Drawing.Point(392, 12);
            this.lblRewardBauxite.Name = "lblRewardBauxite";
            this.lblRewardBauxite.Size = new System.Drawing.Size(41, 13);
            this.lblRewardBauxite.TabIndex = 36;
            this.lblRewardBauxite.Text = "bauxite";
            this.lblRewardBauxite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRewardSteel
            // 
            this.lblRewardSteel.AutoSize = true;
            this.lblRewardSteel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblRewardSteel.Location = new System.Drawing.Point(322, 12);
            this.lblRewardSteel.Name = "lblRewardSteel";
            this.lblRewardSteel.Size = new System.Drawing.Size(29, 13);
            this.lblRewardSteel.TabIndex = 35;
            this.lblRewardSteel.Text = "steel";
            this.lblRewardSteel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRewardAmmo
            // 
            this.lblRewardAmmo.AutoSize = true;
            this.lblRewardAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblRewardAmmo.Location = new System.Drawing.Point(254, 12);
            this.lblRewardAmmo.Name = "lblRewardAmmo";
            this.lblRewardAmmo.Size = new System.Drawing.Size(35, 13);
            this.lblRewardAmmo.TabIndex = 34;
            this.lblRewardAmmo.Text = "ammo";
            this.lblRewardAmmo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRewardFuel
            // 
            this.lblRewardFuel.AutoSize = true;
            this.lblRewardFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblRewardFuel.Location = new System.Drawing.Point(180, 12);
            this.lblRewardFuel.Name = "lblRewardFuel";
            this.lblRewardFuel.Size = new System.Drawing.Size(24, 13);
            this.lblRewardFuel.TabIndex = 33;
            this.lblRewardFuel.Text = "fuel";
            this.lblRewardFuel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::KancolleQuestTracker.Properties.Resources.Bauxite;
            this.pictureBox9.Location = new System.Drawing.Point(360, 4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(26, 30);
            this.pictureBox9.TabIndex = 32;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::KancolleQuestTracker.Properties.Resources.Steel;
            this.pictureBox8.Location = new System.Drawing.Point(293, 4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(26, 30);
            this.pictureBox8.TabIndex = 31;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::KancolleQuestTracker.Properties.Resources.Ammo;
            this.pictureBox7.Location = new System.Drawing.Point(222, 4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(26, 30);
            this.pictureBox7.TabIndex = 30;
            this.pictureBox7.TabStop = false;
            // 
            // pFuel
            // 
            this.pFuel.Image = global::KancolleQuestTracker.Properties.Resources.Fuel;
            this.pFuel.Location = new System.Drawing.Point(148, 4);
            this.pFuel.Name = "pFuel";
            this.pFuel.Size = new System.Drawing.Size(26, 30);
            this.pFuel.TabIndex = 29;
            this.pFuel.TabStop = false;
            // 
            // lblReward6
            // 
            this.lblReward6.AutoSize = true;
            this.lblReward6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblReward6.Location = new System.Drawing.Point(543, 100);
            this.lblReward6.Name = "lblReward6";
            this.lblReward6.Size = new System.Drawing.Size(45, 13);
            this.lblReward6.TabIndex = 28;
            this.lblReward6.Text = "reward1";
            this.lblReward6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReward5
            // 
            this.lblReward5.AutoSize = true;
            this.lblReward5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblReward5.Location = new System.Drawing.Point(430, 100);
            this.lblReward5.Name = "lblReward5";
            this.lblReward5.Size = new System.Drawing.Size(45, 13);
            this.lblReward5.TabIndex = 27;
            this.lblReward5.Text = "reward1";
            this.lblReward5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReward4
            // 
            this.lblReward4.AutoSize = true;
            this.lblReward4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblReward4.Location = new System.Drawing.Point(324, 100);
            this.lblReward4.Name = "lblReward4";
            this.lblReward4.Size = new System.Drawing.Size(45, 13);
            this.lblReward4.TabIndex = 26;
            this.lblReward4.Text = "reward1";
            this.lblReward4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReward3
            // 
            this.lblReward3.AutoSize = true;
            this.lblReward3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblReward3.Location = new System.Drawing.Point(221, 100);
            this.lblReward3.Name = "lblReward3";
            this.lblReward3.Size = new System.Drawing.Size(45, 13);
            this.lblReward3.TabIndex = 25;
            this.lblReward3.Text = "reward1";
            this.lblReward3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReward2
            // 
            this.lblReward2.AutoSize = true;
            this.lblReward2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblReward2.Location = new System.Drawing.Point(112, 100);
            this.lblReward2.Name = "lblReward2";
            this.lblReward2.Size = new System.Drawing.Size(45, 13);
            this.lblReward2.TabIndex = 24;
            this.lblReward2.Text = "reward1";
            this.lblReward2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReward1
            // 
            this.lblReward1.AutoSize = true;
            this.lblReward1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblReward1.Location = new System.Drawing.Point(4, 100);
            this.lblReward1.Name = "lblReward1";
            this.lblReward1.Size = new System.Drawing.Size(45, 13);
            this.lblReward1.TabIndex = 17;
            this.lblReward1.Text = "reward1";
            this.lblReward1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picReward6
            // 
            this.picReward6.Location = new System.Drawing.Point(539, 33);
            this.picReward6.Name = "picReward6";
            this.picReward6.Size = new System.Drawing.Size(64, 64);
            this.picReward6.TabIndex = 23;
            this.picReward6.TabStop = false;
            // 
            // picReward5
            // 
            this.picReward5.Location = new System.Drawing.Point(433, 33);
            this.picReward5.Name = "picReward5";
            this.picReward5.Size = new System.Drawing.Size(64, 64);
            this.picReward5.TabIndex = 22;
            this.picReward5.TabStop = false;
            // 
            // picReward4
            // 
            this.picReward4.Location = new System.Drawing.Point(327, 33);
            this.picReward4.Name = "picReward4";
            this.picReward4.Size = new System.Drawing.Size(64, 64);
            this.picReward4.TabIndex = 21;
            this.picReward4.TabStop = false;
            // 
            // picReward3
            // 
            this.picReward3.Location = new System.Drawing.Point(221, 33);
            this.picReward3.Name = "picReward3";
            this.picReward3.Size = new System.Drawing.Size(64, 64);
            this.picReward3.TabIndex = 20;
            this.picReward3.TabStop = false;
            // 
            // picReward2
            // 
            this.picReward2.Location = new System.Drawing.Point(115, 33);
            this.picReward2.Name = "picReward2";
            this.picReward2.Size = new System.Drawing.Size(64, 64);
            this.picReward2.TabIndex = 19;
            this.picReward2.TabStop = false;
            // 
            // picReward1
            // 
            this.picReward1.Location = new System.Drawing.Point(7, 33);
            this.picReward1.Name = "picReward1";
            this.picReward1.Size = new System.Drawing.Size(64, 64);
            this.picReward1.TabIndex = 18;
            this.picReward1.TabStop = false;
            // 
            // lblRewards
            // 
            this.lblRewards.AutoSize = true;
            this.lblRewards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRewards.Location = new System.Drawing.Point(3, 0);
            this.lblRewards.Name = "lblRewards";
            this.lblRewards.Size = new System.Drawing.Size(139, 20);
            this.lblRewards.TabIndex = 17;
            this.lblRewards.Text = "Possible Rewards:";
            this.lblRewards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.linklblToWiki);
            this.panel2.Controls.Add(this.lblQuestName);
            this.panel2.Location = new System.Drawing.Point(214, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 74);
            this.panel2.TabIndex = 18;
            // 
            // linklblToWiki
            // 
            this.linklblToWiki.AutoSize = true;
            this.linklblToWiki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linklblToWiki.Location = new System.Drawing.Point(666, 12);
            this.linklblToWiki.Name = "linklblToWiki";
            this.linklblToWiki.Size = new System.Drawing.Size(85, 20);
            this.linklblToWiki.TabIndex = 16;
            this.linklblToWiki.TabStop = true;
            this.linklblToWiki.Text = "LinkToWiki";
            this.linklblToWiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblToWiki_LinkClicked);
            // 
            // lblQuestName
            // 
            this.lblQuestName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblQuestName.AutoSize = true;
            this.lblQuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQuestName.Location = new System.Drawing.Point(3, 12);
            this.lblQuestName.Name = "lblQuestName";
            this.lblQuestName.Size = new System.Drawing.Size(94, 20);
            this.lblQuestName.TabIndex = 15;
            this.lblQuestName.Text = "QuestName";
            this.lblQuestName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.btnQuestNotComplete);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblQuest);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 74);
            this.panel1.TabIndex = 17;
            // 
            // btnQuestNotComplete
            // 
            this.btnQuestNotComplete.Enabled = false;
            this.btnQuestNotComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnQuestNotComplete.Location = new System.Drawing.Point(99, 36);
            this.btnQuestNotComplete.Name = "btnQuestNotComplete";
            this.btnQuestNotComplete.Size = new System.Drawing.Size(102, 27);
            this.btnQuestNotComplete.TabIndex = 15;
            this.btnQuestNotComplete.Text = "Not Complete";
            this.btnQuestNotComplete.UseVisualStyleBackColor = true;
            this.btnQuestNotComplete.Click += new System.EventHandler(this.btnQuestNotComplete_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(6, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 26);
            this.button1.TabIndex = 14;
            this.button1.Text = "Complete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCompleteQuest);
            // 
            // lblQuest
            // 
            this.lblQuest.AutoSize = true;
            this.lblQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblQuest.Location = new System.Drawing.Point(74, 10);
            this.lblQuest.Name = "lblQuest";
            this.lblQuest.Size = new System.Drawing.Size(52, 20);
            this.lblQuest.TabIndex = 13;
            this.lblQuest.Text = "Quest";
            // 
            // btnSubmitQuests
            // 
            this.btnSubmitQuests.Enabled = false;
            this.btnSubmitQuests.Location = new System.Drawing.Point(556, 12);
            this.btnSubmitQuests.Name = "btnSubmitQuests";
            this.btnSubmitQuests.Size = new System.Drawing.Size(192, 55);
            this.btnSubmitQuests.TabIndex = 13;
            this.btnSubmitQuests.Text = "Submit Quests";
            this.btnSubmitQuests.UseVisualStyleBackColor = true;
            this.btnSubmitQuests.Click += new System.EventHandler(this.btnSubmitQuests_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1630, 1074);
            this.Controls.Add(this.btnSubmitQuests);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnRemoveFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnPopulate);
            this.Controls.Add(this.mainDiagramControl);
            this.Controls.Add(this.ImportQuests);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ooyodo Replica";
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFuel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReward6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReward5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReward4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReward3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReward2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReward1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ImportQuests;
        private Northwoods.Go.WinForms.DiagramControl mainDiagramControl;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRemoveFilter;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblQuest;
        private System.Windows.Forms.Label lblQuestName;
        private System.Windows.Forms.Label lblRequirenments;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblRewards;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pFuel;
        private System.Windows.Forms.Label lblReward6;
        private System.Windows.Forms.Label lblReward5;
        private System.Windows.Forms.Label lblReward4;
        private System.Windows.Forms.Label lblReward3;
        private System.Windows.Forms.Label lblReward2;
        private System.Windows.Forms.Label lblReward1;
        private System.Windows.Forms.PictureBox picReward6;
        private System.Windows.Forms.PictureBox picReward5;
        private System.Windows.Forms.PictureBox picReward4;
        private System.Windows.Forms.PictureBox picReward3;
        private System.Windows.Forms.PictureBox picReward2;
        private System.Windows.Forms.PictureBox picReward1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblRewardBauxite;
        private System.Windows.Forms.Label lblRewardSteel;
        private System.Windows.Forms.Label lblRewardAmmo;
        private System.Windows.Forms.Label lblRewardFuel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblQuestUnlock;
        private System.Windows.Forms.Label lblQuestRequirement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSubmitQuests;
        private System.Windows.Forms.LinkLabel linklblToWiki;
        private System.Windows.Forms.Button btnQuestNotComplete;
    }
}

