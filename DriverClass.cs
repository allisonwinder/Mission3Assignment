using System;

namespace Mission3Assignment
{
    class DriverClass
    {
        static void Main(string[] args)
        {
            SupportingClass sc = new SupportingClass();

            string userIn = "";
            string userIn2 = "";

            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            string[] gameBoard = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            sc.BoardDisplay(gameBoard);

            //for (int i = 0; i < 5; i++)
            do
            {
                bool isValid = false;


                while (isValid == false)
                {

                    Console.WriteLine("Player 1's turn! Choose a number on the board to place an X");

                    userIn = Console.ReadLine();

                    if (gameBoard[Convert.ToInt32(userIn) - 1] != "X" && gameBoard[Convert.ToInt32(userIn) - 1] != "O")
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

                //foreach (var item in gameBoard)
                //{
                //    Console.WriteLine(item.ToString());
                //}

                sc.BoardDisplay(gameBoard);

                sc.GameWinner(gameBoard);

                isValid = false;


                while (isValid == false)
                {
                    Console.WriteLine("Player 2's turn! Choose a number on the board to place an O");
                    userIn2 = Console.ReadLine();

                    if (gameBoard[Convert.ToInt32(userIn2) - 1] != "X" && gameBoard[Convert.ToInt32(userIn2) - 1] != "O")
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

                //foreach (var item in gameBoard)
                //{
                //    Console.WriteLine(item.ToString());
                //}

                sc.BoardDisplay(gameBoard);


                sc.GameWinner(gameBoard);



            } while (sc.GameWinner(gameBoard) == false);



        }
    }
}
