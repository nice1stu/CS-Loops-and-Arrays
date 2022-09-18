﻿Console.WriteLine("Tic Tac Toe Beta 2");
StartGame();
void StartGame()
{
    int gameStatus = 0;
    int currentPlayer = -1;
    char[] gameMarkers = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    
    //setup game
    //setup AI
    
    do
    {
        Console.Clear();
        currentPlayer = GetNextPlayer(currentPlayer);

        Instructions(currentPlayer);
        DrawGameBoard(gameMarkers);

        GameEngine(gameMarkers, currentPlayer);

        gameStatus = CheckWinner(gameMarkers);
        
    } while (gameStatus.Equals(0));
    Console.Clear();
    Instructions(currentPlayer);
    DrawGameBoard(gameMarkers);
    if (gameStatus.Equals(1))
    {
        Console.WriteLine($"Player {currentPlayer} is the winner!");
        PlayAgain();
    }

    if (gameStatus.Equals(2))
    {
        Console.WriteLine("The game is a draw");
        PlayAgain();
    }
}
//void Setup
static void Instructions(int playerNumber)
{
    Console.WriteLine("--Welcome to Tic Tac Toe--");
    Console.WriteLine("Player 1 : X");
    Console.WriteLine("Player 2 : O");
    Console.WriteLine();
    Console.WriteLine($"Player {playerNumber} to move, select 1 - 9 on the gameboard");
    Console.WriteLine();
}
static int CheckWinner(char[] gameMarkers)
{
    if (IsGameDraw(gameMarkers))
    {
        return 2;
    }
    if (IsGameWinner(gameMarkers))
    {
        return 1;
    }
    return 0;
}
static bool IsGameDraw(char[] gameMarkers)
{
    return gameMarkers[0] != '1' &&
           gameMarkers[1] != '2' &&
           gameMarkers[2] != '3' &&
           gameMarkers[3] != '4' &&
           gameMarkers[4] != '5' &&
           gameMarkers[5] != '6' &&
           gameMarkers[6] != '7' &&
           gameMarkers[7] != '8' &&
           gameMarkers[8] != '9';
}
static bool IsGameWinner(char[] gameMarkers)
{
    if (IsGameMarkersTheSame(gameMarkers, 0, 1, 2))
    {
        return true;
    }
    if (IsGameMarkersTheSame(gameMarkers, 3, 4, 5))
    {
        return true;
    }
    if (IsGameMarkersTheSame(gameMarkers, 6, 7, 8))
    {
        return true;
    }
    if (IsGameMarkersTheSame(gameMarkers, 0, 3, 6))
    {
        return true;
    }
    if (IsGameMarkersTheSame(gameMarkers, 1, 4, 7))
    {
        return true;
    }
    if (IsGameMarkersTheSame(gameMarkers, 2, 5, 8))
    {
        return true;
    }
    if (IsGameMarkersTheSame(gameMarkers, 0, 4, 8))
    {
        return true;
    }
    if (IsGameMarkersTheSame(gameMarkers, 2, 4, 6))
    {
        return true;
    }

    return false;
}
static bool IsGameMarkersTheSame(char[] testGameMarkers, int pos1, int pos2, int pos3)
{
    return testGameMarkers[pos1].Equals(testGameMarkers[pos2]) && testGameMarkers[pos2].Equals(testGameMarkers[pos3]);
}
void GameEngine(char[] gameMarkers, int currentPlayer)
{
    bool notValidMove = true;
    
    do
    {
        //3.  as user places markers on game update the board and notify which player turn
        string userInput = Console.ReadLine();

        if (!string.IsNullOrEmpty(userInput) && 
            (userInput.Equals("1") || 
             userInput.Equals("2") || 
             userInput.Equals("3") || 
             userInput.Equals("4") || 
             userInput.Equals("5") || 
             userInput.Equals("6") || 
             userInput.Equals("7") || 
             userInput.Equals("8") || 
             userInput.Equals("9")))
        {
            int.TryParse(userInput, out var gamePlacementMarker);

            char currentMarker = gameMarkers[gamePlacementMarker - 1];

            if (currentMarker.Equals('X') || currentMarker.Equals('O'))
            {
                Console.WriteLine("Cell already been played, please select another Cell");
            }
            else
            {
                gameMarkers[gamePlacementMarker - 1] = GetPlayerMarker(currentPlayer);

                notValidMove = false;
            }
        }
        else
        {
            Console.WriteLine("Please select number");
        }
    } while (notValidMove);

}
static char GetPlayerMarker(int player)
{
    if (player % 2 == 0)
    {
        return 'O';
    }

    return 'X';
}
static void DrawGameBoard(char[] gameMarkers)
{
    Console.WriteLine($" {gameMarkers[6]} | {gameMarkers[7]} | {gameMarkers[8]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {gameMarkers[3]} | {gameMarkers[4]} | {gameMarkers[5]} ");
    Console.WriteLine("---+---+---");
    Console.WriteLine($" {gameMarkers[0]} | {gameMarkers[1]} | {gameMarkers[2]} ");
}
static int GetNextPlayer(int player)
{
    if (player.Equals(1))
    {
        return 2;
    }
    return 1;
}
//void Player2AI
//Ask Play Again
void PlayAgain()
{
    Console.WriteLine("Would you like to play again?");
    Console.WriteLine("[1] for YES : [2] for NO");
    int playAgain = Convert.ToInt32(Console.ReadLine());
    if (playAgain == 1)
    {
        Console.Clear();
        StartGame();
    }
    else
    {
        Console.Clear();
        EndGame();
    }
}

//End Game
void EndGame()
{
    Console.WriteLine("Thanks for Playing");
    Environment.Exit(0);
}
