namespace DesignPattern.Creational.Factory
{
    using System;

    public class FactoryVehicle
    {
        public static Vehicle CreateVehicle(VehicleType type)
        {
            switch (type)
            {
                case VehicleType.None:
                    return new Vehicle();
                case VehicleType.Bicycle:
                    return new Vehicle(VehicleType.Bicycle);
                case VehicleType.Motorcycle:
                    return new Vehicle(VehicleType.Motorcycle);
                case VehicleType.Car:
                    return new Vehicle(VehicleType.Car);
                case VehicleType.Bus:
                    return new Vehicle(VehicleType.Bus);
                default:
                    throw new ArgumentException("There is no type of that");
            }
            throw new ArgumentException("There is no type of that");
        }

        public class Vehicle
        {
            public VehicleType Type { get; set; }
            internal Vehicle(VehicleType type)
            {
                Type = type;
            }
            internal Vehicle()
            {
                Type = VehicleType.None;
            }
        }
    }

    public enum VehicleType
    {
        None,
        Bicycle,
        Motorcycle,
        Car,
        Bus
    }
}
