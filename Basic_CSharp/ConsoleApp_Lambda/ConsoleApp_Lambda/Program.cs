using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Define a new List
            //List<string> FirstNames = new List<string>() {"Amber", "Bob", "Charlie", "Diana", "Elenor", "Frederick", "Harold", "Ida", "Joe", "Joe" };
            //List<string> LastNames = new List<string>() { "Anderson", "Bruce", "Chapman", "Delaine", "Emerson", "Forge", "Henderson", "Ivers", "Jones", "Jordan"};
            //List<Employees> EmployeesList = new List<Employees>();

            ////for loop to create employee and set their property value(s):
            //for (int i =0; i < FirstNames.Count; i++)
            //{
            //    Employees employee = new Employees();       //Instantiate a class object: className instanceName = new className();               
            //    employee.FirstName = FirstNames[i];         //Set a property value: instanceName.propertyName = value;
            //    employee.LastName = LastNames[i];           //Set a property value: instanceName.propertyName = value;
            //    EmployeesList.Add(employee);                
            //}

            //Make list of employees
            List<Employees> EmployeesList = new List<Employees> {
                new Employees {FirstName = "Amber", LastName = "Anderson", ID=1},
                new Employees {FirstName = "Bob", LastName = "Bruce", ID=2},
                new Employees {FirstName = "Charlie", LastName = "Chapman", ID=3},
                new Employees {FirstName = "Diana", LastName = "Delaine", ID=4},
                new Employees {FirstName = "Elenor", LastName = "Emerson", ID=5},
                new Employees {FirstName = "Frederick", LastName = "Forge", ID=6},
                new Employees {FirstName = "Harold", LastName = "Henderson", ID=7},
                new Employees {FirstName = "Ida", LastName = "Iverson", ID=8},
                new Employees {FirstName = "Joe", LastName = "Jones", ID=9},
                new Employees {FirstName = "Joe", LastName = "Jordan", ID=10}
            };

            //FOREACH LOOP TO COUNT A SPECIFIC value
            int counter = 0;
            List<Employees> loopList1 = new List<Employees>();
            foreach (Employees emp in EmployeesList)
            {
                if (emp.FirstName == "Joe")
                {
                    counter++;
                    loopList1.Add(emp);
                }
            }
            Console.WriteLine(counter);
            foreach (Employees obj in loopList1)
            {
                Console.WriteLine(obj.FirstName + " ID: " + obj.ID);
            }

            //LAMBDA FUNCTIONs TO MAKE A LIST OF CRITERIA MATCHING A SPECIFIC VALUE
            List<Employees> lambdaList1 = EmployeesList.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employees obj in lambdaList1)
            {
                Console.WriteLine(obj.FirstName + " ID: " + obj.ID);
            }
            List<Employees> lambdaList2 = EmployeesList.Where(x => x.ID >= 5).ToList();
            Console.WriteLine("All employees with ID numbers greater than 5:");
            foreach (Employees obj in lambdaList2)
            {
                Console.WriteLine(obj.LastName + ", ID: " + obj.ID);
            }
        }
    }
}
