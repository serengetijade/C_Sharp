using System;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;

namespace Custom_Attribute
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obsolete Attribute:
            [Obsolete("OldMethod is obsolete.Please use NewMethod instead")]
            static void OldMethod() { };
            static void NewMethod() { };

            ////Conditional Attribute: 
            //[Conditional("Condition1 example text")]
            //void ExampleMethod() { };

        }
    }
}

//Custom Attribute:
[AttributeUsage(AttributeTargets.All)]      //This attribute is valid for all targets. 
public class ExampleAttribute : Attribute { }

class ExampleClass
{
    [ExampleAttribute]
    private object exampleObj;
}