namespace DesignPattern.Creational.Factory.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class FactoryVehicleTest
    {
        [TestMethod]
        public void build_a_bicycle()
        {
            var myBicycle = FactoryVehicle.CreateVehicle(VehicleType.Bicycle);
            const VehicleType typeExpected = VehicleType.Bicycle;
            Assert.AreEqual(typeExpected, myBicycle.Type);
        }

        [TestMethod]
        public void build_a_car()
        {
            var myCar = FactoryVehicle.CreateVehicle(VehicleType.Car);
            const VehicleType typeExpected = VehicleType.Car;
            Assert.AreEqual(typeExpected, myCar.Type);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void build_something()
        {
            var myCar = FactoryVehicle.CreateVehicle((VehicleType)100);
        }
    }
}
