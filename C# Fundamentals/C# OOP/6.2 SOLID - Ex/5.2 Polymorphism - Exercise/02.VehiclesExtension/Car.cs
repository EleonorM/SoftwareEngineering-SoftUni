﻿namespace _02.VehiclesExtension
{
    public class Car : Vehicle
    {
        private const double FuelConsumptionIncreasment = 0.9;
        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption+FuelConsumptionIncreasment
            ,tankCapacity)
        {
        }
    }
}
