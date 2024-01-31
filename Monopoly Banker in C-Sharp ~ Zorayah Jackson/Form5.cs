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
    public partial class Form5 : Form
    {
        public List<Player> listOfPlayers = new List<Player>();
        int counter = 0;

        //sets counter from main game so it knows which player is receiving money
        public void setCounter(int num)
        {
            counter = num;
        }

        /* cited
   public partial class Form2 : Form
   {
        public void SetAllPeople(List<string> input)
        {
            foreach (string s in input)
            {
                lsbResidents.Items.Add(s);
            }
        }

        public Form2()
        {
            InitializeComponent();
        }
    }
    from
    Syzmon (Dec 7th, 2013) StackOverflow
    https://stackoverflow.com/questions/20441019/how-to-access-list-from-another-form
*/

        //gets list of players from main form
        public void setPlayers(List<Player> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                listOfPlayers.Add(list[i]);
            }
        }

        public Form5()
        {
            InitializeComponent();
        }

        //when hit submit, add number in text box to players balance if num in box more than or equal to 0
        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(addBalance.Text) >= 0)
            {
                listOfPlayers[counter].addBalance(Convert.ToInt32(addBalance.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("You have to add a positive amount of money!");
            }
        }

        
    }
}
