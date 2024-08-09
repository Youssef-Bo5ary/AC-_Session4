using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC__Session4.Youtube
{
    internal class Subscriber
    {
        public string? SubscriberName {  get; set; }


        public override string ToString()
        {
            return $" the subscriber name:{SubscriberName}";
        }

        public void Notify(Video video, Chanel channel)
        {
            Console.WriteLine($"the Channel {channel.ChannelName} has been added a New video {video.Title}, {SubscriberName}");
        }


    }
}
