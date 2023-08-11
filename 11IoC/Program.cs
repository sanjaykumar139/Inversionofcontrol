// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");

Driver driver = new Driver(new BMW());
driver.RunCar();

public interface ICar
{
    int Run();
}

public class BMW : ICar
{
    private int _miles = 0;

    public int Run()
    {
        return ++_miles;
    }
}

public class Ford : ICar
{
    private int _miles = 0;

    public int Run()
    {
        return ++_miles;
    }
}

public class Audi : ICar
{
    private int _miles = 0;

    public int Run()
    {
        return ++_miles;
    }

}
public class Driver
{
    private ICar _car = null;

    public Driver(ICar car)
    {
        _car = car;
    }

    public void RunCar()
    {
        Console.WriteLine("Running {0} - {1} mile ", _car.GetType().Name, _car.Run());
    }
}



//Resolve
//Unity creates an object of the specified class and automatically injects the dependencies using the resolve() method.We have registered BMW with ICar above. Now, we can instantiate the Driver class using Unity container without using the new keyword as shown below.

//IUnityContainer container = new UnityContainer();
//container.RegisterType<ICar, BMW>();// Map ICar with BMW 

////Resolves dependencies and returns the Driver object 
//Driver drv = container.Resolve<Driver>();
//drv.RunCar();