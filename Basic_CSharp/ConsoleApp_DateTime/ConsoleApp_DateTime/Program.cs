using System;

namespace ConsoleApp_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;                   //Intantiate a new DateTime object
            Console.WriteLine("The current date/time is: {0}", dateTime);

            Console.WriteLine("Enter a number of hours...");
            int input = Convert.ToInt32(Console.ReadLine());
            TimeSpan timeSpan = new TimeSpan(0, input, 0, 0);
            //Addition operator:
            DateTime laterTime = dateTime + timeSpan;           
            Console.WriteLine($"In {input} hours it will be {laterTime}");
            //.Add method:
            Console.WriteLine($"In {input} hours it will be {dateTime.Add(timeSpan)}");

            //Set a timespan for the future: 
            TimeSpan timeSpan1 = new TimeSpan(1, 2, 0);
            System.Diagnostics.Debug.WriteLine(timeSpan1.Hours);  //Log the number of Hours/Minutes/Seconds to the debug terminal.

            //Format DateTime
            Console.WriteLine("Format the DateTime using .ToString(values):");
            Console.WriteLine(DateTime.Now.ToString("dddd, M/dd/yyyy h:mm:ss tt"));

            //UTC (formerly GMT)
            DateTime dateTimeUTC = DateTime.UtcNow;
            DateTime dateTimeUTCToLocal = DateTime.UtcNow.ToLocalTime();
            DateTime dateTimeLocalToUTC = DateTime.Now.ToUniversalTime();
            Console.WriteLine("The UTC time is: " + dateTimeUTC.ToString("MM/dd/yy HH:mm:ss") + " " + dateTimeUTC.Kind);

            Console.ReadLine();
        }
    }
}
