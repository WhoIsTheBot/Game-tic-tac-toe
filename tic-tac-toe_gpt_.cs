using System;

class Game
{
    static void DisplayBoard(char[] board)
    {
        Console.WriteLine($"\n {board[0]} | {board[1]} | {board[2]}\n - + - + -\n {board[3]} | {board[4]} | {board[5]}\n - + - + -\n {board[6]} | {board[7]} | {board[8]}");
    }

    static bool MakeMove(char[] board, char player)
    {
        DisplayBoard(board);
        Console.WriteLine($"\nEnter location for {player}: ");

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int location) && location >= 1 && location <= 9)
            {
                location -= 1; // Adjust for 0-based index
                if (board[location] != 'x' && board[location] != 'o')
                {
                    board[location] = player;
                    return true;
                }
                else
                {
                    Console.WriteLine("Error! Location already taken. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Error! Invalid input. Enter a number between 1 and 9.");
            }
        }
    }

    static bool CheckWinner(char[] board)
    {
        int[,] winningPositions = new int[,]
        {
            { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, // Rows
            { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, // Columns
            { 0, 4, 8 }, { 2, 4, 6 }              // Diagonals
        };

        for (int i = 0; i < winningPositions.GetLength(0); i++)
        {
            if (board[winningPositions[i, 0]] == board[winningPositions[i, 1]] &&
                board[winningPositions[i, 1]] == board[winningPositions[i, 2]])
            {
                Console.WriteLine($"Winner {board[winningPositions[i, 0]]}!");
                return true;
            }
        }

        return false;
    }

    static void Main()
    {
        char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        Console.WriteLine("Tic-Tac-Toe");

        while (true)
        {
            if (MakeMove(board, 'x') && CheckWinner(board)) break;
            if (MakeMove(board, 'o') && CheckWinner(board)) break;
        }
    }
}
