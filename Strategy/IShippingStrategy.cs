using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    internal interface IShippingStrategy
    {
        decimal Calculate(decimal weight);
    }
}
