using ConsoleApp_Conditional_If;
using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;

namespace ConditionalStatements
{
    class ifStatements
    {
        static void Main(string[] args)
        {   
            if(true)
            {
                Console.WriteLine("Hello!");
            }

            if (1 == 1) //Use an equality comparison operator. 
            {
                Console.WriteLine("1 equals 1!");
            }
            else
            {
                Console.WriteLine("1 does not equal 1");
            }

            string name = "Adam";
            if (name == "Jesse")
            {
                Console.WriteLine("Your name is Jesse");
            }
            else if (name == "Brett")
            {
                Console.WriteLine("Your name is Brett, not Jesse");
            }
            else
            {
                Console.WriteLine("Your name is not Jesse nor Brett");
            }

            if (1 != 2)
            {
                Console.WriteLine("All is right with the universe.");
            }
            else
            {
                Console.WriteLine("We live in a bizarro world.");
            }

            int age = 19;
            if (age <= 17)
            {
                Console.WriteLine("You are too young for the movie.");
            }
            else
            {
                Console.WriteLine("Enjoy the show!");
            }

            string role = "admin";
            if (role == "admin" || role == "administration")
            {
                Console.WriteLine("You may access the entire software system.");
            }

            //Ternary (?) operator
            int num1 = 7;
            int num2 = 12;
            string result = num1 > num2 ? "num1 is greater than num2" : "num1 is not greater than num2";  //result if true : result if false
            Console.WriteLine(result);
            

            int currentTemp = 80;
            int roomTemp = 70;
            if (currentTemp == roomTemp)
            {
                Console.WriteLine("It is exactly room temperture.");
            }
            else if(currentTemp > roomTemp)
            {
                Console.WriteLine("It is warmer than room temperture.");
            }
            else
            {
                Console.WriteLine("It is not exactly room temperature.");
            } 
            

            //To write the above with ternary (?) operator:
            //int currentTemp = 80;
            //int roomTemp = 70;
            string comparisonResult = currentTemp == roomTemp ? "It is room temperature" : "It is not room temperature";
            Console.WriteLine(comparisonResult);

            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());
            string result2 = favNum == 12 ? "You have an awesome favorite number!" : "That is an interesting choice.";
            Console.WriteLine(result2);

            Console.ReadLine();

            //Null-Coalescing Operator ??: returns the value of its left-hand operand if it isn't null ; otherwise, it evaluates the right-hand operand  
            //Syntax: variableName = left operand ?? right operand
            var NullCoalescingObject1 = new NullCoalescingObject { Name = null };
            NullCoalescingObject1.Name = NullCoalescingObject1.Name ?? "Username";     
            
            var NullCoalescingObject2 = new NullCoalescingObject { Name = "Not null" };
            NullCoalescingObject2.Name = NullCoalescingObject2.Name ?? "Username";

            Console.WriteLine(NullCoalescingObject1.Name); 
            Console.WriteLine(NullCoalescingObject2.Name);
        }
    }
}

/*namespace ShippingQuoteApp
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
                //Ternary operator (?) to return if (not) shipable or a shipping quote:
                string ship = (packWidth + packHeight + packLength) > 50 ? "Package too big to be shipped via Package Express." : "Shipping quote: $" + ((packWidth * packHeight * packLength * packWeight) / 100);
                Console.WriteLine(quote);
            }                        
        }
    }
}*/

/*namespace InsuranceApprovalApp
{
    class InsApproval
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Enter y or n");
            char DUI = Convert.ToChar(Console.ReadLine());
            bool hasDUI = false;
            //Use the .Equals method and comparison operators in an if statement:
            if (Char.Equals(DUI, 'y') || Char.Equals(DUI, 'Y')) 
            {
                hasDUI = true;
            }
            else
            {
                hasDUI = false;
            }
            Console.WriteLine("How many speeding tickets do you have");
            int speeding = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified? " + (age >= 18 && hasDUI == false && speeding <= 3));    //Use AND to compare boolean results
            Console.ReadLine();
        }
    }
}*/