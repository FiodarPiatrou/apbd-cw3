namespace Cw3;

public class ContainerShip
{
    private List<Container> _containers;
    private double _maxSpeed;
    private int _maxNumber;
    private double _maxWeight;

    public ContainerShip(List<Container> containers, double maxSpeed, int maxNumber, double maxWeight)
    {
        Containers = containers;
        MaxSpeed = maxSpeed;
        MaxNumber = maxNumber;
        MaxWeight = maxWeight;
    }

    public void LoadContainer(Container container)
    {
        Containers.Add(container);
    }

    public void UnloadContainer(Container container)
    {
        Containers.Remove(container);
    }
    
    public List<Container> Containers { get; set; }
    public double MaxSpeed { get; set; }
    public int MaxNumber { get; set; }
    public double MaxWeight { get; set; }
    
}