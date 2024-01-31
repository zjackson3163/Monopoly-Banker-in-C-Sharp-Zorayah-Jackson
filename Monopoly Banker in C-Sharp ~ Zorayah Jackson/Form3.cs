using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly_Banker_in_C_Sharp___Zorayah_Jackson
{
    
    public partial class Form3 : System.Windows.Forms.Form
    {
        //list of player and building details
        public List<Player> listOfPlayers = new List<Player>();
        public PropertiesDetails propertiesDetails = new PropertiesDetails();
        int counter = 0;

        public Form3()
        {
            InitializeComponent();
        }

        //makes list of players using previous page data
        public void setPlayers(List<Player> list)
        {
            for(int i = 0; i < list.Count;i++)
            {
                listOfPlayers.Add(list[i]);
            }
        }

        //sets all labels to be accoding to current player
        private void Form3_Load(object sender, EventArgs e)
        {
            PlayersList.DataSource = listOfPlayers;//.ToString();
            PropertiesList.DataSource= listOfPlayers[0].getProperties();
            playerAssets.Text = listOfPlayers[0].getName();
            balance.Text = "Balance: $" + listOfPlayers[0].getBalance();
        }

        //help button opens help screen
        private void helpButton_Click(object sender, EventArgs e)
        {
            var help = new Form4();
            help.ShowDialog();
        }

        //next player moves on to next player, shows next player info on labels
        private void nxtPlayer_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter > listOfPlayers.Count()-1)
            {
                counter = 0;
            }
            PropertiesList.DataSource = listOfPlayers[counter].getProperties();
            playerAssets.Text = listOfPlayers[counter].getName();
            balance.Text = "Balance: $" + listOfPlayers[counter].getBalance();
            houseLabel.Text = "Houses: 0";
            hotelLabel.Text = "Hotels: 0";
        }

        /*
          cited 
          Form2 lista = new Form2();
          lista.SetAllPeople(allPeopleSource);
          lista.ShowDialog();
          from
          Syzmon (Dec 7th, 2013) StackOverflow
          https://stackoverflow.com/questions/20441019/how-to-access-list-from-another-form
         */

        //opnes add screen, adds amount to user balance
        private void addButton_Click(object sender, EventArgs e)
        {
            var add = new Form5();
            add.setPlayers(listOfPlayers);
            add.setCounter(counter);
            add.ShowDialog();
            balance.Text = "Balance: $" + listOfPlayers[counter].getBalance();

        }

        //opens sub screen, subtracts amount from user balance
        private void subButton_Click(object sender, EventArgs e)
        {
            var sub = new Form6();
            sub.setPlayers(listOfPlayers);
            sub.setCounter(counter);
            sub.ShowDialog();
            balance.Text = "Balance: $" + listOfPlayers[counter].getBalance();
        }

        //opens buy screen, allow you to buy, however doesn't prevent certain things, took more time than I had to be able to do so
        //ex: 2 ppl can buy the same property
        private void buyButton_Click(object sender, EventArgs e)
        {
            var buy = new Form7();
            buy.setPlayers(listOfPlayers);
            buy.setCounter(counter);
            buy.setProperties(propertiesDetails.getPropertiesList());
            //buy.getPropertiesDetails(propertiesDetails);
            buy.ShowDialog();
            PropertiesList.DataSource = listOfPlayers[counter].getProperties();
            MessageBox.Show("May need to refresh page to see updated properties list. Click next player then previous player to do so.");
        }

        //would open trade screen, not done now, took more time to figure out than I thought it would
        private void tradeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet available, but will be added soon!");
        }


        //prev player moves on to prev player, shows prev player info on labels
        private void prevPlayer_Click_1(object sender, EventArgs e)
        {
            counter--;
            if (counter < 0)
            {
                counter = listOfPlayers.Count-1;
            }
            PropertiesList.DataSource = listOfPlayers[counter].getProperties();
            playerAssets.Text = listOfPlayers[counter].getName();
            balance.Text = "Balance: $" + listOfPlayers[counter].getBalance();
        }

        private void addHouses_Click(object sender, EventArgs e)
        {
            bool found = false;
            int i = 0;
            while (found != true)
            {
                if (PropertiesList.GetItemText(PropertiesList.SelectedItem) == propertiesDetails.getPropertiesList()[i-1])
                {
                    found = true;
                }
                i++;
            }
           
            houseLabel.Text = "Houses: " + listOfPlayers[counter].getNumHouses(i);

            if (listOfPlayers[counter].subBalance(propertiesDetails.getBuildingCost(i)) == true && listOfPlayers[counter].addHouse(i) == true)
            {
                houseLabel.Text = "Houses: " + listOfPlayers[counter].getNumHouses(i);
                balance.Text = "Balance: $" + listOfPlayers[counter].getBalance();
            } 
        }

        private void sellHouses_Click(object sender, EventArgs e)
        {
            bool found = false;
            int i = 0;
            while (found != true)
            {
                if (PropertiesList.GetItemText(PropertiesList.SelectedItem) == propertiesDetails.getPropertiesList()[i])
                {
                    found = true;
                }
                i++;
            }
            listOfPlayers[counter].sellHouse(i);
            listOfPlayers[counter].addBalance(propertiesDetails.getBuildingCost(i)/2);
            houseLabel.Text = "Houses: " + listOfPlayers[counter].getNumHouses(i);
            balance.Text = "Balance: $" + listOfPlayers[counter].getBalance();

        }

        private void addHotels_Click(object sender, EventArgs e)
        {
            bool found = false;
            int i = 0;
            if (PropertiesList.GetItemText(PropertiesList.SelectedItem) == propertiesDetails.getPropertiesList()[i])
            {
                found = true;
            }
            i++;
            hotelLabel.Text = "Hotels: " + listOfPlayers[counter].getNumHotels(i);
            if (listOfPlayers[counter].subBalance(propertiesDetails.getBuildingCost(i)) == true && listOfPlayers[counter].addHotel(i) == true)
            {
                hotelLabel.Text = "Hotels: " + listOfPlayers[counter].getNumHotels(i);
                balance.Text = "Balance: $" + listOfPlayers[counter].getBalance();
            }
        }

        private void sellHotels_Click(object sender, EventArgs e)
        {
            bool found = false;
            int i = 0;
            while (found != true)
            {
                if (PropertiesList.GetItemText(PropertiesList.SelectedItem) == propertiesDetails.getPropertiesList()[i-1])
                {
                    found = true;
                }
                i++;
            }
            listOfPlayers[counter].sellHotel(i);
            listOfPlayers[counter].addBalance(propertiesDetails.getBuildingCost(i) / 2);
            houseLabel.Text = "Hotels: " + listOfPlayers[counter].getNumHotels(i);
            balance.Text = "Balance: $" + listOfPlayers[counter].getBalance();
        }

        private void PropertiesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool found = false;
            int i = 0;
            while (found != true)
            {
                if (PropertiesList.GetItemText(PropertiesList.SelectedItem) == propertiesDetails.getPropertiesList()[i])
                {
                    found = true;
                }
                i++;
            }
            houseLabel.Text = "Houses: " + listOfPlayers[counter].getNumHouses(i);
            hotelLabel.Text = "Hotels: " + listOfPlayers[counter].getNumHotels(i);
        }

        private void mortgage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet available, but will be added soon!");
        }

        private void pauseGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not yet available, but will be added soon!");
        }
    }
}
