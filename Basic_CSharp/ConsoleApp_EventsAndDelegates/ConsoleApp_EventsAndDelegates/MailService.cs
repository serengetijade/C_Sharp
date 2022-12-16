using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_EventsAndDelegates
{
    public class MailService
    {
        //This is the "event" response (a method) for this class.
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine($"The video ({e.Video.Title}) has been encoded.\nMailservice: Sending an email....");
        }
    }
}
