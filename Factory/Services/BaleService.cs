using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Services
{
    internal class BaleService : INotification
    {
        public void Send(string message)
        {
            MessageBox.Show($"{message} => with Bale");
        }
    }
}
