using AC__Session4.Fifa;
using AC__Session4.Youtube;
using System.Collections;
using System.Threading.Channels;

namespace AC__Session4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Event 2nd type of Delegate

            #region Event EX01 
            //Ball ball = new Ball() { ID = 1 };
            ////  Console.WriteLine(ball);
            //ball.Location = new Location() { X = 1, Y = 1, Z = 1 };

            //Player p01 = new Player() { PlayerName = "Messi", TeamName = "miami" };
            //Player p02 = new Player() { PlayerName = "Alba", TeamName = "miami" };

            //Player p03 = new Player() { PlayerName = "Pedri", TeamName = "Barcelona" };
            //Player p04 = new Player() { PlayerName = "Gavi", TeamName = "Barcelona" };
            //Player p05 = new Player() { PlayerName = "Mohsen", TeamName = "Barcelona" };

            //Refree R01 = new Refree() { RefreeName = "Ibrahim" };

            //ball.BallLocationChanged += p01.Run;
            //ball.BallLocationChanged += p02.Run;
            //ball.BallLocationChanged += p03.Run;
            //ball.BallLocationChanged += p04.Run;
            //ball.BallLocationChanged += R01.Look;

            //// ball.Location = new Location() { X = 1, Y = 1, Z = 2 };
            //// Console.WriteLine(ball);
            //Console.WriteLine("after changing pedri with Mohsen");
            //Console.WriteLine();

            //ball.BallLocationChanged -= p03.Run;
            //ball.BallLocationChanged += p05.Run;


            //ball.Location = new Location() { X = 1, Y = 1, Z = 3 }; 
            #endregion

            #region Event EX02 

            // Chanel channel = new Chanel() { ChannelName = "ABC" };
            // channel.AddVideo(new Video() { Title = "title01", Description = "desc01" });

            // Subscriber s01 = new Subscriber() { SubscriberName = "AHmed" };
            // Subscriber s02 = new Subscriber() { SubscriberName = "Aly" };
            // Subscriber s03 = new Subscriber() { SubscriberName = "Aliaa" };
            // Subscriber s04 = new Subscriber() { SubscriberName = "Amr" };

            // Subscriber s05 = new Subscriber() { SubscriberName = "Youssef" };// add a new subscriber


            // channel.UploadVideo += s01.Notify;//here they subscribe the channel and waiting for new video
            // channel.UploadVideo += s02.Notify;//here they subscribe the channel and waiting for new video
            // channel.UploadVideo += s03.Notify;//here they subscribe the channel and waiting for new video
            // channel.UploadVideo += s04.Notify;//here they subscribe the channel and waiting for new video

            //// channel.AddVideo(new Video() { Title = "title02", Description = "desc02" });// new video added


            // channel.UploadVideo -= s03.Notify;
            // channel.UploadVideo += s05.Notify;// new notify for youssef

            // channel.AddVideo(new Video() { Title = "title03", Description = "desc03" }); 
            #endregion

            //Hashtable

            #region Non-Generic Hashtable  
            //  Hashtable Note=new Hashtable();
            ////  Console.WriteLine(Note.Count);
            //  Note.Add("Ahmed", 1111);//(key,value)
            //  Note.Add("Ali", 2222);  //(key,value)
            //  Note.Add("Omar", 3333); //(key,value)

            //  //foreach(DictionaryEntry item in Note) 
            //     // Console.WriteLine($"they key: {item.Key}, Value: {item.Value}");

            //  //foreach(object item in Note.Keys) Console.WriteLine(item);
            //  //foreach (object item in Note.Values) Console.WriteLine(item);

            //  Note["Mostafa"] = 9999;//set


            //  foreach(DictionaryEntry item in Note) 
            //   Console.WriteLine($"they key: {item.Key}, Value: {item.Value}"); 
            #endregion

            //Dictionary
            #region Dictionary-Generic  
            //Dictionary<string, long> Note = new Dictionary<string, long>(); //(key= string , Value = long)

            //Note.Add("Ahmed", 1111);
            //Note.Add("Ali", 2222);  // key should not reuse but the value can  
            //Note.Add("Amr", 3333);// مينفعش يتكرر   key

            //foreach(KeyValuePair<string, long> item in Note)//item here is key value pair type(and this the generic type)
            //    Console.WriteLine($"key: {item.Key}, Value: {item.Value}"); 
            #endregion


        }

    }
}
