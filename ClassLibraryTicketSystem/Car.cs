using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class Car
    {
        public string Licenseplate;
        public DateTime Date;

        public double Price()
        {
            return 240;
        }
        public string VehicleType()
        {
            string type = "Car";
            return type;
        }
    }
}
