using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;

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
        public void PriceTestBrobizz()
        {
            // arrange
            Car car = new Car() { Brobizz = true };
            double expected = 228;
            // act
            // assert
            Assert.AreEqual(expected, car.Price(), 0.05d);
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