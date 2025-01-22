using OrderProcessingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp.Factories
{
    public class DigitalOrderFactory: IOrderFactory
    {
        public Order CreateOrder()
        {
            return new DigitalOrder();
        }
    }
}
