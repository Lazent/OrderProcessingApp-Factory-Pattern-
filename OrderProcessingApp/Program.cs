using OrderProcessingApp.Factories;
using OrderProcessingApp.Services;
namespace OrderProcessingApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Order Processing Application");

            IOrderFactory physicalFactory = new PhysicalOrderFactory();
            IOrderFactory digitalFactory = new DigitalOrderFactory();
            IOrderFactory subscriptionFactory = new SubscriptionOrderFactory();

            var orderProcessor = new OrderProcessor();

            orderProcessor.AddOrder(physicalFactory.CreateOrder());
            orderProcessor.AddOrder(digitalFactory.CreateOrder());
            orderProcessor.AddOrder(subscriptionFactory.CreateOrder());

            orderProcessor.ProcessAllOrders();
            Console.WriteLine("\nAll orders processed successfully!");
        }
    }
}