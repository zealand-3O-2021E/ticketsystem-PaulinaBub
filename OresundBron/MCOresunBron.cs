using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBron
{
    public class MCOresunBron : MC
    {
        public override double Price()
        {
            if (Brobizz)
                return 73;
            else
                return 210;
        }

        
        public override string VehicleType()
        {
            string type = "Oresund MC";
            return type;
        }
    }
}
