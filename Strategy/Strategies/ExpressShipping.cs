using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Strategies
{
    internal class ExpressShipping : IShippingStrategy
    {
        public decimal Calculate(decimal weight)
        {
            return weight * (decimal)3;
        }
    }
}
