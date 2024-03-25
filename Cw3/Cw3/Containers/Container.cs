using Cw3.Exceptions;
using Cw3.Interfaces;

namespace Cw3;

public abstract class Container: IContainer
{
    private double _cargoWeight;
    private double _selfWeight;
    private double _height;
    private double _depth;
    private double _maxWeight;
    private string _serialNumber;
    private static int number=0;

    protected Container(double cargoWeight, double height, double depth, double maxWeight, double selfWeight)
    {
        SelfWeight = selfWeight;
        CargoWeight = cargoWeight;
        Height = height;
        Depth = depth;
        MaxWeight = maxWeight;
        Number++;
    }

    public double CargoWeight { get; set; }
    public double Height { get; set; }
    public double MaxWeight { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; protected set; }
    protected int Number {  get; private set; }
    public virtual void Unload()
    {
        CargoWeight = 0;
    }
    

    public virtual void Load(double cargoWeight)
    {
        if (cargoWeight>MaxWeight)
        {
            throw new OverfillException();
        }
        CargoWeight += cargoWeight;
        
    }

    public double SelfWeight { get; set; }

    public override string ToString()
    {
        return "Weight: "+SelfWeight+
               "\nCurrent load: "+CargoWeight+
               "\nMax load: "+MaxWeight+
               "\nHeight: "+Height+
               "\nDepth: "+Depth;
    }
}