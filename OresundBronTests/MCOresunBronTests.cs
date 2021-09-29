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
    public class MCOresunBronTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            MCOresunBron mc = new MCOresunBron();
            double expected = 210;
            Assert.AreEqual(expected, mc.Price());
        }
        [TestMethod()]
        public void PriceTestBrobizz()
        {
            MCOresunBron mc = new MCOresunBron {Brobizz = true};
            double expected = 73;
            Assert.AreEqual(expected, mc.Price());
        }
        [TestMethod()]
        public void TypeTest()
        {
            string expected = "Oresund MC";
            MCOresunBron mc = new MCOresunBron();
            Assert.AreEqual(expected, mc.VehicleType());
        }
    }
}