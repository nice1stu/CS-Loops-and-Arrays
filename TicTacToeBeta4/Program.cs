﻿//TicTacToe

//declare & initialize
char[,] gameBoard = new Char[3,3];
char[] playerSymbol = {'X','O'}; //Player Symbols to use. PLayer 1 [0] = X, Player 2 & AI [1,2,3] = O
bool invalidMove = false;
int gameMarker = 0;
string[] playerName = new string[4]; //Store Player Names
int numPlayers;
bool gameWinner = false;
bool gameDraw = false;
int currentPlayer = 1;
int playerChoiceX = 0;
int playerChoiceY = 0;
string playerInput;

SetUp();

//Lets Play (2Player)! - for now create separate for 1 player ? AI
while (true) // invalid move if square occupied
{
    currentPlayer = (currentPlayer + 1) % 2;
    PlayerTurn();
    DrawBoard();
    CheckWin();
    CheckDraw();
}

//Setup Game
void SetUp()
{
    gameBoard[0, 0] = '1'; gameBoard[1, 0] = '2'; gameBoard[2, 0] = '3';
    gameBoard[0, 1] = '4'; gameBoard[1, 1] = '5'; gameBoard[2, 1] = '6';
    gameBoard[0, 2] = '7'; gameBoard[1, 2] = '8'; gameBoard[2, 2] = '9';
    Console.Clear();
    Console.WriteLine("--X- Welcome to TicTacToe -O--");
    Console.WriteLine("     - by Stewart Wan -");

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

//Draw board
void DrawBoard()
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine($" {gameBoard[0,2]} | {gameBoard[1,2]} | {gameBoard[2,2]}");
    Console.WriteLine(" - + - + -");
    Console.WriteLine($" {gameBoard[0,1]} | {gameBoard[1,1]} | {gameBoard[2,1]}");
    Console.WriteLine(" - + - + - ");
    Console.WriteLine($" {gameBoard[0,0]} | {gameBoard[1,0]} | {gameBoard[2,0]}");
    Console.WriteLine();
}

//Player Turn
void PlayerTurn()
{
    PlayerInput:
    Console.Write($"{playerName[currentPlayer]} press the Num key you want to play");
    NumKeyInput();

    if (gameBoard [playerChoiceX,playerChoiceY] == 'X' || gameBoard [playerChoiceX,playerChoiceY] == 'O')
    {
        Console.WriteLine("Cell has been played, please select another cell");
        goto PlayerInput;
    }
    else
    {
        gameBoard[playerChoiceX, playerChoiceY] = playerSymbol[currentPlayer];
    }
}

//check win
void CheckWin()
{
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
        Console.WriteLine($"{playerName[currentPlayer]} Wins !");
        PlayAgain();
    }
}

//check draw
void CheckDraw()
{
    if (gameBoard[0,0] != '1' && gameBoard[1,0] != '2' && gameBoard[2,0] != '3' && gameBoard[0,1] != '4' && gameBoard[1,1] != '5' && gameBoard[2,1] != '6' && gameBoard[0,2] != '7' && gameBoard[1,2] != '8' && gameBoard[2,2] != '9')
    {
        gameDraw = true;
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
    Console.WriteLine("Would you like to play again?");
    Console.WriteLine("[1] for YES : [2] for NO");
    int playAgain = Convert.ToInt32(Console.ReadLine());
    if (playAgain == 1)
    {
        Console.Clear();
        gameWinner = false;
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
    Console.WriteLine($"{playerName[currentPlayer]} press the Num where you want to play");
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