namespace Monopoly_Banker_in_C_Sharp___Zorayah_Jackson
{
    partial class Form3
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
            this.banner = new System.Windows.Forms.Label();
            this.PlayersList = new System.Windows.Forms.ListBox();
            this.nxtPlayer = new System.Windows.Forms.Button();
            this.pauseGame = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mortgage = new System.Windows.Forms.Button();
            this.addHouses = new System.Windows.Forms.Button();
            this.sellHouses = new System.Windows.Forms.Button();
            this.addHotels = new System.Windows.Forms.Button();
            this.sellHotels = new System.Windows.Forms.Button();
            this.hotelLabel = new System.Windows.Forms.Label();
            this.houseLabel = new System.Windows.Forms.Label();
            this.propertiesBox = new System.Windows.Forms.GroupBox();
            this.PropertiesList = new System.Windows.Forms.ListBox();
            this.playerAssets = new System.Windows.Forms.GroupBox();
            this.balance = new System.Windows.Forms.Label();
            this.buyButton = new System.Windows.Forms.Button();
            this.tradeButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.prevPlayer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.propertiesBox.SuspendLayout();
            this.playerAssets.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // banner
            // 
            this.banner.AutoSize = true;
            this.banner.BackColor = System.Drawing.Color.White;
            this.banner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.banner.Font = new System.Drawing.Font("Palatino Linotype", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banner.ForeColor = System.Drawing.Color.DarkGreen;
            this.banner.Location = new System.Drawing.Point(204, 41);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(384, 60);
            this.banner.TabIndex = 2;
            this.banner.Text = "Monopoly Banker";
            this.banner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PlayersList
            // 
            this.PlayersList.FormattingEnabled = true;
            this.PlayersList.Location = new System.Drawing.Point(599, 1);
            this.PlayersList.Name = "PlayersList";
            this.PlayersList.Size = new System.Drawing.Size(189, 95);
            this.PlayersList.TabIndex = 10;
            // 
            // nxtPlayer
            // 
            this.nxtPlayer.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxtPlayer.Location = new System.Drawing.Point(294, 410);
            this.nxtPlayer.Name = "nxtPlayer";
            this.nxtPlayer.Size = new System.Drawing.Size(75, 23);
            this.nxtPlayer.TabIndex = 12;
            this.nxtPlayer.Text = "Next Player";
            this.nxtPlayer.UseVisualStyleBackColor = true;
            this.nxtPlayer.Click += new System.EventHandler(this.nxtPlayer_Click);
            // 
            // pauseGame
            // 
            this.pauseGame.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseGame.Location = new System.Drawing.Point(709, 410);
            this.pauseGame.Name = "pauseGame";
            this.pauseGame.Size = new System.Drawing.Size(75, 23);
            this.pauseGame.TabIndex = 13;
            this.pauseGame.Text = "PAUSE";
            this.pauseGame.UseVisualStyleBackColor = true;
            this.pauseGame.Click += new System.EventHandler(this.pauseGame_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(16, 1);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(46, 43);
            this.helpButton.TabIndex = 21;
            this.helpButton.Text = "?";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mortgage);
            this.groupBox1.Controls.Add(this.addHouses);
            this.groupBox1.Controls.Add(this.sellHouses);
            this.groupBox1.Controls.Add(this.addHotels);
            this.groupBox1.Controls.Add(this.sellHotels);
            this.groupBox1.Controls.Add(this.hotelLabel);
            this.groupBox1.Controls.Add(this.houseLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(556, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 223);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Property";
            // 
            // mortgage
            // 
            this.mortgage.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mortgage.Location = new System.Drawing.Point(21, 176);
            this.mortgage.Name = "mortgage";
            this.mortgage.Size = new System.Drawing.Size(77, 30);
            this.mortgage.TabIndex = 27;
            this.mortgage.Text = "Mortgage?";
            this.mortgage.UseVisualStyleBackColor = true;
            this.mortgage.Click += new System.EventHandler(this.mortgage_Click);
            // 
            // addHouses
            // 
            this.addHouses.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addHouses.Location = new System.Drawing.Point(21, 65);
            this.addHouses.Name = "addHouses";
            this.addHouses.Size = new System.Drawing.Size(75, 23);
            this.addHouses.TabIndex = 26;
            this.addHouses.Text = "+";
            this.addHouses.UseVisualStyleBackColor = true;
            this.addHouses.Click += new System.EventHandler(this.addHouses_Click);
            // 
            // sellHouses
            // 
            this.sellHouses.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellHouses.Location = new System.Drawing.Point(108, 65);
            this.sellHouses.Name = "sellHouses";
            this.sellHouses.Size = new System.Drawing.Size(75, 23);
            this.sellHouses.TabIndex = 25;
            this.sellHouses.Text = "-";
            this.sellHouses.UseVisualStyleBackColor = true;
            this.sellHouses.Click += new System.EventHandler(this.sellHouses_Click);
            // 
            // addHotels
            // 
            this.addHotels.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addHotels.Location = new System.Drawing.Point(21, 128);
            this.addHotels.Name = "addHotels";
            this.addHotels.Size = new System.Drawing.Size(75, 23);
            this.addHotels.TabIndex = 24;
            this.addHotels.Text = "+";
            this.addHotels.UseVisualStyleBackColor = true;
            this.addHotels.Click += new System.EventHandler(this.addHotels_Click);
            // 
            // sellHotels
            // 
            this.sellHotels.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellHotels.Location = new System.Drawing.Point(108, 128);
            this.sellHotels.Name = "sellHotels";
            this.sellHotels.Size = new System.Drawing.Size(75, 23);
            this.sellHotels.TabIndex = 23;
            this.sellHotels.Text = "-";
            this.sellHotels.UseVisualStyleBackColor = true;
            this.sellHotels.Click += new System.EventHandler(this.sellHotels_Click);
            // 
            // hotelLabel
            // 
            this.hotelLabel.AutoSize = true;
            this.hotelLabel.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelLabel.Location = new System.Drawing.Point(19, 108);
            this.hotelLabel.Name = "hotelLabel";
            this.hotelLabel.Size = new System.Drawing.Size(72, 19);
            this.hotelLabel.TabIndex = 22;
            this.hotelLabel.Text = "Hotels: 0";
            // 
            // houseLabel
            // 
            this.houseLabel.AutoSize = true;
            this.houseLabel.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.houseLabel.Location = new System.Drawing.Point(18, 45);
            this.houseLabel.Name = "houseLabel";
            this.houseLabel.Size = new System.Drawing.Size(80, 19);
            this.houseLabel.TabIndex = 21;
            this.houseLabel.Text = "Houses: 0";
            // 
            // propertiesBox
            // 
            this.propertiesBox.Controls.Add(this.PropertiesList);
            this.propertiesBox.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propertiesBox.Location = new System.Drawing.Point(294, 163);
            this.propertiesBox.Name = "propertiesBox";
            this.propertiesBox.Size = new System.Drawing.Size(208, 222);
            this.propertiesBox.TabIndex = 23;
            this.propertiesBox.TabStop = false;
            this.propertiesBox.Text = "Properties";
            // 
            // PropertiesList
            // 
            this.PropertiesList.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertiesList.FormattingEnabled = true;
            this.PropertiesList.ItemHeight = 16;
            this.PropertiesList.Location = new System.Drawing.Point(44, 33);
            this.PropertiesList.Name = "PropertiesList";
            this.PropertiesList.Size = new System.Drawing.Size(120, 164);
            this.PropertiesList.TabIndex = 15;
            this.PropertiesList.SelectedIndexChanged += new System.EventHandler(this.PropertiesList_SelectedIndexChanged);
            // 
            // playerAssets
            // 
            this.playerAssets.Controls.Add(this.balance);
            this.playerAssets.Controls.Add(this.buyButton);
            this.playerAssets.Controls.Add(this.tradeButton);
            this.playerAssets.Controls.Add(this.subButton);
            this.playerAssets.Controls.Add(this.addButton);
            this.playerAssets.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerAssets.Location = new System.Drawing.Point(41, 162);
            this.playerAssets.Name = "playerAssets";
            this.playerAssets.Size = new System.Drawing.Size(200, 223);
            this.playerAssets.TabIndex = 24;
            this.playerAssets.TabStop = false;
            this.playerAssets.Text = "Player Name";
            // 
            // balance
            // 
            this.balance.AutoSize = true;
            this.balance.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balance.Location = new System.Drawing.Point(6, 65);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(131, 19);
            this.balance.TabIndex = 14;
            this.balance.Text = "Balance: $_______";
            // 
            // buyButton
            // 
            this.buyButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyButton.Location = new System.Drawing.Point(116, 183);
            this.buyButton.Name = "buyButton";
            this.buyButton.Size = new System.Drawing.Size(75, 23);
            this.buyButton.TabIndex = 12;
            this.buyButton.Text = "Buy";
            this.buyButton.UseVisualStyleBackColor = true;
            this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
            // 
            // tradeButton
            // 
            this.tradeButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tradeButton.Location = new System.Drawing.Point(6, 183);
            this.tradeButton.Name = "tradeButton";
            this.tradeButton.Size = new System.Drawing.Size(75, 23);
            this.tradeButton.TabIndex = 11;
            this.tradeButton.Text = "Trade";
            this.tradeButton.UseVisualStyleBackColor = true;
            this.tradeButton.Click += new System.EventHandler(this.tradeButton_Click);
            // 
            // subButton
            // 
            this.subButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subButton.Location = new System.Drawing.Point(116, 128);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(75, 23);
            this.subButton.TabIndex = 10;
            this.subButton.Text = "Subtract";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.subButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(6, 128);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // prevPlayer
            // 
            this.prevPlayer.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevPlayer.Location = new System.Drawing.Point(427, 410);
            this.prevPlayer.Name = "prevPlayer";
            this.prevPlayer.Size = new System.Drawing.Size(75, 23);
            this.prevPlayer.TabIndex = 25;
            this.prevPlayer.Text = "Prev Player";
            this.prevPlayer.UseVisualStyleBackColor = true;
            this.prevPlayer.Click += new System.EventHandler(this.prevPlayer_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 455);
            this.panel2.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Location = new System.Drawing.Point(0, 442);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 10);
            this.panel4.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(790, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 455);
            this.panel1.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Location = new System.Drawing.Point(0, 442);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 10);
            this.panel3.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.prevPlayer);
            this.Controls.Add(this.playerAssets);
            this.Controls.Add(this.propertiesBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.pauseGame);
            this.Controls.Add(this.nxtPlayer);
            this.Controls.Add(this.PlayersList);
            this.Controls.Add(this.banner);
            this.Name = "Form3";
            this.Text = "Monopoly Banker";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.propertiesBox.ResumeLayout(false);
            this.playerAssets.ResumeLayout(false);
            this.playerAssets.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label banner;
        private System.Windows.Forms.ListBox PlayersList;
        private System.Windows.Forms.Button nxtPlayer;
        private System.Windows.Forms.Button pauseGame;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button mortgage;
        private System.Windows.Forms.Button addHouses;
        private System.Windows.Forms.Button sellHouses;
        private System.Windows.Forms.Button addHotels;
        private System.Windows.Forms.Button sellHotels;
        private System.Windows.Forms.Label hotelLabel;
        private System.Windows.Forms.Label houseLabel;
        private System.Windows.Forms.GroupBox propertiesBox;
        private System.Windows.Forms.ListBox PropertiesList;
        private System.Windows.Forms.GroupBox playerAssets;
        private System.Windows.Forms.Label balance;
        private System.Windows.Forms.Button buyButton;
        private System.Windows.Forms.Button tradeButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button prevPlayer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}