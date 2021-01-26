using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SMSLoggerService : ILoggerservıce
    {
        public void Log()
        {
            Console.WriteLine("SMS gonderimi loglandi"); 
        }
    }
}
