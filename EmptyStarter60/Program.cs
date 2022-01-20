using System;
using System.Collections.Generic;
namespace Cse210Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int row = 0;
            int col = 0;
            string player = "X";
            List<int> slot = new List<int>();
            string[,] board = new string[3, 3];
            bool gameEnd = false;

            for (row = 0; row < 3; row++)
            {
                for (col = 0; col < 3; col++)
                {

                    board[row, col] = $"{i}";
                    i++;
                }
            }
            while (gameEnd == false)
            {
                Console.Clear();
                DisplayBoard(board);


                //Console.WriteLine("enter row: ");



                Console.Write("Please enter number: ");
                string answer = Console.ReadLine();




                slot = FindSlot(answer);
                board[slot[0], slot[1]] = player;


                DisplayBoard(board);

                if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2] || player == board[1, 0] && player == board[1, 1] && player == board[1, 2] || player == board[2, 0] && player == board[2, 1] && player == board[2, 2] || player == board[0, 0] && player == board[1, 0] && player == board[2, 0] || player == board[0, 1] && player == board[1, 1] && player == board[2, 1] || player == board[0, 2] && player == board[1, 2] && player == board[2, 2] || player == board[2, 2] && player == board[1, 1] && player == board[0, 0] || player == board[0, 2] && player == board[1, 1] && player == board[2, 0])
                {
                    Console.WriteLine(player + " has won the game");
                    gameEnd = true;
                }
                else if (Tie(board))
                {
                    Console.WriteLine("its a tie");
                    gameEnd = true;
                }
                player = ChangeTurn(player);
            }
        }

        static bool Tie(string[,] board)
        {
            bool isTie = false;
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (board[r, c] != "X" && board[r, c] != "O")
                    {
                        isTie = true;
                        break;
                    }

                }
            }


            return !isTie;
        }




        static string ChangeTurn(string currentPlayer)
        {
            if (currentPlayer == "X")
            {
                return "O";
            }
            else
            {
                return "X";
            }

        }
        static List<int> FindSlot(string answer)
        {
            List<int> rowcol = new List<int>();
            if (answer == "1")
            {
                rowcol.Add(0);
                rowcol.Add(0);
            }
            else if (answer == "2")
            {
                rowcol.Add(0);
                rowcol.Add(1);
            }
            else if (answer == "3")
            {
                rowcol.Add(0);
                rowcol.Add(2);
            }
            else if (answer == "4")
            {
                rowcol.Add(1);
                rowcol.Add(0);
            }
            else if (answer == "5")
            {
                rowcol.Add(1);
                rowcol.Add(1);
            }
            else if (answer == "6")
            {
                rowcol.Add(1);
                rowcol.Add(2);
            }
            else if (answer == "7")
            {
                rowcol.Add(2);
                rowcol.Add(0);
            }
            else if (answer == "8")
            {
                rowcol.Add(2);
                rowcol.Add(1);
            }
            else
            {
                rowcol.Add(2);
                rowcol.Add(2);
            }
            return rowcol;



        }
        static void DisplayBoard(string[,] board)
        {
            int counte = 0;
            for (int row = 0; row < 3; row++)
            {
                Console.Write("| ");
                for (int col = 0; col < 3; col++)
                {
                    counte++;
                    Console.Write($"{board[row, col]} |");
                    // Console.Write($"{counte} | ");
                }
                Console.WriteLine();
            }

        }
    }
}

