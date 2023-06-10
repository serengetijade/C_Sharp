using System;

namespace Key_Console_Modifiers
{
    class Program
    {
        public static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            Console.TreatControlCAsInput = true;       //Without this line, ctrl+c would close the console. Now, it is considered user input.

            //Check if the key combo was pressed with ctrl/alt/shift. 
            do
            {
                keyInfo = Console.ReadKey();

                if ((keyInfo.Modifiers & ConsoleModifiers.Alt) != 0)
                {
                    Console.Write("ALT + ");
                }
                if ((keyInfo.Modifiers & ConsoleModifiers.Shift) != 0)
                {
                    Console.Write("Shift + ");
                }
                if ((keyInfo.Modifiers & ConsoleModifiers.Control) != 0)
                {
                    Console.Write("Control + ");
                }
            }
            while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}