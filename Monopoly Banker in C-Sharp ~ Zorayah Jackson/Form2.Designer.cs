namespace Monopoly_Banker_in_C_Sharp___Zorayah_Jackson
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.playerNumber = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.TextBox();
            this.nxtPlayer = new System.Windows.Forms.Button();
            this.doneAdding = new System.Windows.Forms.Button();
            this.amtPlayers = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.banner.Location = new System.Drawing.Point(199, 69);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(384, 60);
            this.banner.TabIndex = 1;
            this.banner.Text = "Monopoly Banker";
            this.banner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "How many players:";
            // 
            // playerNumber
            // 
            this.playerNumber.AutoSize = true;
            this.playerNumber.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNumber.Location = new System.Drawing.Point(238, 265);
            this.playerNumber.Name = "playerNumber";
            this.playerNumber.Size = new System.Drawing.Size(141, 21);
            this.playerNumber.TabIndex = 3;
            this.playerNumber.Text = "Player 1\'s name:";
            // 
            // playerName
            // 
            this.playerName.Enabled = false;
            this.playerName.Location = new System.Drawing.Point(345, 301);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(121, 20);
            this.playerName.TabIndex = 2;
            // 
            // nxtPlayer
            // 
            this.nxtPlayer.Enabled = false;
            this.nxtPlayer.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nxtPlayer.Location = new System.Drawing.Point(276, 374);
            this.nxtPlayer.Name = "nxtPlayer";
            this.nxtPlayer.Size = new System.Drawing.Size(80, 29);
            this.nxtPlayer.TabIndex = 3;
            this.nxtPlayer.Text = "Next Player";
            this.nxtPlayer.UseVisualStyleBackColor = true;
            this.nxtPlayer.Click += new System.EventHandler(this.nxtPlayer_Click);
            // 
            // doneAdding
            // 
            this.doneAdding.Enabled = false;
            this.doneAdding.Font = new System.Drawing.Font("Microsoft Yi Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneAdding.Location = new System.Drawing.Point(441, 374);
            this.doneAdding.Name = "doneAdding";
            this.doneAdding.Size = new System.Drawing.Size(80, 29);
            this.doneAdding.TabIndex = 4;
            this.doneAdding.Text = "Done Adding";
            this.doneAdding.UseVisualStyleBackColor = true;
            this.doneAdding.Click += new System.EventHandler(this.doneAdding_Click);
            // 
            // amtPlayers
            // 
            this.amtPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.amtPlayers.FormattingEnabled = true;
            this.amtPlayers.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.amtPlayers.Location = new System.Drawing.Point(345, 212);
            this.amtPlayers.Name = "amtPlayers";
            this.amtPlayers.Size = new System.Drawing.Size(121, 21);
            this.amtPlayers.TabIndex = 1;
            this.amtPlayers.SelectedIndexChanged += new System.EventHandler(this.amtPlayers_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 455);
            this.panel2.TabIndex = 5;
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
            this.panel1.TabIndex = 6;
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.amtPlayers);
            this.Controls.Add(this.doneAdding);
            this.Controls.Add(this.nxtPlayer);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.playerNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.banner);
            this.Name = "Form2";
            this.Text = "Monopoly Banker";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label banner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerNumber;
        private System.Windows.Forms.TextBox playerName;
        private System.Windows.Forms.Button nxtPlayer;
        private System.Windows.Forms.Button doneAdding;
        private System.Windows.Forms.ComboBox amtPlayers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}