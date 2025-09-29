namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Wheels do you have on your Vehicle? (1, 2, 3, or 4)?)");
            string VehicleType = Console.ReadLine();
            var vehicle = VehicleFactory.CreateVehicle(VehicleType);
            vehicle.Drive();

            if (VehicleType == "4")
            {
                Thread.Sleep(1500);
                Console.WriteLine("Oh, so you must be driving a Car or a Truck, which one is it?");
                var CarType =  Console.ReadLine();
                Console.WriteLine($"Nice, I've always wanted a {CarType}!");
            }
            
        }
    }
}
