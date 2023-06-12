using System;
using System.Threading;

namespace TicTacToe
{
    class Program
    {
        static char[] spaces = new char[] {'1','2','3','4','5','6','7','8','9'};    //Recall: char types use single '' quotes. 
        static int player = 1;
        static int choice;
        static int flag;

        /// <summary>
        /// Draw the game board:
        /// </summary>
        static void DrawTTTBoard()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", spaces[0], spaces[1], spaces[2]);
            Console.WriteLine("_____|_____|_____");              
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", spaces[3], spaces[4], spaces[5]);
            Console.WriteLine("_____|_____|_____"); 
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", spaces[6], spaces[7], spaces[8]);
            Console.WriteLine("     |     |     ");
        } 

        /// <summary>
        /// Check if win condition has been met, the game has tied, or game can continue:
        /// </summary>
        /// <returns></returns>
        static int CheckForWin()
        {
            if (spaces[0] == spaces[1] && spaces[1] == spaces[2] ||
                spaces[3] == spaces[4] && spaces[4] == spaces[5] ||
                spaces[6] == spaces[7] && spaces[7] == spaces[8] ||
                //Vertical
                spaces[0] == spaces[3] && spaces[3] == spaces[6] ||
                spaces[1] == spaces[4] && spaces[4] == spaces[7] ||
                spaces[2] == spaces[5] && spaces[5] == spaces[8] ||
                //Diagonal
                spaces[0] == spaces[4] && spaces[4] == spaces[8] ||
                spaces[2] == spaces[4] && spaces[4] == spaces[6])
            {
                return 1;
            }
            else if (spaces[0] != '1' &&
                spaces[1] != '2' &&
                spaces[2] != '3' &&
                spaces[3] != '4' &&
                spaces[4] != '5' &&
                spaces[5] != '6' &&
                spaces[6] != '7' &&
                spaces[7] != '8' &&
                spaces[8] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Draw an X or O on the game board based on the position/choise passed to the function.
        /// </summary>
        /// <param name="position"></param>
        static void DrawX(int position)
        {
            spaces[position] = 'X';
        }            
        static void DrawO(int position)
        {
            spaces[position] = 'O';
        }

        /// <summary>
        /// Main game loop
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Player 1: X and Player 2: O");
                if (player % 2 == 0)    //Use modulus 2 to determine if player is odd(Player_1) or even(Player_2)
                {
                    Console.WriteLine("Player 2's turn.");
                }
                else
                {
                    Console.WriteLine("Player 1's turn.");
                }
                Console.WriteLine("\n");
                DrawTTTBoard();
                //Get the user's choice:
                //choice = int.Parse(Console.ReadLine()) - 1;      //Recall that indexes start at 0, so must subtract 1 to get correct index.
                choice = Convert.ToInt32(Console.ReadLine()) - 1;
                //Pass the choice to the Draw functions (if the space is not already taken):
                if (spaces[choice] != 'X' && spaces[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        DrawO(choice);
                    }
                    else
                    {
                        DrawX(choice);
                    }
                    player++;
                }
                else
                {
                    Console.WriteLine("Sorry, the row {0} is already marked with {1}.\n", choice, spaces[choice]);
                    Console.WriteLine("Please wait while the board reloads...");
                    Thread.Sleep(1000);    ///Give the board time to reload. 
                }
                flag = CheckForWin();
            }
            while (flag != 1 && flag != -1);

            Console.Clear();
            DrawTTTBoard();

            if(flag == 1)
            {
                Console.WriteLine("Player {0} has won!", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Tie Game");
            }

            Console.ReadLine();
        }
    }
}
