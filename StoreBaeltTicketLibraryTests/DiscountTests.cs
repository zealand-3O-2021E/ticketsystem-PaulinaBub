using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class DiscountTests
    {
        [TestMethod()]
        public void GetDiscountTestSunday()
        {
            Car car = new Car();
            car.Date = new DateTime(2008, 6, 1);
            double expected = 192;
            double price = Discount.GetDiscount(car);
            Assert.AreEqual(expected, price);
        }
        [TestMethod()]
        public void GetDiscountTestSaturday()
        {
            Car car = new Car();
            car.Date = new DateTime(2008, 6, 7);
            double expected = 192;
            double price = Discount.GetDiscount(car);
            Assert.AreEqual(expected, price);
        }
        [TestMethod()]
        public void GetDiscountTestNoDiscount()
        {
            Car car = new Car();
            car.Date = new DateTime(2008, 6, 2);
            double expected = 240;
            double price = Discount.GetDiscount(car);
            Assert.AreEqual(expected, price);
        }
    }
}