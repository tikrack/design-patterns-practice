using Factory.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    internal class NotificationFactory
    {
        public static INotification Create(string type)
        {
            switch(type)
            {
                case "bale":
                    return new BaleService();
                case "telegram":
                    return new TelegramService();
                case "sms":
                    return new SmsService();
                default:
                    throw new Exception("Type of Factory not Found");
            }
        }
    }
}
