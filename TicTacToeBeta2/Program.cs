Console.WriteLine("Tic Tac Toe Beta 2");

//string player1 = null;
//string player2 = null;

int gameStatus = 0;
int currentPlayer = -1;
char[] gameMarkers = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
Random randomNum = new Random();

StartGame();

void StartGame()
{
    //SetupGame(player1, player2);
    //setup AI
    
    do
    {
        Console.Clear();
        currentPlayer = GetNextPlayer(currentPlayer);

        Instructions(currentPlayer);
        DrawGameBoard(gameMarkers);

        GameEngine(gameMarkers, currentPlayer);

        gameStatus = CheckWinner(gameMarkers);
        
    } while (gameStatus.Equals(0)); //check if game continues
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
    Console.WriteLine($"Player {playerNumber} to move, select 1 - 9 on the Gameboard");
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
        Console.WriteLine("Please select which square you want to play (1-9)");
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
static int GetNextPlayer(int player) //select next player
{
    if (player.Equals(1))
    {
        return 2;
    }
    return 1;
}
//void Player2AI
void PlayAgain() //Ask Play Again
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
void EndGame() //End Game
{
    Console.WriteLine("Thanks for Playing");
    Environment.Exit(0);
}

/*static string SetupGame(string player1, string player2)
{
    //Number of players
    Console.WriteLine("Please enter the number of player 1 or 2");
    int numPlayers = Convert.ToInt32(Console.ReadLine());
    numPlayers = (int)Math.Clamp((double)numPlayers, 1, 2);
    if (numPlayers == 2)
    {
        //Players enter name
        Console.WriteLine("Player 1, please enter your name");
        player1 = Console.ReadLine();
        Console.WriteLine("Player 2, please enter your name");
        player2 = Console.ReadLine();
        Console.Clear();
    }
    else
    {
        Console.WriteLine("Player 1, please enter your name");
        player1 = Console.ReadLine();
        Console.WriteLine("Choose your difficulty level:");
        Console.WriteLine("[1] for Easy");
        Console.WriteLine("[2] for Hard");
        int difficulty = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        if (difficulty == 1)
        {
            player2 = "Wall-E";
            Console.WriteLine($"Player 2 is {player2}");
        }
        else
        {
            player2 = "HAL9000";
            Console.WriteLine($"Player 2 is {player2}");
        }
    }

    return player1;
    return player2;
}*/
//setup AI
/*{
    aiTurn = randomNum.Next(8);
    Console.WriteLine("AI chooses " + aiTurn);
}*/
