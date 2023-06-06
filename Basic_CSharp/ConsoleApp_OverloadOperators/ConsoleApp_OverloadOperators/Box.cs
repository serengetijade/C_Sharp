using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_OverloadOperators
{   
    class Box
    {
        //Class properties:
        private int length;
        private int width;
        private int height;

        //Class constructor:
        public Box (int length, int width, int height)
        {
            //this keyword references the class member variables
            this.length = length;
            this.width = width;
            this.height = height;
        }

        //Return the values of the variables
        public int GetLength()
        {
            return length;
        }
        public int GetWidth()
        {
            return width;
        }
        public int GetHeight()
        {
            return height;
        }

        //Overload the "+" operator, this will allow two boxes to be added together:
        //Syntax: public static returnType operatorKeyword operatorSymbolToOverload(Type parameter1, Type parameter 2){ ... }
        public static Box operator +(Box box1, Box box2)
        {
            return new Box(box1.GetLength() + box2.GetLength(), 
                box1.GetWidth() + box1.GetWidth(), 
                box1.GetHeight() + box2.GetWidth());
        }
    }
}

