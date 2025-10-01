namespace FactoryPattern;

public class Car : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Judging by your Input, you are riding a Car or a Truck.");

    }
}