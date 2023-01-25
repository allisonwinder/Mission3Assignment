﻿using System;

namespace Mission3Assignment
{
    class DriverClass
    {
        static void Main(string[] args)
        {
            //SupportingClass sc = new SupportingClass();

            string userIn = "";
            string userIn2 = "";

            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            string[] gameBoard = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            //sc.boardDisplay(gameBoard);

            for (int i = 0; i < 9; i++)
            {
                bool isValid = false;
                Console.WriteLine("Player 1's turn! Choose a number on the board to place an X");

                userIn = Console.ReadLine();

                while (isValid == false)
                {

                    if (gameBoard[Convert.ToInt32(userIn) - 1] != "X" || gameBoard[Convert.ToInt32(userIn) - 1] != "O")
                    {
                        int numInArray = Convert.ToInt32(userIn) - 1;
                        gameBoard[numInArray] = "X";
                        isValid = true;

                    }
                    else
                    {
                        Console.WriteLine("Not a valid position, please try again");
                        isValid = false;
                    }
                }

                foreach (var item in gameBoard)
                {
                    Console.WriteLine(item.ToString());
                }

                isValid = false;
                Console.WriteLine("Player 2's turn! Choose a number on the board to place an O");
                userIn2 = Console.ReadLine();

                while (isValid == false)
                {

                    if (gameBoard[Convert.ToInt32(userIn2) - 1] != "X" || gameBoard[Convert.ToInt32(userIn2) - 1] != "O")
                    {
                        int numInArray2 = Convert.ToInt32(userIn2) - 1;
                        gameBoard[numInArray2] = "O";
                        isValid = true;

                    }
                    else
                    {
                        Console.WriteLine("Not a valid position, please try again");
                        isValid = false;
                    }
                }

                foreach (var item in gameBoard)
                {
                    Console.WriteLine(item.ToString());
                }




                //| 1 | 2 | 3 |
                //| X | x | X |
                //| 7 | 8 | 9 |


                //method to see if there is a winner

            }



        }
    }
}
