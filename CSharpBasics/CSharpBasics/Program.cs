using System;

/*
namespace CSharpBasics
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Acme Accounting Systems\nRemember, we're \"accounting\" on you!");
            Console.Read();
        }
    }
}
*/

/*
namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ctrl + k + c = comments out all selected lines. Ctrl + k + u = uncomments selected lines. 
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.Read();

            //Data types:
            //bool isStudying = true;
            //byte hourseWorked = 42;
            //sbyte currentTemperature = -23;
            //char questionMark = '\u2103';
            //double heightINcm = 69.234;
            //decimal moneyInBank = 100.5m;
            //float secondsLeft = 2.62f;
            //short tempMars = -341;

            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNumber = Convert.ToInt32(favoriteNumber);
            //int total = favNumber + 5;
            //Console.WriteLine("Your favorite number, plus 5, is: " + total);

            //int currentAge = 30;
            //string yearsOld = currentAge.ToString();
            //bool isRaining = true;
            //string rainingStatus = Convert.ToString(isRaining);

        }
    }
}
*/
/*
namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report");

            Console.WriteLine("What is your name?");        //Write a question to the console.
            string studentName = Console.ReadLine();        //Accept user input and store it as a (string type) variable.
            Console.WriteLine("What course are you on?");
            string studentCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
            short pageNumber = Convert.ToInt16(page);       //convert user input to short data type
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();
            bool helpWith = Convert.ToBoolean(help);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string study = Console.ReadLine();
            decimal studyHours = Convert.ToDecimal(study);  //convert user input to decimal data type. 

            Console.WriteLine("Thank you for your answers.\nAn Instructor will respont to this shortly.\nHave a great day!");
            Console.Read();
        }
    }
}
*/
namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 7;
            int diff = num1 - num2;
            Console.WriteLine(diff);

            int product = num1 * num2;
            Console.WriteLine(product);

            int remainder = num2 % num1;
            Console.WriteLine(remainder);

            int num3 = 8;
            float num4 = 5.5f;
            float total1 = num3 + num4;
            int total2 = num3 + (Int32)num4;
            Console.WriteLine(total1 + " & " + total2);

            //String concatenation: 
            string myName = "Jade";
            string username = myName + num4;
            Console.WriteLine(username);

            Console.WriteLine("Please enter a number:");
            string userNum = Console.ReadLine();
            float userNumber = Convert.ToSingle(userNum);
            Console.WriteLine("Times 50: "+ userNumber * 50);
            Console.WriteLine("Plus 25: " + userNumber + 25);
            Console.WriteLine("Divided by 12.5: " + userNumber / 12.5);
            Console.WriteLine("Is greater than 50? " + (userNumber > 50));
            Console.WriteLine("Remainder from 7: " + (userNumber % 7));     //Use the modulus to find the remainder after userNumber/7
            Console.Read();
        }
    }
}
