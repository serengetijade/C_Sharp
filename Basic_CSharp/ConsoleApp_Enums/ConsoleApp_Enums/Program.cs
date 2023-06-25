using System;

namespace ConsoleApp_Enums
{
    public class Program
    {

        public static void Main(string[] args)
        {
            methodName();
            //public enum DaysOfWeek = new Enum { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

            Console.WriteLine("Enter the current day of the Week");
            try
            {
                string readDay = Console.ReadLine();
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), readDay);
                Console.WriteLine(day);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
        }

        //Enum examples with built in methods: 
        enum ExampleEnum { Element1 = 5, Element2, Element3, Element4 };

        public static void methodName()
        {
        Console.WriteLine(Enum.GetName(typeof(ExampleEnum), 6));    //Result: 'Element2' because Element1 has a value of 5. 

        //Get the name of each element in an enum: 
        foreach(string s in Enum.GetNames(typeof(ExampleEnum)))
            {
                Console.WriteLine(s);
            }

        //Get the value of each element in an enum: 
        foreach (int i in Enum.GetValues(typeof(ExampleEnum))) { Console.WriteLine(i); }
        }
    }
}
