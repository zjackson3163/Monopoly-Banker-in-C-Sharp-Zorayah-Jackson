using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly_Banker_in_C_Sharp___Zorayah_Jackson
{
    public partial class Form6 : Form
    {

        public List<Player> listOfPlayers = new List<Player>();
        int counter = 0;


        //scounter from main game so it knows which player is spending money
        public void setCounter(int num)
        {
            counter = num;
        }


        //gets list of players from main form
        public void setPlayers(List<Player> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                listOfPlayers.Add(list[i]);
            }
        }

        
        public Form6()
        {
            InitializeComponent();
        }

        //when hit submit, sub number in text box to players balance if end balance more than or equal to 0
        private void button1_Click(object sender, EventArgs e)
        {
            listOfPlayers[counter].subBalance(Convert.ToInt32(subBalance.Text));
            if (listOfPlayers[counter].getBalance() < 0)
            {
                MessageBox.Show("Sorry, you don't have the required funds to make this purchase!");
                listOfPlayers[counter].addBalance(Convert.ToInt32(subBalance.Text));

            }
            this.Close();

        }
    }
}
