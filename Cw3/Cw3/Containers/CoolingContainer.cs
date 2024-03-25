namespace Cw3;
using Exceptions;

public class CoolingContainer: Container
{
    private PossibleProducts _products;
    private double _temp;
    private static Dictionary<PossibleProducts, double> _allowed=new Dictionary<PossibleProducts, double>()
    {
        { PossibleProducts.Banana , 13.3},
        { PossibleProducts.Chocolate, 18},
        { PossibleProducts.Fish , 2},
        { PossibleProducts.Meat, -15.0},
        { PossibleProducts.IceCream ,-18},
        { PossibleProducts.FrozenPizza, -30},
        { PossibleProducts.Cheese , 7.2},
        { PossibleProducts.Sausages ,5},
        { PossibleProducts.Butter ,20.5},
        { PossibleProducts.Eggs ,19}
    }; 

    public CoolingContainer(double cargoWeight, double height, double depth, 
        double maxWeight, PossibleProducts products, double temp) : base(cargoWeight, height, depth, maxWeight)
    {
        Products = products;
        Temp = temp;
    }
    
    public PossibleProducts Products { get; set; }
    public double Temp { get; set; }
    public void Load(double cargoWeight, PossibleProducts products)
    {
        if (products!=Products)
        {
            throw new InappropriateProductException("Inappropriate product!");
        }

        double temp;
        _allowed.TryGetValue(products, out temp);
        if (temp<Temp)
        {
            throw new OverfreezeException();
        }
        
        base.Load(cargoWeight);
    }
}