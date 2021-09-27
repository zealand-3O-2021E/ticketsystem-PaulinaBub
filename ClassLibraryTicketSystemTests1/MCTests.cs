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
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            // arrange
            double expected = 125.0;
            MC mc = new MC();
            // act
            // assert
            Assert.AreEqual(expected, mc.Price());
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            // arrange
            string expected = "MC";
            MC mc = new MC();
            // act
            // assert
            Assert.AreEqual(expected, mc.VehicleType());
        }
    }
}