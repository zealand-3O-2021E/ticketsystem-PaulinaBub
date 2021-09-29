using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBron.Tests
{
    [TestClass()]
    public class CarOresunBronTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            CarOresunBron car = new CarOresunBron();
            double expected = 410;
            Assert.AreEqual(expected, car.Price());
        }
        [TestMethod()]
        public void PriceTestBrobizz()
        {
            CarOresunBron car = new CarOresunBron {Brobizz = true};
            double expected = 161;
            Assert.AreEqual(expected, car.Price());
        }
        [TestMethod()]
        public void TypeTest()
        {
            string expected = "Oresund car";
            CarOresunBron car = new CarOresunBron();
            Assert.AreEqual(expected, car.VehicleType());
        }
    }
}