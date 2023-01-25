using System;
using System.Collections.Generic;
using System.Text;

namespace Mission3Assignment
{
    public class SupportingClass
    {
        public string[] BoardDisplay(string[] board)
        {
            // prints out the board
            Console.WriteLine("\n\n");
            Console.WriteLine(board[0] + " | " + board[1] + " | " + board[2]);
            Console.WriteLine("---------");
            Console.WriteLine(board[3] + " | " + board[4] + " | " + board[5]);
            Console.WriteLine("---------");
            Console.WriteLine(board[6] + " | " + board[7] + " | " + board[8]);

            return board;
        }

        

        public bool GameWinner(string[] board)
         {
            bool wins = false;

            // if O's win
            if (board[0] == "O" && board[1] == "O" && board[2] == "O")
            { 
                Console.WriteLine("Player O wins!");
                wins = true;

            }
            else if (board[0] == "O" && board[3] == "O" && board[6] == "O")
            {
                Console.WriteLine("Player O wins!");
                wins = true;
            }
            else if (board[0] == "O" && board[4] == "O" && board[8] == "O")
            {
                Console.WriteLine("Player O wins!");
                wins = true;
            }
            else if (board[1] == "O" && board[4] == "O" && board[7] == "O")
            {
                Console.WriteLine("Player O wins!");
                wins = true;
            }
            else if (board[2] == "O" && board[5] == "O" && board[8] == "O")
            {
                Console.WriteLine("Player O wins!");
                wins = true;
            }
            else if (board[2] == "O" && board[4] == "O" && board[6] == "O")
            {
                Console.WriteLine("Player O wins!");
                wins = true;
            }
            else if (board[3] == "O" && board[4] == "O" && board[5] == "O")
            {
                Console.WriteLine("Player O wins!");
                wins = true;
            }
            else if (board[6] == "O" && board[7] == "O" && board[8] == "O")
            {
                Console.WriteLine("Player O wins!");
                wins = true;
            }

            // to check if X's win
            else if (board[0] == "X" && board[1] == "X" && board[2] == "X")
            {
                Console.WriteLine("Player X wins!");
                wins = true;
            }
            else if (board[0] == "X" && board[3] == "X" && board[6] == "X")
            {
                Console.WriteLine("Player X wins!");
                wins = true;
            }
            else if (board[0] == "X" && board[4] == "X" && board[8] == "X")
            {
                Console.WriteLine("Player X wins!");
                wins = true;
            }
            else if (board[1] == "X" && board[4] == "X" && board[7] == "X")
            {
                Console.WriteLine("Player X wins!");
                wins = true;
            }
            else if (board[2] == "X" && board[5] == "X" && board[8] == "X")
            {
                Console.WriteLine("Player X wins!");
                wins = true;
            }
            else if (board[2] == "X" && board[4] == "X" && board[6] == "X")
            {
                Console.WriteLine("Player X wins!");
                wins = true;
            }
            else if (board[3] == "X" && board[4] == "X" && board[5] == "X")
            {
                Console.WriteLine("Player X wins!");
                wins = true;
            }
            else if (board[6] == "X" && board[7] == "X" && board[8] == "X")
            {
                Console.WriteLine("Player X wins!");
                wins = true;
            }
            else
            {
                Console.WriteLine("No one has won, keep playing");
                wins = false;            
            }
            return (wins);
        }
    }
}
