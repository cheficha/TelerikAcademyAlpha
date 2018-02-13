using Dealership.Contracts;
using Dealership.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dealership.Tests.Models
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void CarShouldImplementICar()
        {
            var type = typeof(Car);
            var IsAssignable = typeof(ICar).IsAssignableFrom(type);
            Assert.IsTrue(IsAssignable, "Car does not implement ICar interface");
        }
        [TestMethod]
        public void CarShouldImplementIVehicle()
        {
            var type = typeof(Car);
            var isAssignable = typeof(IVehicle).IsAssignableFrom(type);
            Assert.IsTrue(isAssignable, "Car does not implement IVehicle interface");
        }
        [TestMethod]
        public void CarSeatsSholdBeLessThan10()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Car("make", "model", 1000, 11));
        }
        [TestMethod]
        public void CarSeatsShouldBeMoreThan0()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Car("make", "model", 1221, -1));
        }
        [TestMethod]
        public void CarPriceSholdBePossitiveNumber()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Car("Make", "Model", -2, 3));
        }
        [TestMethod]
        public void CarPriceShouldBeLessThan100000()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Car("Make", "model", 100000000000000, 1));
        }
        [TestMethod]
        public void CarModelShouldNotBeNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Car("Make", null, 123, 4));
        }
        [TestMethod]
        public void CarModelShouldNotBeLessThan2()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Car("Make", "1", 123, 4));
        }
        [TestMethod]
        public void CarModelShouldNotBeHigherThan15()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Car("Make", "1234567891011121314", 123, 4));

        }
        [TestMethod]
        public void CarMakeShouldNotBeNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Car(null, "123", 123, 4));
        }
        [TestMethod]
        public void CarMakelShouldNotBeLessThan2()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Car("M", "123", 123, 4));
        }
        [TestMethod]
        public void CarMakeShouldNotBeHigherThan15()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Car("MakeMakeMakeMakeMakeMakeMAkeMAkeaksdaks", "123", 123, 4));

        }
    }
}
