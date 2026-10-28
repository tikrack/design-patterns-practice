using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    internal class CheckoutService
    {
        private IShippingStrategy _shippingStrategy;

        public CheckoutService(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public decimal CalculateShipping(decimal weight)
        {
            return _shippingStrategy.Calculate(weight);
        }
    }
}
