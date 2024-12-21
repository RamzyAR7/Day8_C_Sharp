using DAY8_C_Sharp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8_C_Sharp.CLasses
{
    internal class ConsoleLogger:ILogger
    {
        public void Log()
        {
            Console.WriteLine("log from  ConsoleLogger");
        }
    }
}
