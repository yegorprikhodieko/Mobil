using System;

const int length = 10;

string[,] chessBoard = new string[length, length];
string[] alphabet = { "", "a", "b", "c", "d", "e", "f", "g", "h", "" };

for (int i = 0; i < length; i++)
{
    for (int j = 0; j < length; j++)
    {
        if ((i == 0 && j == 0) || (i == 9 && j == 9) || (i == 0 && j == 9) || (i == 9 && j == 0))
        {
            chessBoard[i, j] = " ";
            Console.Write($"{chessBoard[i, j],2}");
        }
        else if (i == 0 || i == 9)
        {
            chessBoard[i, j] = alphabet[j];
            Console.Write($"{chessBoard[i, j],2}");
        }
        else if (j == 0 || j == 9)
        {
            chessBoard[i, j] = $"{9 - i}";
            Console.Write($"{chessBoard[i, j],2}");
        }
        else
        {
            chessBoard[i, j] = "■";

            if ((i + j) % 2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"{chessBoard[i, j],2}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{chessBoard[i, j],2}");
                Console.ResetColor();
            }
        }
    }
    Console.WriteLine();
}