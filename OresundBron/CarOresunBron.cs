using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBron
{
    public class CarOresunBron : Car
    {
        public override double Price()
        {
            if (Brobizz)
                return 161;
            else
                return 410;
        }
        public override string VehicleType()
        {
            string type = "Oresund car";
            return type;
        }
    }
}
