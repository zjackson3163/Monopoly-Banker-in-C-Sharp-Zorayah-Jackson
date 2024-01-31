namespace Monopoly_Banker_in_C_Sharp___Zorayah_Jackson
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
            this.bannerOne = new System.Windows.Forms.Label();
            this.newGame = new System.Windows.Forms.Button();
            this.resumeGame = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bannerOne
            // 
            this.bannerOne.AutoSize = true;
            this.bannerOne.BackColor = System.Drawing.Color.White;
            this.bannerOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bannerOne.Font = new System.Drawing.Font("Palatino Linotype", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerOne.ForeColor = System.Drawing.Color.DarkGreen;
            this.bannerOne.Location = new System.Drawing.Point(89, 72);
            this.bannerOne.Name = "bannerOne";
            this.bannerOne.Size = new System.Drawing.Size(635, 60);
            this.bannerOne.TabIndex = 0;
            this.bannerOne.Text = "Welcome to Monopoly Banker!";
            this.bannerOne.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // newGame
            // 
            this.newGame.BackColor = System.Drawing.Color.White;
            this.newGame.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGame.Location = new System.Drawing.Point(311, 212);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(179, 55);
            this.newGame.TabIndex = 1;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = false;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // resumeGame
            // 
            this.resumeGame.Font = new System.Drawing.Font("Microsoft Yi Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resumeGame.Location = new System.Drawing.Point(311, 303);
            this.resumeGame.Name = "resumeGame";
            this.resumeGame.Size = new System.Drawing.Size(179, 56);
            this.resumeGame.TabIndex = 2;
            this.resumeGame.Text = "Resume Game";
            this.resumeGame.UseVisualStyleBackColor = true;
            this.resumeGame.Click += new System.EventHandler(this.resumeGame_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(790, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 455);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(0, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 455);
            this.panel2.TabIndex = 4;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resumeGame);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.bannerOne);
            this.Name = "Form1";
            this.Text = "Monopoly Banker";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bannerOne;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button resumeGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}

