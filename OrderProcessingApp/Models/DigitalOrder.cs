using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp.Models
{
    public class DigitalOrder: Order
    {
        public override void ProcessOrder()
        {
            Console.WriteLine($"Order ID: {OrderId} - Sending digital product to email");
        }
    }
}
