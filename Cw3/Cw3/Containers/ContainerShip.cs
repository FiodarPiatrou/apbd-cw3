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

    public double GetLoad()
    {
        double sum=0;
        foreach (var cont in Containers)
        {
            sum += cont.CargoWeight;
        }

        return sum;
    }

    public void LoadContainer(Container container)
    {
        Containers.Add(container);
    }
    

    public void UnloadContainer(Container container)
    {
        Containers.Remove(container);
    }

    public override string ToString()
    {
        string info = "Max speed: " + MaxSpeed +
                      "\nMax weight: " + MaxWeight +
                      "\nMax number of containers: " + MaxNumber;
        foreach (var cont in Containers)
        {
            info += "\n\t" + cont;
        }
        return info;
    }

    public void Change(string sn, Container c1)
    {
        Container container=null;
        foreach (var c in Containers)
        {
            if (c.SerialNumber.Equals(sn))
            {
                container = c;
            }
        }

        if (container!=null)
        {
            UnloadContainer(container);
            LoadContainer(c1);
        }
    }

    public void Transfer(Container c, ContainerShip cs)
    {
        UnloadContainer(c);
        cs.LoadContainer(c);
    }
    

    public List<Container> Containers { get; set; }
    public double MaxSpeed { get; set; }
    public int MaxNumber { get; set; }
    public double MaxWeight { get; set; }
    
}