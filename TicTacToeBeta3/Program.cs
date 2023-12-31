﻿// Tic Tac Toe



// Setup variables & Arrays
//--Variables--
int numPlayers;
bool validMove = true;
bool gameWinner = false;
bool gameDraw = false;

//--Arrays--
string[] playerName = new string[4]; //Store Player Names
string[] playerSymbol = { "X", "O" }; //Player Symbols to use. PLayer 1 [0] = X, Player 2 & AI [1,2,3] = O
string[] cellSymbol = { "1", "2", "3", "4", "5", "6", "7", "8", "9"}; //Numbers represent squares to input. Represent numPad}
//locations (2,0),(2,1),(2,2) | (1,0),(1,1),(1,2) | (0,0),(0,1),(0,2)
int[,] cellValue = { { 5, 5, 5 }, { 5, 5, 5 }, { 5, 5, 5 } }; //Value of each cell




SetUp();
DrawBoard();
PlayerMove();


//Setup Game
void SetUp()
{
    Console.Clear();
    Console.WriteLine("-- Welcome to Tic Tac Toe --");
/*
    //Number of players
    Console.WriteLine("Please enter the number of player 1 or 2");
    numPlayers = Convert.ToInt32(Console.ReadLine());
    numPlayers = (int)Math.Clamp((double)numPlayers, 1, 2);
    if (numPlayers == 2)
    {*/
        //Players enter name
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"Player {i+1}, please enter your name");
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
}

//Drawboard
void DrawBoard()
{
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"{cellSymbol[6]} | {cellSymbol[7]} | {cellSymbol[8]}");
    }
    
    
    
    
    
    
    
    
    /*Console.Clear();
    Console.WriteLine();
    Console.WriteLine($"{cellSymbol[6]} | {cellSymbol[7]} | {cellSymbol[8]}");
    Console.WriteLine("- + - + - ");
    Console.WriteLine($"{cellSymbol[3]} | {cellSymbol[4]} | {cellSymbol[5]}");
    Console.WriteLine("- + - + - ");
    Console.WriteLine($"{cellSymbol[0]} | {cellSymbol[1]} | {cellSymbol[2]}");
    Console.WriteLine();*/
}









//Player moves
void PlayerMove()
{
    for (int turnCount = 0; turnCount < 9; turnCount++)
    {
        //player1
        int playerTurn = 0;
        PlayerChoice:
        Console.WriteLine($"{playerName[playerTurn]}  choose the Number of the square you want to place your {playerSymbol[playerTurn]}");
        string player1Choice = Console.ReadLine();

        

        for (int i = 0; i < cellSymbol.Length; i++) //write player symbol to cell
        {
            if (player1Choice == cellSymbol[i])
            {
                while (validMove)
                {
                    for (int j = 0; j < cellSymbol.Length; j++)
                    {
                        if (playerSymbol [0] == cellSymbol [j])
                        {
                            validMove = false;
                            Console.WriteLine("Move invalid, please select another position");
                            goto PlayerChoice;
                        }
                    }


                }
                    //CheckValidMove
                //CheckValidMove();
                cellSymbol[i] = playerSymbol[playerTurn];//cellsymbol replaced with playerSymbol
                CheckWin();
                CheckDraw();
                Console.WriteLine(player1Choice + cellSymbol[i]);
            }
        }


        
        DrawBoard();
        
        //player2
        playerTurn = 1;
        Console.WriteLine($"{playerName[playerTurn]}  choose the Number of the square you want to place your {playerSymbol[playerTurn]}");
        string player2Choice = Console.ReadLine();

        for (int i = 0; i < cellSymbol.Length; i++) //write player symbol to cell
        {
            if (player2Choice == cellSymbol[i])
            {
                CheckValidMove();
                cellSymbol[i] = playerSymbol[playerTurn];
                CheckWin();
                CheckDraw();
                Console.WriteLine(player2Choice + cellSymbol[i]);
            }
        }

        DrawBoard();

    }
}

PlayAgain();
//check valid move
void CheckValidMove()
{
    Console.WriteLine("Check Valid Move");
    /*if (cellSymbol[i] == "X" || cellSymbol[i] == "O")
    {
        Console.WriteLine("Invalid move, cell already played. Please choose again");
    }*/
}

//check win
void CheckWin()
{
    Console.WriteLine("Check Win");
    if (cellSymbol[0] == cellSymbol[1] && cellSymbol[1] == cellSymbol[2]) //row 0-2
    {
        gameWinner = true;
        HasWon();
    }

    if (cellSymbol[3] == cellSymbol[4] && cellSymbol[4] == cellSymbol[5]) //row 3-5
    {
        gameWinner = true;
        HasWon();
    }

    if (cellSymbol[6] == cellSymbol[7] && cellSymbol[7] == cellSymbol[8]) //row 6-8
    {
        gameWinner = true;
        HasWon();
    }

    if (cellSymbol[0] == cellSymbol[3] && cellSymbol[3] == cellSymbol[6]) //column 0-6
    {
        gameWinner = true;
        HasWon();
    }

    if (cellSymbol[1] == cellSymbol[4] && cellSymbol[4] == cellSymbol[7]) //column 1-7
    {
        gameWinner = true;
        HasWon();
    }

    if (cellSymbol[2] == cellSymbol[5] && cellSymbol[5] == cellSymbol[8]) //column 2-8
    {
        gameWinner = true;
        HasWon();
    }

    if (cellSymbol[0] == cellSymbol[4] && cellSymbol[4] == cellSymbol[8]) //Diagonal 0-8
    {
        gameWinner = true;
        HasWon();
    }

    if (cellSymbol[2] == cellSymbol[4] && cellSymbol[4] == cellSymbol[6]) //Diagonal 2-6
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
        PlayAgain();
    }
}

//check draw
void CheckDraw()
{
    if (cellSymbol[0] != "1" && cellSymbol[1] != "2" && cellSymbol[2] != "3" && cellSymbol[3] != "4" && cellSymbol[4] != "5" && cellSymbol[5] != "6" && cellSymbol[6] != "7" && cellSymbol[7] != "8" && cellSymbol[8] != "9")
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