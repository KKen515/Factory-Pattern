namespace FactoryPattern;

public class Car : IVehicle
{
    public void Drive()
    {
        Thread.Sleep(1500);
        Console.WriteLine("Oh, so you must be driving a Car or a Truck, which one is it?");
        var CarType =  Console.ReadLine();
        Console.WriteLine($"Nice, I've always wanted a {CarType}!");
    }
}