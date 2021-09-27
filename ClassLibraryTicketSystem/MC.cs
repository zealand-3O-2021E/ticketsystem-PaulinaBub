using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC
    {
        public string Licenseplate;
        public DateTime Date;

        public double Price()
        {
            return 125;
        }
        public string VehicleType()
        {
            string type = "MC";
            return type;
        }
    }
}
