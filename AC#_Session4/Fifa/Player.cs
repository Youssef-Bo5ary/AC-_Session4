using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC__Session4.Fifa
{
    internal class Player
    {
        public string PlayerName {  get; set; }
        public string TeamName { get; set; } 

        public void Run(Ball ball)
        {
            Console.WriteLine($"Player: {PlayerName} is Running to the ball {ball}");
        }
    }
}
