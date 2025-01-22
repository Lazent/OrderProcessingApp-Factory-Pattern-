using OrderProcessingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp.Services
{
    public class OrderProcessor
    {
        private readonly List<Order> _orders = new List<Order>();

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }
        public void RemoveOrder(Order order)
        {
            _orders.Remove(order);
        }
        public void ProcessAllOrders()
        {
            foreach (var order in _orders)
            {
                order.ProcessOrder();
            }
        }
    }
}
