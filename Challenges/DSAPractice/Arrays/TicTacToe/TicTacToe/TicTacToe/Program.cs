using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tic Tac Toe");
            string[,] game1 = {{"X", "O", "X"},
                               {"O", "X", "O"},
                               {" ", " ", "X"},};

            string[,] game2 = {{"O", "X", " "},
                               {"O", "O", "X"},
                               {"O", "X", "X"},};

            string[,] game3 = {{"X", "O", "X"},
                               {"O", " ", "O"},
                               {" ", " ", "X"},};

            Console.WriteLine("Game 1 - " + TicTacToe(game1)); 
            Console.WriteLine("Game 2 - " + TicTacToe(game2));
            Console.WriteLine("Game 3 - " + TicTacToe(game3));

        }

        //Tic Tac Toe

        //Problem:
        // Build a method that determins if a Tic tac toe board has been won or if it's a tie

        //input: 2d array, filled with either the char x, zero, " "
        // [[0, 0], [0, 1], [0, 2]
        //  [1, 0], [1, 1], [1, 2]
        //  [2, 0], [2, 1], [2, 2]]

        // [[x], [o], [x]
        // [[o], [""], [x]
        // [[""], [o], [x]

        //output: string message: 1) "X won" 2) "0 won" 3) "No one won" 

        public static string TicTacToe(string[,] arr)
        {
            string row1 = arr[0, 0] + arr[0, 1] + arr[0, 2];
            string row2 = arr[1, 0] + arr[1, 1] + arr[1, 2];
            string row3 = arr[2, 0] + arr[2, 1] + arr[2, 2];
            string column1 = arr[0, 0] + arr[1, 0] + arr[2, 0];
            string column2 = arr[0, 1] + arr[1, 1] + arr[2, 1];
            string column3 = arr[0, 2] + arr[1, 2] + arr[2, 2];
            string diagonal1 = arr[0, 0] + arr[1, 1] + arr[2, 2];
            string diagonal2 = arr[0, 2] + arr[1, 1] + arr[2, 0];

            string[] allWinningOptions = { row1, row2, row3, 
                                           column1, column2, column3,
                                           diagonal1, diagonal2 };

            foreach (string item in allWinningOptions)
            {
                if (item == "XXX")
                {
                    return "X won!";

                }
                else if (item == "OOO")
                {
                    return "O won!";
                }
            }

            return "No one won";
        }
    }
}
