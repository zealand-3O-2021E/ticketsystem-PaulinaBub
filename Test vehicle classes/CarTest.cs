using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using ClassLibraryTicketSystem;

namespace Test_vehicle_classes
{
    [TestClass]
    public class CarTest
    {
        private double Expected = 240.0;
        Car car1 = new Car();
        [TestMethod]
        public void TestMethodPrice()
        {
            car1.Price = Expected;
        }
    }
}
