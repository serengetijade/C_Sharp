using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_EventsAndDelegates
{
    internal class ActionExample
    {
        //Step 1: Instantiate an action, define parameter types, if any.\
        private static Action<int, int> actionName;

        //Step 2: Define a Action Handler
        static void HandleAction(int int1, int int2)
        {
            Console.WriteLine("Sum: " + (int1+int2));
        }

        public static void MainMethod(string[] args) {
            //Step 3: Subscribe to the Action:
            actionName += HandleAction;
            //Step 4: Invoke the action: 
            actionName.Invoke(2, 3);
        }
    }
}
