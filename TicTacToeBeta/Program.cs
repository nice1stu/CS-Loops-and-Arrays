using System;

class TicTacToeGame
{
    char[,] gameBoard = new char[3, 3];
    char[] playerSymbol = { 'X', 'O', 'Ö' };
    string[] playerName = new string[2];
    int currentPlayer = 1;
    int playerChoiceX = 0;
    int playerChoiceY = 0;

    // Set up the game
    void SetUp()
    {
        gameBoard = new char[3, 3] {
            { '1', '2', '3' },
            { '4', '5', '6' },
            { '7', '8', '9' }
        };
        Console.Clear();
        Console.WriteLine("--X- Welcome to TicTacToe -O--");
        Console.WriteLine("     - by Stewart Wan -");
        Console.WriteLine("Please enter the number of players (1 or 2):");
        int numPlayers;
        while (!int.TryParse(Console.ReadLine(), out numPlayers) || numPlayers < 1 || numPlayers > 2)
        {
            Console.WriteLine("Invalid input. Please enter 1 or 2.");
        }
        if (numPlayers == 1)
        {
            Console.WriteLine("Enter your name:");
            playerName[0] = Console.ReadLine();
            playerName[1] = "Baymax";
        }
        else
        {
            Console.WriteLine("Enter player 1's name:");
            playerName[0] = Console.ReadLine();
            Console.WriteLine("Enter player 2's name:");
            playerName[1] = Console.ReadLine();
        }
        Console.WriteLine(" ");
        Console.WriteLine("Let's Play!");
        Console.WriteLine(" ");
        DrawBoard();
        LetsPlay();
    }

    // Draw the game board
    void DrawBoard()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine($" {gameBoard[0, 2]} | {gameBoard[1, 2]} | {gameBoard[2, 2]}");
        Console.WriteLine(" - + - + -");
        Console.WriteLine($" {gameBoard[0, 1]} | {gameBoard[1, 1]} | {gameBoard[2, 1]}");
        Console.WriteLine(" - + - + - ");
        Console.WriteLine($" {gameBoard[0, 0]} | {gameBoard[1, 0]} | {gameBoard[2, 0]}");
        Console.WriteLine();
        Console.ResetColor();
    }

    // Get the player's input
    bool GetPlayerInput()
    {
        Console.WriteLine($"{playerName[currentPlayer - 1]}, enter a number (1-9):");
        if (!int.TryParse(Console.ReadLine(), out int input) || input < 1 || input > 9)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
            return false;
        }
        playerChoiceX = (input - 1) / 3;
        playerChoiceY = (input - 1) % 3;
        if (gameBoard[playerChoiceX, playerChoiceY] != input.ToString()[0])
        {
            Console.WriteLine("That cell is already taken. Please choose another.");
            return false;
        }
        return true;
    }

    // Make a move on the game board
    void MakeMove()
    {
        gameBoard[playerChoiceX, playerChoiceY] = playerSymbol[currentPlayer - 1];
    }

    // Check if the game is over
    bool CheckGameOver()
    {
        if (CheckWin())
        {
            Console.WriteLine($"{playerName[currentPlayer - 1]} wins!");
            return true;
        }
        else if (CheckDraw())
        {
            Console.WriteLine("Draw!");
            return true;
        }
        return false;
    }
