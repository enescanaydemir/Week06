using System;

namespace VehicleManagementSystemProject;

public class Motorcycle : Vehicle
{
    public Motorcycle(string make, string model, int year, bool hasSidecar, string color) : base(make, model, year)
    {
        HasSidecar = hasSidecar;
        Color = color;
    }

    public bool HasSidecar { get; set; }
    public string Color { get; set; }
}
