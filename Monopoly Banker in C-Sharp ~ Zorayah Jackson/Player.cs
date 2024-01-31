using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly_Banker_in_C_Sharp___Zorayah_Jackson
{
    public class Player
    {
        string name;
        int balance;
        List<string> properties;
        /*
          cited
          int[] myarr = Enumerable.Range(0, 10).Select(n => 13).ToArray();
          from
          roadrunner66 (Feb 17, 2013) StackOverflow
          https://stackoverflow.com/questions/14919234/fill-an-array-in-c-sharp
         */
        int[] houses = Enumerable.Range(0, 27).Select(n => 0).ToArray();
        int[] hotels = Enumerable.Range(0, 27).Select(n => 0).ToArray();
        bool[] haveColors = Enumerable.Range(0, 27).Select(n => false).ToArray();

        //default constructor
        public Player() 
        {
            name = null;
            balance = 0;
            properties = null;
        }

        //initializes? player
        public Player(string n) 
        {
            name = n;
            balance = 1500;
            properties = new List<string>();
        }

        //gets player name
        public string getName()
        {
            return name;
        }

        //adds to player balance
        public void addBalance(int num) 
        {
            balance += num;
        }

        //subtracts from player balance, bool for certain situations
        public bool subBalance(int num)
        {
            if (balance-num < 0)
            {
                MessageBox.Show("Sorry, you don't have the required funds to make this purchase!");
                return false;
            }
            balance-= num;
            return true;
        }
        
        //gets player balance
        public int getBalance()
        {
            return balance;
        }

        //gets player properties array
        public List<string> getProperties()
        {
            return properties;
        }

        //adds to player properties array
        public void addProperties(string prop)
        {
            properties.Add(prop);
        }

        //will somehow check if the full color set is owned
        public void gotColor(int i)
        {
            haveColors[i] = true;
        }

        //adds house at property index i
        public bool addHouse(int i)
        {
            if (houses[i] >= 4)
            {
                MessageBox.Show("You have the maximum number of houses on this property. Consider buying a hotel!");
                return false;
            }
            else
            {
                houses[i] += 1;
                return true;
            }   
        }

        //sells house at property index i
        public void sellHouse(int i)
        {
            if (houses[i] < 1)
            {
                MessageBox.Show("You have no houses to sell on this property.");
            }
            else
            {
                houses[i] -= 1;
            }
        }


        //gets number of houses at property index i
        public int getNumHouses(int i)
        {
            return houses[i];
        }

        //gets number of hotels at property index i
        public int getNumHotels(int i)
        {
            return hotels[i];
        }

        //adds hotel at property index i
        public bool addHotel(int i)
        {
            if (hotels[i] >= 1)
            {
                MessageBox.Show("You have the maximum number of hotels on this property. You've bought all the buildings you can for this property!");
                return false;
            }
            //not working, even when houses @ shows message
            /*else if (houses[i] < 4)
            {
                MessageBox.Show("You need 4 houses on a property to buy a hotel! Consider buying a house!");
                return false;
            }*/
            else
            {
                hotels[i] += 1;
                return true;
            }
        }

        //sells hotel at property index i
        public void sellHotel(int i)
        {
            if (hotels[i] < 1)
            {
                MessageBox.Show("You have no houses to sell on this property.");
            }
            else
            {
                hotels[i] -= 1;
            }
        }

        //did not end up needing, thought i could use for player list box in top right corner
        public string toString()
        {
            return name;
        }

        


    }
}
