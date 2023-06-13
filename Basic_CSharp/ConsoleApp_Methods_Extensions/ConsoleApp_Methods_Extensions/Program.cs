using System;

namespace ExtensionMethods
{
    /// <summary>
    /// Extensions must be defined in a non-generic static class:
    /// They add methods to existing and/or built-in classes. 
    /// </summary>
    public static class Program
    {
        static bool ExtensionMethod_GreaterThan(this int i, int val)
        {
            if (i > val) return true;
            else return false;
        }
        static void Main(string[] args) 
        { 
            //Extension methods: 
            bool ext1 = 2.ExtensionMethod_GreaterThan(1);
            Console.WriteLine(ext1);
        }
    }
}