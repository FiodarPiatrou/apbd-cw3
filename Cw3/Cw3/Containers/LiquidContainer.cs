using Cw3.Interfaces;

namespace Cw3;

public class LiquidContainer : Container, IHazardNotifier
{
    private bool dangerous;

    public LiquidContainer(double cargoWeight, double height, double depth, double maxWeight, bool isDangerous)
        : base(cargoWeight, height, depth, maxWeight)
    {
        Dangerous = isDangerous;
        SerialNumber = "KON-L-" + Number;
    }

    public bool Dangerous { get; set; }

    public override void Load(double cargoWeight)
    {
        if (Dangerous && cargoWeight > 0.5 * MaxWeight)
        {
            HazardNotification();
        }
        else if (cargoWeight > 0.9 * MaxWeight)
        {
            HazardNotification();
        }
        base.Load(cargoWeight);
    }

    public void HazardNotification()
    {
        Console.WriteLine("Unsafe situation with container: " + SerialNumber);
    }
}