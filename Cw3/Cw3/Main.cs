// See https://aka.ms/new-console-template for more information

using Cw3;

LiquidContainer lc = new LiquidContainer(100, 100, 100, 1000, true, 100);
GasContainer gc = new GasContainer(100, 100, 100, 200, 100);
CoolingContainer cc = new CoolingContainer(100, 100, 100, 200, 
    PossibleProducts.Cheese, 8, 100);
lc.Load(50);
gc.Load(10);
cc.Load(50,PossibleProducts.Cheese);


ContainerShip cs= new ContainerShip(new List<Container>(),100,100,100);
var cs2 = new ContainerShip(new List<Container>(), 100, 100, 100);
List<Container> containers=new List<Container>(){lc,gc,cc};
cs.LoadContainer(lc);
cs.Containers=containers;
cc.Unload();
cs.Change("KON-G-2",new GasContainer(31,31,31,31,31));
cs.Transfer(lc,cs2);
Console.WriteLine(cs);
