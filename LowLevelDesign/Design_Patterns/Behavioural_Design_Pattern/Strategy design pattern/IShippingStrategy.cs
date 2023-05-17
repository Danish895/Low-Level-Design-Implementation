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

    public interface IPaymentStrategy
{
    void Pay(double amount);
}
Step 2: Implement different payment strategies

csharp
Copy code
public class CreditCardStrategy : IPaymentStrategy
{
    private string cardNumber;
    private string expiryDate;
    private string cvv;

    public CreditCardStrategy(string cardNumber, string expiryDate, string cvv)
    {
        this.cardNumber = cardNumber;
        this.expiryDate = expiryDate;
        this.cvv = cvv;
    }

    public void Pay(double amount)
    {
        // Implement credit card payment logic here
        Console.WriteLine($"Paid {amount} using credit card {cardNumber}");
    }
}

public class PayPalStrategy : IPaymentStrategy
{
    private string email;
    private string password;

    public PayPalStrategy(string email, string password)
    {
        this.email = email;
        this.password = password;
    }

    public void Pay(double amount)
    {
        // Implement PayPal payment logic here
        Console.WriteLine($"Paid {amount} using PayPal account {email}");
    }
}

public class BankTransferStrategy : IPaymentStrategy
{
    private string accountNumber;
    private string bankCode;

    public BankTransferStrategy(string accountNumber, string bankCode)
    {
        this.accountNumber = accountNumber;
        this.bankCode = bankCode;
    }

    public void Pay(double amount)
    {
        // Implement bank transfer logic here
        Console.WriteLine($"Paid {amount} via bank transfer to account {accountNumber}");
    }
}
Step 3: Use the payment strategies in the client code

csharp
Copy code
public class PaymentProcessor
{
    private IPaymentStrategy paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public void ProcessPayment(double amount)
    {
        paymentStrategy.Pay(amount);
    }
}
Step 4: Test the implementation

csharp
Copy code
class Program
{
    static void Main(string[] args)
    {
        PaymentProcessor processor = new PaymentProcessor();

        // Credit card payment
        string cardNumber = "1234567890123456";
        string expiryDate = "12/2024";
        string cvv = "123";
        IPaymentStrategy creditCardStrategy = new CreditCardStrategy(cardNumber, expiryDate, cvv);
        processor.SetPaymentStrategy(creditCardStrategy);
        processor.ProcessPayment(100.0);

        // PayPal payment
        string email = "example@example.com";
        string password = "password";
        IPaymentStrategy payPalStrategy = new PayPalStrategy(email, password);
        processor.SetPaymentStrategy(payPalStrategy);
        processor.ProcessPayment(50.0);

        // Bank transfer payment
        string accountNumber = "1234567890";
        string bankCode = "ABCD";
        IPaymentStrategy bankTransferStrategy = new BankTransferStrategy(accountNumber, bankCode);
        processor.SetPaymentStrategy(bankTransferStrategy);
        processor.ProcessPayment(200.0);

        Console.ReadLine();
    }
}
    
     
     */
}
