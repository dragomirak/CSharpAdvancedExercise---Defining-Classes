using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.SpeedRacing;

public class Car
{
    public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        TravelledDistance = 0;
    }

    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsumptionPerKilometer { get; set; } 
    public double TravelledDistance { get; set; } 

    public void Drive(int distance)
    {
        if (FuelAmount - (FuelConsumptionPerKilometer * distance) < 0)
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
        else
        {
            FuelAmount -= (FuelConsumptionPerKilometer * distance);
            TravelledDistance += distance;
        }
    }

    public override string ToString()
    {
        return $"{Model} {FuelAmount:f2} {TravelledDistance}";
    }
}
