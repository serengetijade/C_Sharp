using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_EventsAndDelegates
{
    public class MessageService
    {
        //This is the "event" response (a method) for this class.
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message...." + args.Video.Title);
        }
    }
}
