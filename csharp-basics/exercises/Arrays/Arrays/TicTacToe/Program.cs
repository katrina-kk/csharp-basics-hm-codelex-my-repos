using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];


        private static void Main(string[] args)
        {
            bool isGameGoing = true;
            while (isGameGoing)
            {
                char xPlayer = 'X';
                char oPlayer = 'O';
                bool playersDecide = true;
                int tie = 0;

                InitBoard();
                DisplayBoard();

                while (playersDecide)
                {

                    Console.Write("Please choose line where you want to put X: ");
                    var userInputXLine = int.Parse(Console.ReadLine());
                    Console.Write("Please choose column where you want to put X: ");
                    var userInputXColumn = int.Parse(Console.ReadLine());
                    board[userInputXLine, userInputXColumn] = xPlayer;
                    DisplayBoard();
                    tie++;

                    if ((board[0, 0] == xPlayer && board[0, 1] == xPlayer && board[0, 2] == xPlayer)
                       || (board[1, 0] == xPlayer && board[1, 1] == xPlayer && board[1, 2] == xPlayer)
                       || (board[2, 0] == xPlayer && board[2, 1] == xPlayer && board[2, 2] == xPlayer)
                       || (board[2, 2] == xPlayer && board[1, 1] == xPlayer && board[0, 0] == xPlayer)
                       || (board[0, 2] == xPlayer && board[1, 1] == xPlayer && board[2, 0] == xPlayer)
                       || (board[0, 0] == xPlayer && board[1, 0] == xPlayer && board[2, 0] == xPlayer)
                       || (board[0, 1] == xPlayer && board[1, 1] == xPlayer && board[2, 1] == xPlayer)
                       || (board[0, 2] == xPlayer && board[1, 2] == xPlayer && board[2, 2] == xPlayer))
                    {
                        Console.WriteLine("X won!");
                        break;
                    }
                    else if (tie == 9)
                    {
                        Console.WriteLine("It's a tie");
                        break;
                    }

                    Console.Write("Please choose line where you want to put O: ");
                    var userInputOLine = int.Parse(Console.ReadLine());
                    Console.Write("Please choose column where you want to put O: ");
                    var userInputOColumn = int.Parse(Console.ReadLine());
                    board[userInputOLine, userInputOColumn] = oPlayer;
                    DisplayBoard();
                    tie++;

                    if ((board[0, 0] == oPlayer && board[0, 1] == oPlayer && board[0, 2] == oPlayer)
                       || (board[1, 0] == oPlayer && board[1, 1] == oPlayer && board[1, 2] == oPlayer)
                       || (board[2, 0] == oPlayer && board[2, 1] == oPlayer && board[2, 2] == oPlayer)
                       || (board[2, 2] == oPlayer && board[1, 1] == oPlayer && board[0, 0] == oPlayer)
                       || (board[0, 2] == oPlayer && board[1, 1] == oPlayer && board[2, 0] == oPlayer)
                       || (board[0, 0] == oPlayer && board[1, 0] == oPlayer && board[2, 0] == oPlayer)
                       || (board[0, 1] == oPlayer && board[1, 1] == oPlayer && board[2, 1] == oPlayer)
                       || (board[0, 2] == oPlayer && board[1, 2] == oPlayer && board[2, 2] == oPlayer))
                    {
                        Console.WriteLine("O won!");
                        break;
                    }
                    else if (tie == 9)
                    {
                        Console.WriteLine("It's a tie");
                        break;
                    }

                }

            }

        }

        private static void InitBoard()
        {
            // fills up the board with blanks
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("     0|1|2");
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }
    }
}
