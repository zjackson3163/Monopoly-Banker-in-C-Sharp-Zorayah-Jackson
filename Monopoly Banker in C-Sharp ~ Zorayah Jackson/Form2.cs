using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Monopoly_Banker_in_C_Sharp___Zorayah_Jackson
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        //initializes player list
        int counter = 0;
        public List<Player> listOfPlayers = new List<Player>();

        //returns player list
        public List<Player> getPlayers()
        {
            return listOfPlayers;
        }


        public Form2()
        {
            InitializeComponent();
        }

        //when player hits next player button, adds new player object to list of players, lets them add another to list
        private void nxtPlayer_Click(object sender, EventArgs e)
        {
            amtPlayers.Enabled = false;

            /* cited
               textBox1.Text.Length == 0 || textBox1.Text.Trim().Length == 0
               from Woodenhausen (Nov 29, 2011) Microsoft Forums
               https://social.msdn.microsoft.com/Forums/windows/en-US/3dac5739-708b-4a73-a505-9a8c0587ee04/preventing-null-values-from-a-textbox-control?forum=winformsdatacontrols
           */

            if (playerName.Text.Length == 0 || playerName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a name.");
            }
            else
            {
                listOfPlayers.Add(new Player(playerName.Text));
                if (counter < Convert.ToInt32(amtPlayers.Text) - 1)
                {
                    counter++;
                    playerNumber.Text = ($"Player {counter + 1}'s name:");
                    playerName.Text = string.Empty;
                }
                //if going to add more players, does not allow them to put more than amount of players they said were playing.
                else
                {
                    MessageBox.Show("You've added the all players!. Press \"Done Adding\" to continue.");
                    doneAdding.Enabled = true;
                }
            }
        }

        //create something in here to make sure no values are null
        //when done adding takes user to main gameplay screen, transfers data to next screen
        private void doneAdding_Click(object sender, EventArgs e)
        {
            listOfPlayers[counter] = new Player(playerName.Text);
         
            var gameplay = new Form3();
            gameplay.setPlayers(listOfPlayers);
            var current = new Form2();
            gameplay.Show();
        }
        
        //doesnt allow them to add players without first selecting how many players they want to play
        private void amtPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerName.Enabled = true;
            nxtPlayer.Enabled = true;
        }
    }
}
