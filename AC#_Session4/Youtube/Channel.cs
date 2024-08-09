using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC__Session4.Youtube
{
    internal class Chanel
    {
        public string? ChannelName { get; set; }
         public List<Video> videos { get; set; }=new List<Video>();

        public void AddVideo(Video video) 
        {
            videos.Add(video);
            //Notify Subscriber
            UploadVideo?.Invoke(video, this);
        }

        public event Action<Video ,Chanel>? UploadVideo;


        public override string ToString()
        {
            return $"Channel name {ChannelName}";
        }


    }
}
