using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTicketSystem;

namespace StoreBaeltTicketLibrary
{
    public class StorebaeltCar:Car
    { 
        public override double Price()
        {
            double price = 240;
            if (Brobizz)
                return price * 0.95;
            else
                return price;
        }
    }
}
