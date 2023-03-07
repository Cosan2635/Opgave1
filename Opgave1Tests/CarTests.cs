using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1.Tests
{
    [TestClass()]
    public class CarTests
    { 
        public Car car = new Car() { Id = 1, LicensePlate = "ZX36434", Model = "Mazda 3", Price = 1 };
        public Car neCar = new Car() { Id = 0, LicensePlate = "Mo2635", Model = "Omg 2", Price = 1 };
        public Car ModelMindreend4 = new Car() { Id = 2, LicensePlate = "CZ75-Auto", Model = "123", Price = 125000 };
        public Car ModelNullCar = new Car() { Id = 3, LicensePlate = "GingGung123", Model = null, Price = 240 };
        public Car NegCarPrice = new Car() { Id = 1, LicensePlate = "AlbSv241", Model = "I-5F", Price =-4};


        [TestMethod()]
        public void ValidateIdTest()
        {
            car.ValidateId();
            Assert.ThrowsException<ArgumentNullException>(() => neCar.ValidateId());
        }

        [TestMethod()]
        public void ValidateModelTest()
        {
            car.ValidateModel();
            Assert.ThrowsException<ArgumentNullException>(() => ModelNullCar.ValidateModel());
            Assert.ThrowsException<ArgumentOutOfRangeException>(ModelMindreend4.ValidateModel);
        }
        [TestMethod()]
        public void ValidatePriceTest()
        {
            car.ValidatePrice();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => NegCarPrice.ValidatePrice());
        }
    }
}