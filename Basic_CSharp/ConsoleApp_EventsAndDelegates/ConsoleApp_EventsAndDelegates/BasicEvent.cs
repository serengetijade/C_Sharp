using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_EventsAndDelegates
{
    public class BasicEvent
    {
        //Step1: Define Event Handler:
        private static event EventHandler evt;

        //Step2: Handler method:
        public static void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Hello Events");
        }

        public static void MainMethod()
        {
            //Step3: Subscribe to event: *
            evt += HandleEvent;

            //Step 4: Raise the event:
            //Syntax: eventName.Invoke(sender, new EventArgs());
            evt.Invoke(null, new EventArgs());
        }

        //Step 5: Dispose of events with a destructor:
        ~BasicEvent()
        {
            evt -= HandleEvent;
        }
    }
}
