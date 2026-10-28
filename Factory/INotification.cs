using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    internal interface INotification
    {
        public void Send(string message);
    }
}
