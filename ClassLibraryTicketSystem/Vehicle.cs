using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    /// <summary>
    /// Vechile is the base class for Car and MC classes
    /// </summary>
    /// <returns></returns>  
    public abstract class Vehicle
    {
        private string licenseplate;
        /// You can only set the Licenseplate if the lenght is not more than 7, otherwise an exception will be thrown
        public string Licenseplate
        {
            get { return licenseplate; }
            set
            {
                if (value.Length > 7)
                    throw new ArgumentOutOfRangeException("licenseplate", "The licenseplate can not be bigger than 7.");
                else licenseplate = value;
            }
        }
        /// Date shows the date of when the ticket was bought
        public DateTime Date;
        /// Brobizz is a bool that is true when the brobizz discount needs to be applied
        public bool Brobizz { get; set; } 
        /// Price is abstract method for the ticket price
        public abstract double Price();
        /// Vehicle type is an abstract method for the type of the vechicle (string)
        public abstract string VehicleType();

    }
}
