//-- TicTacToe --

//declare & initialize
char[,] gameBoard = new Char[3,3];
char[] playerSymbol = {'X','O','Ö'};
string[] playerName = new string[4]; //Store Player Names
int numPlayers;
int currentPlayer = 1;
int playerChoiceX = 0;
int playerChoiceY = 0;

SetUp();

//Setup Game
void SetUp()
{
    //reset gameBoard array values
    gameBoard[0, 0] = '1'; gameBoard[1, 0] = '2'; gameBoard[2, 0] = '3';
    gameBoard[0, 1] = '4'; gameBoard[1, 1] = '5'; gameBoard[2, 1] = '6';
    gameBoard[0, 2] = '7'; gameBoard[1, 2] = '8'; gameBoard[2, 2] = '9';
    Console.Clear();
    Console.WriteLine("--X- Welcome to TicTacToe -O--");
    Console.WriteLine("     - by Stewart Wan -");

    //Number of players
    Player2Play:
    Console.WriteLine("Please enter the number of player 1 or 2");
    string userInput = Console.ReadLine();
    if ((userInput != "1") && (userInput != "2"))
    {
        Console.WriteLine("Invalid input.");
        goto Player2Play;
    }
    numPlayers = Convert.ToInt32(userInput);
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
        Console.WriteLine(" ");
        Console.WriteLine("Lets Play !");
        Console.WriteLine(" ");
        DrawBoard();
        LetsPlay();
    }
    else
    {
        Console.WriteLine("Player 1, please enter your name");
        string playerAnswer = Console.ReadLine();
        playerName[0] = playerAnswer;
        Console.WriteLine("Player 2 is your friendly medical robot Baymax");
        Thread.Sleep(3000);
        playerName[1] = "Baymax";
        Console.WriteLine(" ");
        Console.WriteLine("Lets Play !");
        Console.WriteLine(" ");
        DrawBoard();
        LetsPlay();
    }
}

//Lets Play
void LetsPlay()
{
    GameOn:
    {
        if (numPlayers == 2)
        {
            currentPlayer = (currentPlayer + 1) % 2;
            PlayerTurn();
        }
        else
        {
            currentPlayer = (currentPlayer + 1) % 2;
            if (currentPlayer == 0)
            {
                PlayerTurn();
            }
            else
            {
                BaymaxTurn();
            }
        }

        DrawBoard();
        CheckWin();
        CheckDraw();
        goto GameOn;
    }
}

//Draw board
void DrawBoard()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine();
    Console.WriteLine($" {gameBoard[0,2]} | {gameBoard[1,2]} | {gameBoard[2,2]}");
    Console.WriteLine(" - + - + -");
    Console.WriteLine($" {gameBoard[0,1]} | {gameBoard[1,1]} | {gameBoard[2,1]}");
    Console.WriteLine(" - + - + - ");
    Console.WriteLine($" {gameBoard[0,0]} | {gameBoard[1,0]} | {gameBoard[2,0]}");
    Console.WriteLine();
    Console.ResetColor();
}

//Player Turn
void PlayerTurn()
{
    PlayerInput:
    NumKeyInput();
    if (gameBoard [playerChoiceX,playerChoiceY] == 'X' || gameBoard [playerChoiceX,playerChoiceY] == 'O')
    {
        Console.WriteLine("Cell has been played, please select another cell");
        goto PlayerInput;
    }
    gameBoard[playerChoiceX, playerChoiceY] = playerSymbol[currentPlayer];
}

//check win
void CheckWin()
{
    // check row 0: 0 1 2 
    // check row 1: 3 4 5
    // check row 2: 6 7 8
    /*for (int row = 0; row < 3; row++)
    {
        CheckRow(row);
    }*/

    /*for (int col = 0; col < 3; col++)
    {
        CheckCol(col);
    }*/
    if (gameBoard[0,0] == gameBoard[1,0] && gameBoard[1,0] == gameBoard[2,0]) //row 1-3
    {
        HasWon();
    }

    if (gameBoard[0,1] == gameBoard[1,1] && gameBoard[1,1] == gameBoard[2,1]) //row 4-6
    {
        HasWon();
    }

    if (gameBoard[0,2] == gameBoard[1,2] && gameBoard[1,2] == gameBoard[2,2]) //row 7-9
    {
        HasWon();
    }

    if (gameBoard[0,0] == gameBoard[0,1] && gameBoard[0,1] == gameBoard[0,2]) //column 1-7
    {
        HasWon();
    }

    if (gameBoard[1,0] == gameBoard[1,1] && gameBoard[1,1] == gameBoard[1,2]) //column 2-8
    {
        HasWon();
    }

    if (gameBoard[2,0] == gameBoard[2,1] && gameBoard[2,1] == gameBoard[2,2]) //column 3-9
    {
        HasWon();
    }

    if (gameBoard[0,0] == gameBoard[1,1] && gameBoard[1,1] == gameBoard[2,2]) //Diagonal 0-9
    {
        HasWon();
    }

    if (gameBoard[0,2] == gameBoard[1,1] && gameBoard[1,1] == gameBoard[2,0]) //Diagonal 3-7
    {
        HasWon();
    }
}

//Has won
void HasWon()
{
    Console.WriteLine($"{playerName[currentPlayer]} Wins !");
        PlayAgain();
    
}

//check draw
void CheckDraw()
{
    /*for (int x = 0; x < 3; x++)
    {
        for (int y = 0; y < 3; y++)
        {
            if ((gameBoard[x,y] != 'X') && (gameBoard[x,y] != 'O'))// || (gameBoard[x,y] != 'Ö'))
            {
                break;//HasDrawn();
            }
        }
    }*/
    if (gameBoard[0,0] != '1' && gameBoard[1,0] != '2' && gameBoard[2,0] != '3' && gameBoard[0,1] != '4' && gameBoard[1,1] != '5' && gameBoard[2,1] != '6' && gameBoard[0,2] != '7' && gameBoard[1,2] != '8' && gameBoard[2,2] != '9')
    {
        HasDrawn();
    }
}

//Has drawn
void HasDrawn()
{
    Console.WriteLine("Game is a draw");
    PlayAgain();
}

//Play Again
void PlayAgain()
{
    Back2Game:
    Console.WriteLine("Would you like to play again?");
    Console.WriteLine("[1] for YES : [2] for NO");
    string userInput = Console.ReadLine();
    if ((userInput != "1") && (userInput != "2"))
    {
        Console.WriteLine("Invalid input.");
        goto Back2Game;
    }
    int playAgain = Convert.ToInt32(userInput);
    if (playAgain == 1)
    {
        Console.Clear();
        //gameWinner = false;
        SetUp();
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

//Use humber key for input
void NumKeyInput()
{
    Console.WriteLine($"{playerName[currentPlayer]} press the NumKey where you want to play");
    string playerInput = Console.ReadLine();
    if (playerInput == "1")
    {
        playerChoiceX = 0;
        playerChoiceY = 0;
    }
    if (playerInput == "2")
    {
        playerChoiceX = 1;
        playerChoiceY = 0;
    }
    if (playerInput == "3")
    {
        playerChoiceX = 2;
        playerChoiceY = 0;
    }
    if (playerInput == "4")
    {
        playerChoiceX = 0;
        playerChoiceY = 1;
    }
    if (playerInput == "5")
    {
        playerChoiceX = 1;
        playerChoiceY = 1;
    }
    if (playerInput == "6")
    {
        playerChoiceX = 2;
        playerChoiceY = 1;
    }
    if (playerInput == "7")
    {
        playerChoiceX = 0;
        playerChoiceY = 2;
    }
    if (playerInput == "8")
    {
        playerChoiceX = 1;
        playerChoiceY = 2;
    }
    if (playerInput == "9")
    {
        playerChoiceX = 2;
        playerChoiceY = 2;
    }
}

//Single Player Methods
//Random Gen numbers
void BaymaxTurn()
{
    Random random = new Random();
    PlayerInput:
    playerChoiceX = random.Next(0, 3);
    playerChoiceY = random.Next(0, 3);
    if (gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[0] || gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[2])
    {
        //Console.WriteLine("Cell has been played, please select another cell");
        goto PlayerInput;
    }
    Console.WriteLine("Baymax plays " + gameBoard[playerChoiceX, playerChoiceY]);
    gameBoard[playerChoiceX, playerChoiceY] = playerSymbol[2];
    Thread.Sleep(2000);
}


//Not working
//Smart AI
/*void SkynetTurn()
{
    if (gameBoard[1, 1] == '5')
    {
        playerChoiceX = 1;
        playerChoiceY = 1;
    }
    //else if ((gameBoard[0, 0] != '5') || (gameBoard[0, 0] != 'X'))
    //{
        playerChoiceX = 0;
        playerChoiceY = 0;
    //}
    /*else if ((gameBoard[2, 2] != '5') || (gameBoard[2, 2] != 'X'))
    {
        playerChoiceX = 2;
        playerChoiceY = 2;
    }
    else if ((gameBoard[0, 2] != '5') || (gameBoard[0, 2] != 'X'))
    {
        playerChoiceX = 0;
        playerChoiceY = 2;
    }
    else if ((gameBoard[2, 0] != '5') || (gameBoard[2, 0] != 'X'))
    {
        playerChoiceX = 2;
        playerChoiceY = 0;
    }
    if ((gameBoard[1, 1] != 'X') && (gameBoard[0, 1] != 'X'))
    {
        playerChoiceX = 2;
        playerChoiceY = 1;
    }
    else if ((gameBoard[1, 1] != 'X') || (gameBoard[1, 0] != 'X'))
    {
        playerChoiceX = 1;
        playerChoiceY = 2;
    }
    else if ((gameBoard[1, 1] != 'X') || (gameBoard[2, 1] != 'X'))
    {
        playerChoiceX = 0;
        playerChoiceY = 1;
    }
    else if ((gameBoard[1, 1] != 'X') || (gameBoard[1, 2] != 'X'))
    {
        playerChoiceX = 1;
        playerChoiceY = 0;
    }
    else if ((gameBoard[1, 1] != 'X') || (gameBoard[2, 0] != 'X'))
    {
        playerChoiceX = 0;
        playerChoiceY = 2;
    }
    playerChoiceX = 2;
    playerChoiceY = 0;

Random random = new Random();
PlayerInput:
playerChoiceX = random.Next(0, 3);
playerChoiceY = random.Next(0, 3);
if (gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[0] || gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[2])
{
    //Console.WriteLine("Cell has been played, please select another cell");
    goto PlayerInput;
}
Console.WriteLine("Baymax plays " + gameBoard[playerChoiceX, playerChoiceY]);
gameBoard[playerChoiceX, playerChoiceY] = playerSymbol[2];
Thread.Sleep(2000);
}
//optimal strategy playing 2nd
//(centre) - corner - (!corner) - corner - (block)...
//(corner) - centre - (!corner) - side - (block)...
    //place 3rd in a row to win
    check 2inRow
    if (gameBoard[0,0] == gameBoard[1,0] || gameBoard[1,0] == gameBoard[2,0] || gameBoard[0,0] == gameBoard[2,0])
    {
        for (int x = 0; x < 3; x++)
        {
            playerChoiceX = x;
            playerChoiceY = 0;
            if (gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[0] || gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[2])
            {  
                goto PlayerInput;
            }
            Console.WriteLine("Baymax plays " + gameBoard[playerChoiceX, playerChoiceY]);
            gameBoard[playerChoiceX, playerChoiceY] = playerSymbol[2];
            Thread.Sleep(2000);
        }
    if (gameBoard[1,0] == gameBoard[1,1] || gameBoard[1,1] == gameBoard[1,2] || gameBoard[1,0] == gameBoard[1,2])
    {
        for (int x = 0; x < 3; x++)
        {
            playerChoiceX = x;
            playerChoiceY = 0;
            if (gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[0] || gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[2])
            {  
                goto PlayerInput;
            }
            Console.WriteLine("Baymax plays " + gameBoard[playerChoiceX, playerChoiceY]);
            gameBoard[playerChoiceX, playerChoiceY] = playerSymbol[2];
            Thread.Sleep(2000);
        }
    if (gameBoard[2,0] == gameBoard[2,1] || gameBoard[2,1] == gameBoard[2,2] || gameBoard[2,0] == gameBoard[2,2])
    {
        for (int x = 0; x < 3; x++)
        {
            playerChoiceX = x;
            playerChoiceY = 0;
            if (gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[0] || gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[2])
            {  
                goto PlayerInput;
            }
            Console.WriteLine("Baymax plays " + gameBoard[playerChoiceX, playerChoiceY]);
            gameBoard[playerChoiceX, playerChoiceY] = playerSymbol[2];
            Thread.Sleep(2000);
        }
    if (gameBoard[0,0] == gameBoard[1,0] || gameBoard[1,0] == gameBoard[2,0] || gameBoard[0,0] == gameBoard[2,0])
    {
        for (int y = 0; y < 3; y++)
        {
            playerChoiceX = 0;
            playerChoiceY = y;
            if (gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[0] || gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[2])
            {  
                goto PlayerInput;
            }
            Console.WriteLine("Baymax plays " + gameBoard[playerChoiceX, playerChoiceY]);
            gameBoard[playerChoiceX, playerChoiceY] = playerSymbol[2];
            Thread.Sleep(2000);
        }
    if (gameBoard[0,1] == gameBoard[1,1] || gameBoard[1,1] == gameBoard[2,1] || gameBoard[0,1] == gameBoard[2,1])
    {
        for (int y = 0; y < 3; y++)
        {
            playerChoiceX = 0;
            playerChoiceY = y;
            if (gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[0] || gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[2])
            {  
                goto PlayerInput;
            }
            Console.WriteLine("Baymax plays " + gameBoard[playerChoiceX, playerChoiceY]);
            gameBoard[playerChoiceX, playerChoiceY] = playerSymbol[2];
            Thread.Sleep(2000);
        }
    if (gameBoard[0,2] == gameBoard[1,2] || gameBoard[1,2] == gameBoard[2,2] || gameBoard[0,2] == gameBoard[2,2])
    {
        for (int y = 0; y < 3; y++)
        {
            playerChoiceX = 0;
            playerChoiceY = y;
            if (gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[0] || gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[2])
            {  
                goto PlayerInput;
            }
            Console.WriteLine("Baymax plays " + gameBoard[playerChoiceX, playerChoiceY]);
            gameBoard[playerChoiceX, playerChoiceY] = playerSymbol[2];
            Thread.Sleep(2000);
        }
    if (gameBoard[0,0] == gameBoard[1,1] || gameBoard[1,1] == gameBoard[2,2] || gameBoard[0,0] == gameBoard[2,2]) //Diagonal 0-9
    {
        for (int d = 0; d < 3; d++)
        {
            playerChoiceX = d;
            playerChoiceY = d;
            if (gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[0] || gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[2])
            {  
                goto PlayerInput;
            }
            Console.WriteLine("Baymax plays " + gameBoard[playerChoiceX, playerChoiceY]);
            gameBoard[playerChoiceX, playerChoiceY] = playerSymbol[2];
            Thread.Sleep(2000);
    }

    if (gameBoard[0,2] == gameBoard[1,1] && gameBoard[1,1] == gameBoard[2,0]) //Diagonal 3-7
    {
        for (int d = 0; d < 3; d++)
        {
            playerChoiceX = d;
            playerChoiceY = 2-d;
            if (gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[0] || gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[2])
            {  
                goto PlayerInput;
            }
            Console.WriteLine("Baymax plays " + gameBoard[playerChoiceX, playerChoiceY]);
            gameBoard[playerChoiceX, playerChoiceY] = playerSymbol[2];
            Thread.Sleep(2000);
    }
        
        
        
    Console.WriteLine("Baymax plays " + gameBoard[playerChoiceX, playerChoiceY]);
    gameBoard[playerChoiceX, playerChoiceY] = playerSymbol[2];
    Thread.Sleep(2000);
    {
    //are there 2 opponent in a row - block
    //5 (centre)  or 1 / 3 / 7 / 9 (corner)
    //block 3 in a row
    Random random = new Random();
    PlayerInput:
    playerChoiceX = random.Next(0, 3);
    playerChoiceY = random.Next(0, 3);
    if (gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[0] || gameBoard [playerChoiceX,playerChoiceY] == playerSymbol[2])
    {
        //Console.WriteLine("Cell has been played, please select another cell");
        goto PlayerInput;
    }
    Console.WriteLine("Baymax plays " + gameBoard[playerChoiceX, playerChoiceY]);
    gameBoard[playerChoiceX, playerChoiceY] = playerSymbol[2];
    Thread.Sleep(2000);
}*/

// function to check, whether all 3 cells in one row are 'X'
/*void CheckRow(int row)
{
    // check all three columns of that row
    for (int col = 0; col < 3; col++)
    {
        // if any of the cells is not an 'X', return
        if ((gameBoard[col, row] != 'X') || (gameBoard[col, row] != 'O'))
            return;
    }
    // if we came this far, the whole row is 'X's
    HasWon();
}*/

// function to check, whether all 3 cells in one col are 'X'
/*void CheckCol(int col)
{
    // check all three columns of that row
    for (int row = 0; row < 3; row++)
    {
        // if any of the cells is not an 'X', return
        if ((gameBoard[row, col] != 'X') || (gameBoard[row, col] != 'O'))
            return;
    }
    // if we came this far, the whole row is 'X's
    HasWon();
}*/
