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
    public partial class Form7 : Form
    {
        public List<Player> listOfPlayers = new List<Player>();
        List<string> properties = new List<String>();
        PropertiesDetails propertiesDetails = new PropertiesDetails();
        int counter = 0;

        //counter from main game so it knows which player is buying property
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

        //gets list of properties from main form
        public void setProperties(string[]prop)
        {
            for (int i = 0; i < prop.Length; i++)
            {
                properties.Add(prop[i]);
            }
            propsAvail.DataSource = properties;
        }

        //trying to find a way to transfer data without initializing whole new propertiesdetails
        /*public void getPropertiesDetails(PropertiesDetails prop)
        {
            PropertiesDetails propertiesDetails = prop;
        }*/
        
        public Form7()
        {
            InitializeComponent();
        }

        //cite code
        //when hit submit, add property to players properties list and subtract cost if they have it, if not they can't buy
        private void button1_Click(object sender, EventArgs e)
        {
            //var gameplay = new Form3();
            bool found = false;
            int i = 0;
            while(found != true)
            {
                if (propsAvail.GetItemText(propsAvail.SelectedItem) == properties[i])
                {
                    found= true;
                }
                i++;
            }
            if (propertiesDetails.checkAvailability(i-1) == true)
            {
                listOfPlayers[counter].subBalance(propertiesDetails.getPropCost(i - 1));
                if (listOfPlayers[counter].getBalance() < 0)
                {
                    MessageBox.Show("Sorry, you don't have the required funds to make this purchase!");
                    listOfPlayers[counter].addBalance(propertiesDetails.getPropCost(i - 1));
                }

                /* cited
                   string text = listBox1.GetItemText(listBox1.SelectedItem);
                   from
                   Thomas Levesque (Feb 21, 2013) StackOverflow
                   https://stackoverflow.com/questions/15003095/getting-value-of-selected-item-in-list-box-as-string
                */


                else
                {
                    listOfPlayers[counter].addProperties(propsAvail.GetItemText(propsAvail.SelectedItem));
                    propertiesDetails.changeAvailability(i - 1);
                    listOfPlayers[counter].gotColor(i);
                }

                //testing to see if property is showing up as available or not
                /*for (int j = 0; j < properties.Count()-1; j++)
                {
                    MessageBox.Show(Convert.ToString(propertiesDetails.checkAvailability(j)));
                }*/
            }
            else
            {
                MessageBox.Show("Sorry, this property has already been bought!");
            }
            
            this.Hide();
        }
    }
}
