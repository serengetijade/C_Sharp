using System;

namespace ShippingQuote
{
    class ShippingQuote
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.\nPlease follow the instructions below.\nWhat is the package weight?");
            decimal packWeight = Convert.ToDecimal(Console.ReadLine());
            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            else
            {
                //Console.ReadLine() to get the user's package dimensions:
                Console.WriteLine("What is the package width?");
                decimal packWidth = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("What is the package height?");
                decimal packHeight = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("What is the package length?");
                decimal packLength = Convert.ToDecimal(Console.ReadLine());
                //Ternary operator (?) to return quote:
                string quote = (packWidth + packHeight + packLength) > 50 ? "Package too big to be shipped via Package Express." : "Shipping quote: $" + ((packWidth * packHeight * packLength * packWeight) / 100);
                Console.WriteLine(quote);
            }
        }
    }
}