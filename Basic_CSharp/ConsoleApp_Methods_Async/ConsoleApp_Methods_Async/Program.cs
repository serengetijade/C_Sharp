using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Async_Methods
{
    /// <summary>
    /// Give an example of asynchronous methods, using the theme of preparing a meal. 
    /// </summary>
    class Program
    {
        static async Task CookMeat()
        {
            Console.WriteLine("Cook meat.");
        }         
        static async Task CookVegetables()
        {
            Console.WriteLine("Cook veggies.");
        }
        static async Task MakeBread()
        {
            Console.WriteLine("Make bread.");
        }
        static async Task MakeSoup()
        {
            Console.WriteLine("Make soup.");
        }
        static async Task MakeSalad()
        {
            Console.WriteLine("Make salad.");
        }
        static async Task MakeDinner()
        {
            await CookMeat();
            await CookVegetables();
            await MakeBread();
            await MakeSoup();
            await MakeSalad();
        }
        public static void Main(string[] args) {
            MakeDinner();
        }
    }
}
