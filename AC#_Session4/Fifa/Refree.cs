using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC__Session4.Fifa
{
    internal class Refree
    {
        public string RefreeName {  get; set; }

        public void Look(Ball ball)
        {
            Console.WriteLine($"{RefreeName} is looking to ball {ball}");
        }
    }
}
