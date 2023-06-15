using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] board = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
            string[,] boardRest = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };
           
            bool player1;
            bool winner;
            bool vaild;

            do
            {
                Console.WriteLine("Welcome to TickTacToe");
                gameFuctions.printTable(board);
                bool player1turn = true;
                int turns = 0;

                while (true)
                {
                    if (player1turn == true)
                    {
                        player1 = true;
                        Console.Write("Player 1 Enter a number:");
                        string num = Console.ReadLine();
                        vaild = gameFuctions.IsUsed(board, num);
                        if (vaild == true)
                        {
                            gameFuctions.updateTable(board, num, player1);
                            player1turn = false;
                            turns++;
                        }
                        else
                        {
                            Console.WriteLine("Plese enter a vaild number!");
                        }
                    }
                    else
                    {
                        player1 = false;
                        Console.Write("Player 2 Enter a number:");
                        string num = Console.ReadLine();
                        vaild = gameFuctions.IsUsed(board, num);
                        if (vaild == true)
                        {
                            gameFuctions.updateTable(board, num, player1);
                            player1turn = true;
                            turns++;
                        }
                        else
                        {
                            Console.WriteLine("enter a vaild number!");
                        }
                    }

                    winner = gameFuctions.Checker(board);

                    if (winner == true)
                    {
                        if (player1 == true)
                        {
                            Console.WriteLine("Player 1 wins");
                        }
                        else
                        {
                            Console.WriteLine("Player 2 wins");
                        }
                        board = gameFuctions.refill(board);
                        break;
                    }
                    else
                    {
                        gameFuctions.printTable(board);

                    }

                    if (turns == 9 && winner == false)
                    {
                        Console.WriteLine("Draw Game Over");
                        board = gameFuctions.refill(board);
                        break;

                    }
                }

            } while (true);
        }
    }
}