using System.Diagnostics;

class Program
{
    public class Example
    {
        public static void Main(string[] args)
        {
            Debug.WriteLine(IsBalanced("{{[]}}").ToString());
            Debug.WriteLine(IsBalanced("{([}}").ToString());
        }

        private static bool IsBalanced(string inputString)
        {
            Stack<char> stackOfClosingBraces = new Stack<char>();
            Stack<char> stackOfOpeningBraces = new Stack<char>();

            //Iterate through the list to get closing characters: 
            foreach (char c in inputString)
            {
                if(c== '}' || c==']' || c==')') 
                { 
                stackOfClosingBraces.Push(c);
                }
            }
            //Iterate through the list BACKWARDS to get the opening characters:
            //The loop should be backwards because that allows us to compare the characters working from the outside of the string towards the inside.
            for (int i = inputString.Length - 1; i >= 0; i--)
            {
                if (inputString[i] == '{' || inputString[i] == '[' || inputString[i] == '(')
                {
                    stackOfOpeningBraces.Push(inputString[i]);
                }
            }
            
            //If the total number of opening/closing characters is odd, it can not be balanced. 
            if((stackOfClosingBraces.Count + stackOfOpeningBraces.Count)%2 != 0) { return false; }

            //Compare the opening/closing brackets: 
            while(stackOfClosingBraces.Count != 0)
            {
                char currentClosingBrace = stackOfClosingBraces.Pop();  //Pop returns the last element of the stack and removes it. 
                char currentOpeningBrace = stackOfOpeningBraces.Pop();  
                //Recall chars use single brackets '': 
                if ((currentClosingBrace == '}' && currentOpeningBrace=='{') || (currentClosingBrace == ']' && currentOpeningBrace == '[') || (currentClosingBrace == ')' && currentOpeningBrace == '(')) 
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            //To get to this point, the opening/closing brackets must all match up
            return true;
        }
    }
}