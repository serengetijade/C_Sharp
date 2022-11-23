using System;

namespace ConsoleApp_Enums
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the current day of the Week");
            try 
            {
                string readDay = Console.ReadLine();
                DayOfWeek day = (DayOfWeek) Enum.Parse(typeof(DayOfWeek), readDay);
                Console.WriteLine(day);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
        }
    }
}
