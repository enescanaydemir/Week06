namespace VehicleManagementSystemProject;

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("Audi", "Q1", 2019, 4, "Blue");
        Bicycle bicycle1 = new Bicycle("Audi", "Q1", 2019, 21, 4);
        Motorcycle motorcycle1 = new Motorcycle("Audi", "Q1", 2019, true, "Red");


        car1.DisplayInfo();

    }
}
