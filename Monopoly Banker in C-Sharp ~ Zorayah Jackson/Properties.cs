using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Monopoly_Banker_in_C_Sharp___Zorayah_Jackson
{
    public class PropertiesDetails
    {
        //cite code
        //created arrays
        string[] properties;
        bool[] availible = Enumerable.Range(0, 27).Select(n => true).ToArray();
        string[] propertyColor;
        string[] propertiesCost;
        string[] buildingCost; 

        public PropertiesDetails()
        {
            //initializes arrays using files
            properties = System.IO.File.ReadAllLines("properties.txt");
            propertyColor = System.IO.File.ReadAllLines("colors.txt");
            propertiesCost =System.IO.File.ReadAllLines("propertiesCost.txt");
            buildingCost = System.IO.File.ReadAllLines("buildingCost.txt");

        }

        //gets the property cost based on index inputted as i
        public int getPropCost(int i)
        {
            return Convert.ToInt32(propertiesCost[i]);
        }

        //gets the building cost based on index inputted as i
        public int getBuildingCost(int i)
        {
            return Convert.ToInt32(buildingCost[i]);
        }

        //gets property array
        public string[] getPropertiesList()
        {
            return properties;
        }

        //in theory would change availibility of property at index i, not working
        public void changeAvailability(int i)
        {
            availible[i] = false;
        }

        //in theory would check availibility of property at index i, not working
        public bool checkAvailability(int i)
        {
            if (availible[i] == true)
            {
                return true;
            }
            return false;
        }
    }
}
