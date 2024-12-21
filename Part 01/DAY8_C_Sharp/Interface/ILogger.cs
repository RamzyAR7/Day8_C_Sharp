using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8_C_Sharp.Interface
{
    internal interface ILogger
    {
        void Log()
        {
            Console.WriteLine("log from interface");
        }
    }
}
