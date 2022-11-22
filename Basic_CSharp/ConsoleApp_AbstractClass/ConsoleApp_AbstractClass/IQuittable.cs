using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_AbstractClass
{
    interface IQuittable
    {
        //Define a Method Syntax: accessModifier optional:returnType dataType functionName(dataType parameter){}
        void Quit()
        {
            {
                throw new NotImplementedException();
            }
        }
    }
}
