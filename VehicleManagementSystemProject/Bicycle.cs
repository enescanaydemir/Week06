using System;

namespace VehicleManagementSystemProject;

public class Bicycle : Vehicle
{
    public Bicycle(string make, string model, int year, int numberOfWheels, int numberOfGeers) : base(make, model, year)
    {
        NumberOfWheels = numberOfWheels;
        NumberOfGeers = numberOfGeers;
    }

    public int NumberOfWheels { get; set; }
    public int NumberOfGeers { get; set; }
}
