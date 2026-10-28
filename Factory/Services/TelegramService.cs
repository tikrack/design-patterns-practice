using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Services
{
    internal class TelegramService : INotification
    {
        public void Send(string message)
        {
            MessageBox.Show($"{message} => with Telegram");
        }
    }
}
