namespace FactoryPattern;

public class VehicleFactory
{
    public static IVehicle CreateVehicle(string wheelCount)
    {
        switch (wheelCount.ToLower())
        {
            case "1":
            case "one":    
                return new Unicycle();
            
            case "2":
            case "two":    

                return new Motorcycle();
            
            case "3":
            case "three":    

                return new Tricycle();
            
            case "4":
            case "four":    

                return new Car();
            default:
                return new Car();

                
                
        }
    }
}