using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            // arrange
            double expected = 240.0;
            Car car = new Car();
            // act
            // assert
            Assert.AreEqual(expected, car.Price());
            
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            // arrange
            string expected = "Car";
            Car car = new Car();
            // act
            // assert
            Assert.AreEqual(expected, car.VehicleType());
        }
    }
}