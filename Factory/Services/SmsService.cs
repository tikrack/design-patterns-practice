using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Services
{
    internal class SmsService : INotification
    {
        public void Send(string message)
        {
            MessageBox.Show($"{message} => with Sms");
        }
    }
}
