using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>  
    public class Car : Vehicle
    {
        /// The method Price returns the price with the neccesary discounts (Brobizz) applied
        override public double Price ()
        {
            double price = 240;
            if (Brobizz)
                return price * 0.95;
            else
                return price;
        }
        /// The method VehicleType returns the type of the vehicle as a string

        override public string VehicleType()
        {
            string type = "Car";
            return type;
        }
    }
}
