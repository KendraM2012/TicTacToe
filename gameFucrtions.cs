using System;

namespace TicTacToe
{
    public class gameFuctions
    {
        public static bool Checker(string[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    return true;
                }

            }
            for (int i = 0; i < board.GetLength(1); i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    return true;
                }
            }

            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return true;
            }
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return true;
            }

            return false;
        }

       public  static void updateTable(string[,] board, string num,bool player1)
        {
            for(int i = 0;i < board.GetLength(0);i++)
            {
                for (int j = 0;j < board.GetLength(1); j++)
                {
                    if (board[i,j] == num)
                    {
                        if(player1 == true)
                        {
                            board[i, j] = "X";
                        }
                        else
                        {
                            board[i, j] = "O";
                        }
                    }
                }
            }
        }
       public static void printTable(string[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static bool IsUsed(string[,] board, string num)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == num)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        public static string [,] refill(string[,] board)
        {
            int a = 0;

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    a += 1;
                    board[i, j] = a.ToString();
                    
                }
            }
            return board;
        }
    }
}
