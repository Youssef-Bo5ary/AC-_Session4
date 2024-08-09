using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC__Session4.Fifa
{
    internal class Ball
    {
        public int ID {  get; set; }
        
        private Location location;


        public Location Location
        {

            get
            {
                return location;
            }

            set
            {
                if (!value.Equals(location))
                {
                    location = value;
                    //Notify Subscriber
                    BallLocationChanged?.Invoke(this);
                }
               
            }

        }

        //Event
        public event Action<Ball>? BallLocationChanged;

        public override string ToString()
        {
            return $"{ID},Location ( {location})";
        }

    }
}
