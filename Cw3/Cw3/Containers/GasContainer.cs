using Cw3.Interfaces;

namespace Cw3;

public class GasContainer: Container,IHazardNotifier
{
    public GasContainer(double cargoWeight, double height, double depth, double maxWeight,double self) 
        : base(cargoWeight, height, depth, maxWeight,self)
    {
        SerialNumber = "KON-G-" + Number;
        
    }

    public void HazardNotification()
    {
        Console.WriteLine("Unsafe situation with container: " + SerialNumber);
        
    }
    public override string ToString()
    {
        return base.ToString()+"\nSerial Number:"+SerialNumber;
    }
    public override void Unload()
    {
        CargoWeight *= 0.05;
    }
}