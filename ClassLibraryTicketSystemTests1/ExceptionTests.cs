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
    public class ExceptionTests
    {
        [TestMethod()]
        public void LicensePlateLengthTestExeption()       
        {
            Vehicle car = new Car();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.Licenseplate = "ABC1234567");
        }
        [TestMethod()]
        public void LicensePlateLenghtTest()
        {
            Vehicle car = new Car();
            car.Licenseplate = "ABC";
            int lenghtOfLicensePlate = car.Licenseplate.Length;
            Assert.IsTrue(lenghtOfLicensePlate < 7);
        }

    }
}