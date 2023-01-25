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
            int counter = 0;

            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            string[] gameBoard = { "1", "2", "3", "4", "5", "6", "7", "8", "9" }; //initialize array

            sc.BoardDisplay(gameBoard);

            do
            {
                bool isValid = false;


                while (isValid == false)
                {
                    

                    Console.WriteLine("Player X's turn! Choose a number on the board to place an X");

                    userIn = Console.ReadLine();

                    counter += 1;

                    if (gameBoard[Convert.ToInt32(userIn) - 1] != "X" && gameBoard[Convert.ToInt32(userIn) - 1] != "O") //check if game board spot has an x or an o
                    {
                        int numInArray = Convert.ToInt32(userIn) - 1;
                        gameBoard[numInArray] = "X";
                        isValid = true;

                    }
                    else
                    {
                        Console.WriteLine("Not a valid position, please try again"); // if there i an x or an o, make the player put in a new input
                        isValid = false;
                    }
                }

                sc.BoardDisplay(gameBoard);

                
                if (sc.GameWinner(gameBoard) == true)
                {
                    break;
                }

                isValid = false;


                while ((isValid == false) && (counter < 9)) // if counter reaches 9 and no one has won, end game
                {
                    

                    Console.WriteLine("Player O's turn! Choose a number on the board to place an O");
                    
                    userIn2 = Console.ReadLine();
                    counter += 1;

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

                sc.BoardDisplay(gameBoard);

                Console.WriteLine(counter);



                if (counter == 9)
                {
                    Console.WriteLine("There is no winner. Try again");
                }

            } while ((sc.GameWinner(gameBoard) == false) && (counter != 9)); // determine winner



        }
    }
}
