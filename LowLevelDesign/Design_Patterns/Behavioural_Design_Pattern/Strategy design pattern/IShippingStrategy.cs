using LowLevelDesign.SOLID.Open_And_Closed_Principle;

namespace LowLevelDesign.Design_Patterns.Behavioural_Design_Pattern.Strategy_design_pattern
{
    public interface IShippingStrategy
    {
        double CalculateShippingCost(Order order);
    }

    public class WeightBasedShippingStrategy : IShippingStrategy
    {
        public double CalculateShippingCost(Order order)
        {
            double shippingCost = order.Weight * 0.5; // $0.50 per pound
            return shippingCost;
        }
    }

    // Define another concrete strategy that calculates shipping cost based on order total
    public class TotalBasedShippingStrategy : IShippingStrategy
    {
        public double CalculateShippingCost(Order order)
        {
            double shippingCost = order.Total * 0.1; // 10% of the total order cost
            return shippingCost;
        }
    }

    // Define the context that uses the strategy
    public class Order
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public double Weight { get; set; }
        private IShippingStrategy _shippingStrategy;

        public Order(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public double CalculateShippingCost()
        {
            return _shippingStrategy.CalculateShippingCost(this);
        }

        public void SetShippingStrategy(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }
    }

    // Example usage
    /*
     

     Order order = new Order(new WeightBasedShippingStrategy());
    double shippingCost = order.CalculateShippingCost(); // calculates shipping cost based on weight
    order.SetShippingStrategy(new TotalBasedShippingStrategy());
    shippingCost = order.CalculateShippingCost(); // calculates shipping cost based on order total
    
     
     */
}
