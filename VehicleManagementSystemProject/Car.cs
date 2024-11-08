using System;

namespace VehicleManagementSystemProject;

public class Car : Vehicle
{
    public Car(string make, string model, int year, int numberOfDoors, string color) : base(make, model, year)
    {
        NumberOfDoors = numberOfDoors;
        Color = color;
    }

    public int NumberOfDoors { get; set; }
    public string Color { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Araç Rengi: {Color}");
        Console.WriteLine($"Araç Modeli: {Model}");
    }
}
