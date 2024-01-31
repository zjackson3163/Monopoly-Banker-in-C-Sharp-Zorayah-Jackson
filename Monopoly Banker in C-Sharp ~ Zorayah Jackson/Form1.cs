using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Monopoly_Banker_in_C_Sharp___Zorayah_Jackson
{
    
    public partial class Form1 : System.Windows.Forms.Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        //opens form to create list of players
        private void newGame_Click(object sender, EventArgs e)
        {
            var createPlayers = new Form2();
            createPlayers.ShowDialog();
            this.Close();
        }

        /*
          checks if "gameplay.txt" has data, if so uses that data to repopulate players' assets, if not message box says no 
          previous game data found
        */

        private void resumeGame_Click(object sender, EventArgs e)
        {
            try
            {
                string gameData = File.ReadAllText("gameData.txt");
                //figure out way to go through file to see if there are more than zero lines in gameData file

                /*cited
                var mainForm = new MainForm();
                mainForm.Show();
                from 
                Hans Kesting (Dec 16th, 2012) Stack Overflow*/

                var gameplay = new Form3();
                gameplay.ShowDialog();
                this.Close();
            }
            catch 
            {
                MessageBox.Show("Sorry, no previous game data was found... and this feature is not yet available but will be added soon!");
            }
        }
    }
}
