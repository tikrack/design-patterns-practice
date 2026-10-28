using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Strategies
{
    internal class NormalShipping : IShippingStrategy
    {
        public decimal Calculate(decimal weight)
        {
            return weight * (decimal)1.5;
        }
    }
}
