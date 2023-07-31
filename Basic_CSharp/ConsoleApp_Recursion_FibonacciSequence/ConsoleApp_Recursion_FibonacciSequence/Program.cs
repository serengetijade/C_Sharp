using System.Diagnostics;

namespace Recursion_FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine(fibRecursion(11));   //Result: 89
            Debug.WriteLine(fibIteration(11));
        }

        /// <summary>
        /// Find the value of the nth number in the fibonnaci sequence. 
        /// </summary>
        /// <param name="n"></param>
        /// <returns>An integer</returns>
        //FIBONACCI SEQUENCE VIA RECURSION
        static int fibRecursion(int n)
        {
            if(n ==0 || n == 1)
            {
                return n;
            }

            return fibRecursion(n - 1) + fibRecursion(n - 2);
        }

        //VIA ITERATION
        #region
        static int fibIteration(int n)
        {
            if (n == 0 || n == 1) { return n;}

            int secondToLast = 0;
            int last = 1;
            int curPos = 2;

            while(curPos <=n)
            {
                int temp = last;
                last = last + secondToLast;
                secondToLast = temp;
                curPos++;
            }
            return last;
        }
        #endregion
    }
}