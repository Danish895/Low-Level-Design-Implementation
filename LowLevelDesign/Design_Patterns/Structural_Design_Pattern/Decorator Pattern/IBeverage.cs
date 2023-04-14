namespace LowLevelDesign.Design_Patterns.Structural_Design_Pattern.Decorator_Pattern
{
    // Component interface
    public interface IBeverage
    {
        string GetDescription();
        double GetCost();
    }

    // Concrete component
    public class Espresso : IBeverage
    {
        public string GetDescription()
        {
            return "Espresso";
        }

        public double GetCost()
        {
            return 1.99;
        }
    }

    // Decorator base class
    public abstract class BeverageDecorator : IBeverage
    {
        protected IBeverage _beverage;

        public BeverageDecorator(IBeverage beverage)
        {
            _beverage = beverage;
        }

        public virtual string GetDescription()
        {
            return _beverage.GetDescription();
        }

        public virtual double GetCost()
        {
            return _beverage.GetCost();
        }
    }

    // Concrete decorator
    public class Milk : BeverageDecorator
    {
        public Milk(IBeverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", with milk";
        }

        public override double GetCost()
        {
            return _beverage.GetCost() + 0.50;
        }
    }

    // Usage


    /*
     * 
     * 
     * IBeverage beverage = new Espresso();
        Console.WriteLine(beverage.GetDescription()); // "Espresso"
    Console.WriteLine(beverage.GetCost()); // 1.99

    // Add milk
    beverage = new Milk(beverage);
        Console.WriteLine(beverage.GetDescription()); // "Espresso, with milk"
    Console.WriteLine(beverage.GetCost()); // 2.49
    
     
     */

}
