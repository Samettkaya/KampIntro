using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms Yolandı");
        }
    }
}
