using System;

namespace InsuranceApproval
{
    class InsApproval
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Enter true or false");
            bool DUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have");
            int speeding = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified? " + (age >= 18 && DUI == false && speeding <= 3));    //Use AND to compare boolean results
            Console.ReadLine();
        }
    }
}