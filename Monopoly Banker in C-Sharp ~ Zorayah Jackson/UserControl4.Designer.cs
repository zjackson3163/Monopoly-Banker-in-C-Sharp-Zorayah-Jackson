namespace Monopoly_Banker_in_C_Sharp___Zorayah_Jackson
{
    partial class UserControl4
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playerOne = new System.Windows.Forms.GroupBox();
            this.playerTwo = new System.Windows.Forms.GroupBox();
            this.Player1 = new System.Windows.Forms.ListBox();
            this.player1PropertyToTrade = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.player1MoneyTraded = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tradeButton = new System.Windows.Forms.Button();
            this.tradeControl = new System.Windows.Forms.Label();
            this.player2MoneyTraded = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.player2PropertyToTrade = new System.Windows.Forms.ListBox();
            this.Player2 = new System.Windows.Forms.ListBox();
            this.playerOne.SuspendLayout();
            this.playerTwo.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerOne
            // 
            this.playerOne.Controls.Add(this.player1MoneyTraded);
            this.playerOne.Controls.Add(this.label2);
            this.playerOne.Controls.Add(this.label1);
            this.playerOne.Controls.Add(this.player1PropertyToTrade);
            this.playerOne.Controls.Add(this.Player1);
            this.playerOne.Location = new System.Drawing.Point(36, 64);
            this.playerOne.Name = "playerOne";
            this.playerOne.Size = new System.Drawing.Size(349, 153);
            this.playerOne.TabIndex = 0;
            this.playerOne.TabStop = false;
            this.playerOne.Text = "Player 1 Trading ";
            // 
            // playerTwo
            // 
            this.playerTwo.Controls.Add(this.player2MoneyTraded);
            this.playerTwo.Controls.Add(this.label5);
            this.playerTwo.Controls.Add(this.label6);
            this.playerTwo.Controls.Add(this.player2PropertyToTrade);
            this.playerTwo.Controls.Add(this.Player2);
            this.playerTwo.Location = new System.Drawing.Point(476, 64);
            this.playerTwo.Name = "playerTwo";
            this.playerTwo.Size = new System.Drawing.Size(329, 153);
            this.playerTwo.TabIndex = 1;
            this.playerTwo.TabStop = false;
            this.playerTwo.Text = "Player 2 Trading";
            // 
            // Player1
            // 
            this.Player1.FormattingEnabled = true;
            this.Player1.Location = new System.Drawing.Point(6, 29);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(86, 95);
            this.Player1.TabIndex = 1;
            // 
            // player1PropertyToTrade
            // 
            this.player1PropertyToTrade.FormattingEnabled = true;
            this.player1PropertyToTrade.Location = new System.Drawing.Point(98, 29);
            this.player1PropertyToTrade.Name = "player1PropertyToTrade";
            this.player1PropertyToTrade.Size = new System.Drawing.Size(120, 95);
            this.player1PropertyToTrade.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Money?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "$";
            // 
            // player1MoneyTraded
            // 
            this.player1MoneyTraded.Location = new System.Drawing.Point(261, 79);
            this.player1MoneyTraded.Name = "player1MoneyTraded";
            this.player1MoneyTraded.Size = new System.Drawing.Size(60, 20);
            this.player1MoneyTraded.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "-->\r\n\r\n<--";
            // 
            // tradeButton
            // 
            this.tradeButton.Location = new System.Drawing.Point(369, 247);
            this.tradeButton.Name = "tradeButton";
            this.tradeButton.Size = new System.Drawing.Size(122, 23);
            this.tradeButton.TabIndex = 7;
            this.tradeButton.Text = "Confirm Trade";
            this.tradeButton.UseVisualStyleBackColor = true;
            // 
            // tradeControl
            // 
            this.tradeControl.AutoSize = true;
            this.tradeControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tradeControl.Location = new System.Drawing.Point(404, 23);
            this.tradeControl.Name = "tradeControl";
            this.tradeControl.Size = new System.Drawing.Size(37, 15);
            this.tradeControl.TabIndex = 4;
            this.tradeControl.Text = "Trade";
            // 
            // player2MoneyTraded
            // 
            this.player2MoneyTraded.Location = new System.Drawing.Point(262, 79);
            this.player2MoneyTraded.Name = "player2MoneyTraded";
            this.player2MoneyTraded.Size = new System.Drawing.Size(60, 20);
            this.player2MoneyTraded.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Money?";
            // 
            // player2PropertyToTrade
            // 
            this.player2PropertyToTrade.FormattingEnabled = true;
            this.player2PropertyToTrade.Location = new System.Drawing.Point(99, 29);
            this.player2PropertyToTrade.Name = "player2PropertyToTrade";
            this.player2PropertyToTrade.Size = new System.Drawing.Size(120, 95);
            this.player2PropertyToTrade.TabIndex = 5;
            // 
            // Player2
            // 
            this.Player2.FormattingEnabled = true;
            this.Player2.Location = new System.Drawing.Point(7, 29);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(86, 95);
            this.Player2.TabIndex = 4;
            // 
            // UserControl4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tradeControl);
            this.Controls.Add(this.tradeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.playerTwo);
            this.Controls.Add(this.playerOne);
            this.Name = "UserControl4";
            this.Size = new System.Drawing.Size(833, 294);
            this.playerOne.ResumeLayout(false);
            this.playerOne.PerformLayout();
            this.playerTwo.ResumeLayout(false);
            this.playerTwo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox playerOne;
        private System.Windows.Forms.TextBox player1MoneyTraded;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox player1PropertyToTrade;
        private System.Windows.Forms.ListBox Player1;
        private System.Windows.Forms.GroupBox playerTwo;
        private System.Windows.Forms.TextBox player2MoneyTraded;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox player2PropertyToTrade;
        private System.Windows.Forms.ListBox Player2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tradeButton;
        private System.Windows.Forms.Label tradeControl;
    }
}
