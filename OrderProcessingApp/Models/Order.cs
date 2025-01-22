using OrderProcessingApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp.Models
{
    public abstract class Order
    {
        public string OrderId = OrderIdGenerator.GenerateOrderId();
        public abstract void ProcessOrder();
    }
}
