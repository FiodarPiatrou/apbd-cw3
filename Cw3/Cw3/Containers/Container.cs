using Cw3.Exceptions;
using Cw3.Interfaces;

namespace Cw3;

public abstract class Container: IContainer
{
    private double _cargoWeight;
    private double _selfWeight;
    private double _height;
    private double _depth;

    protected Container(double cargoWeight, double height)
    {
        CargoWeight = cargoWeight;
        Height = height;
    }

    public double CargoWeight { get; set; }
    public double Height { get; set; }
    public void Unload()
    {
        throw new NotImplementedException();
    }

    public virtual void Load(double cargoWeight)
    {
        CargoWeight = cargoWeight;
        throw new OverfillException();
    }
}