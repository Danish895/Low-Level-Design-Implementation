namespace LowLevelDesign.SOLID.Open_And_Closed_Principle
{
    // Example of violating the Open/Closed Principle
    public class PaymentProcessor
    {
        public void ProcessPayment(Order order)
        {
            if (order.PaymentMethod == "Credit Card")
            {
                // Code to process credit card payment
            }
            else if (order.PaymentMethod == "PayPal")
            {
                // Code to process PayPal payment
            }
            else if (order.PaymentMethod == "Bitcoin")
            {
                // Code to process Bitcoin payment
            }
            // more payment methods...
        }
    }

    // Here, the PaymentProcessor class is not closed for modification, as we have to modify its code every time we add a new payment method.
    // This violates OCP.

    // Example of adhering to the Open/Closed Principle
    public interface IPaymentProcessor
    {
        void ProcessPayment(Order order);
    }

    public class CreditCardPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(Order order)
        {
            // Code to process credit card payment
        }
    }

    public class PayPalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(Order order)
        {
            // Code to process PayPal payment
        }
    }

    public class BitcoinPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(Order order)
        {
            // Code to process Bitcoin payment
        }
    }

    

    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public decimal OrderTotal { get; set; }
        public string PaymentMethod { get; set; }
        // more properties...
    }

    // Here, we've created an interface IPaymentProcessor that defines the ProcessPayment method, and we've implemented this interface for each payment method.
    // The PaymentProcessor class now depends on the IPaymentProcessor interface, rather than individual payment methods.
    // We can easily add new payment methods by creating a new class that implements the IPaymentProcessor interface.
    // This follows the Open/Closed Principle.

}
