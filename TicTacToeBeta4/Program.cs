//TicTacToe Beta4
//Start again with 2D arrays

//declare & initialize
char[,] gameBoard = new Char[3,3];
char[] playerSymbol = {'X','O'}; //Player Symbols to use. PLayer 1 [0] = X, Player 2 & AI [1,2,3] = O
bool invalidMove = false;
int gameMarker = 0;
string[] playerName = new string[4]; //Store Player Names
int numPlayers;
bool gameWinner = false;



SetUp();

//Setup Game
void SetUp()
{
    gameBoard[0, 0] = '1'; gameBoard[1, 0] = '2'; gameBoard[2, 0] = '3';
    gameBoard[0, 1] = '4'; gameBoard[1, 1] = '5'; gameBoard[2, 1] = '6';
    gameBoard[0, 2] = '7'; gameBoard[1, 2] = '8'; gameBoard[2, 2] = '9';
    Console.Clear();
    Console.WriteLine("-- Welcome to Tic Tac Toe --");

    //Number of players
    Console.WriteLine("Please enter the number of player 1 or 2");
    numPlayers = Convert.ToInt32(Console.ReadLine());
    numPlayers = (int)Math.Clamp((double)numPlayers, 1, 2);
    if (numPlayers == 2)
    {
        //Players enter name
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Player {i + 1}, please enter your name");
            string playerAnswer = Console.ReadLine();
            playerName[i] = playerAnswer;
        }

/*
    }
    else
    {
        Console.WriteLine("Player 1, please enter your name");
        string playerAnswer = Console.ReadLine();
        playerName[0] = playerAnswer;
        Console.WriteLine("Player 2 is WALL-E");
        playerName[2] = "WALL-E";
    }
*/
        Console.WriteLine(" ");
        Console.WriteLine("Lets Play !");
        Console.WriteLine(" ");
        DrawBoard();
    }
}


//game mechanic !
while (true) // invalid move if square occupied
{
    PlayerTurn1();
    DrawBoard();
    CheckWin();
    PlayerTurn2();
    DrawBoard();
    CheckWin();
}

//Drawboard
void DrawBoard()
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine($"[2] {gameBoard[0,2]} | {gameBoard[1,2]} | {gameBoard[2,2]}");
    Console.WriteLine("    - + - + -");
    Console.WriteLine($"[1] {gameBoard[0,1]} | {gameBoard[1,1]} | {gameBoard[2,1]}");
    Console.WriteLine("    - + - + - ");
    Console.WriteLine($"[0] {gameBoard[0,0]} | {gameBoard[1,0]} | {gameBoard[2,0]}");
    Console.WriteLine("   [0] [1] [2]");
}

void PlayerTurn1()//make into 1 method
{
    PlayerInput:
    Console.Write($"{playerName[0]} ");
    Console.WriteLine("enter where you want to play along X axis");
    int playerChoiceX = Convert.ToInt32(Console.ReadLine());
    if (playerChoiceX !=0 && playerChoiceX !=1 && playerChoiceX !=2)
    {
        Console.WriteLine("invalid input");
        goto PlayerInput;
    }
    Console.WriteLine("enter where you want to play along Y axis");
    int playerChoiceY = Convert.ToInt32(Console.ReadLine());
    if (playerChoiceY !=0 && playerChoiceY !=1 && playerChoiceY !=2)
    {
        Console.WriteLine("invalid input");
        goto PlayerInput;
    }

    if (gameBoard [playerChoiceX,playerChoiceY] == 'X' || gameBoard [playerChoiceX,playerChoiceY] == 'O')
    {
        Console.WriteLine("Cell has been played, please select another cell");
        goto PlayerInput;
    }
    else
    {
        gameBoard[playerChoiceX, playerChoiceY] = playerSymbol[0];
    }
}

void PlayerTurn2()//make into 1 method
{
    PlayerInput:
    Console.Write($"{playerName[1]} ");
    Console.WriteLine("enter where you want to play along X axis");
    int playerChoiceX = Convert.ToInt32(Console.ReadLine());
    if (playerChoiceX !=0 && playerChoiceX !=1 && playerChoiceX !=2)
    {
        Console.WriteLine("invalid input");
        goto PlayerInput;
    }
    Console.WriteLine("enter where you want to play along Y axis");
    int playerChoiceY = Convert.ToInt32(Console.ReadLine());
    if (playerChoiceY !=0 && playerChoiceY !=1 && playerChoiceY !=2)
    {
        Console.WriteLine("invalid input");
        goto PlayerInput;
    }
    if (gameBoard [playerChoiceX,playerChoiceY] == 'X' || gameBoard [playerChoiceX,playerChoiceY] == 'O')
    {
        Console.WriteLine("Cell has been played, please select another cell");
        goto PlayerInput;
    }
    {
        gameBoard[playerChoiceX, playerChoiceY] = playerSymbol[1];
    }
}

//check win
void CheckWin()
{
    Console.WriteLine("Check Win");
    if (gameBoard[0,0] == gameBoard[1,0] && gameBoard[1,0] == gameBoard[2,0]) //row 0-2
    {
        gameWinner = true;
        HasWon();
    }

    if (gameBoard[0,1] == gameBoard[1,1] && gameBoard[1,1] == gameBoard[2,1]) //row 3-5
    {
        gameWinner = true;
        HasWon();
    }

    if (gameBoard[0,2] == gameBoard[1,2] && gameBoard[1,2] == gameBoard[2,2]) //row 6-8
    {
        gameWinner = true;
        HasWon();
    }

    if (gameBoard[0,0] == gameBoard[0,1] && gameBoard[0,1] == gameBoard[0,2]) //column 0-6
    {
        gameWinner = true;
        HasWon();
    }

    if (gameBoard[1,0] == gameBoard[1,1] && gameBoard[1,1] == gameBoard[1,2]) //column 1-7
    {
        gameWinner = true;
        HasWon();
    }

    if (gameBoard[2,0] == gameBoard[2,1] && gameBoard[2,1] == gameBoard[2,2]) //column 2-8
    {
        gameWinner = true;
        HasWon();
    }

    if (gameBoard[0,0] == gameBoard[1,1] && gameBoard[1,1] == gameBoard[2,2]) //Diagonal 0-8
    {
        gameWinner = true;
        HasWon();
    }

    if (gameBoard[0,2] == gameBoard[1,1] && gameBoard[1,1] == gameBoard[2,0]) //Diagonal 2-6
    {
        gameWinner = true;
        HasWon();
    }
}

//Has won
void HasWon()
{
    if (gameWinner)
    {
        Console.WriteLine("You Won !");
        //PlayAgain();
    }
}