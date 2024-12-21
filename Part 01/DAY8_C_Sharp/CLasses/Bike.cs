using DAY8_C_Sharp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8_C_Sharp.CLasses
{
    //problem 01
    internal class Bike : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Start Engine of Bike");
        }

        public void StopEngine()
        {
            Console.WriteLine("Stop Engine of Bike");
        }
    }
}
