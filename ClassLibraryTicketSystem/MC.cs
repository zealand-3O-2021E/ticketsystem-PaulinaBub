using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Class with properties and methods for MC
    /// </summary>
    /// <returns></returns>  
    public class MC : Vehicle
    {   
        /// The method Price returns the price with the neccesary discounts (Brobizz) applied
        override public double Price()
        {
            double price = 125;
            if (Brobizz)
                return price * 0.95;
            else
                return price;
        }
        /// The method VehicleType returns the type of the vehicle as a string
        override public string VehicleType()
        {
            string type = "MC";
            return type;
        }
    }
}
