using DAY8_C_Sharp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY8_C_Sharp.CLasses
{
    internal class Robot : IWalkable
    {
        void IWalkable.Walk()
        {
            Console.WriteLine("the Robot is Walking from IWalkable");
        }

        public void Watch()
        {
            Console.WriteLine("The Robot is Watching");
        }
    }
}
