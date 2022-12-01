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

            Console.ReadLine();
        }
    }
}
