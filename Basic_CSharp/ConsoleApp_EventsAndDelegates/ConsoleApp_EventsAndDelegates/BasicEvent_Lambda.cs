using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_EventsAndDelegates
{
    internal class BasicEvents_Lambda
    {
        //It is possible to combine steps 2, 3, and 5 from the BasicEvent Class by using a lambda expression: 

        //Step1: Define Event Handler:
        private static event EventHandler evt;
        
        public static void MainMethod()
        {
            //Step 2: Handler method & Subscribe to event: //Note: events can have multiple subscribers.
            evt += (sender, evtArgs) => { Console.WriteLine("Hello Lambda Events"); };
            evt += (sender, evtArgs) => { Console.WriteLine("Another Lambda Event"); };

            //Step 3: Raise the event:
            //Syntax: eventName.Invoke(sender, new EventArgs());
            evt.Invoke(null, new EventArgs());
        }
    }
}
