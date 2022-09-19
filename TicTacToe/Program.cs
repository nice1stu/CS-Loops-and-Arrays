// TicTacToe

int numPlayers;
string player1;
string player2;
bool hasWon = false;
// assign player1 = x, assign player2 = o
//int x = 10;
//int o = 0;
//What value is stored
/*int k1I = 5;
int k2I = 5;
int k3I = 5;
int k4I = 5;
int k5I = 5;
int k6I = 5;
int k7I = 5;
int k8I = 5;
int k9I = 5;*/
int aRowI;
int bRowI;
int cRowI;
int xColumnI;
int yColumnI;
int zColumnI;
int åDiagonalI;
int öDiagonalI;
// What value is shown
/*string num1 = "1";
string num2 = "2";
string num3 = "3";
string num4 = "4";
string num5 = "5";
string num6 = "6";
string num7 = "7";
string num8 = "8";
string num9 = "9";*/
/*string row3 = $"{num7} | {num8} | {num9}";
string row2 = $"{num4} | {num5} | {num6}";
string row1 = $"{num1} | {num2} | {num3}";*/

//replace with Array
//setup initial board value
//locations (2,0),(2,1),(2,2) | (1,0),(1,1),(1,2) | (0,),(0,1),(0,2)
string[,] boardCellMarker = { { "7", "8", "9" }, { "4", "5", "6" }, { "1", "2", "3" } };

//locations (2,0),(2,1),(2,2) | (1,0),(1,1),(1,2) | (0,),(0,1),(0,2)
int[,] boardCellValue = { { 5, 5, 5 }, { 5, 5, 5 }, { 5, 5, 5 } };

//print int array
/*for(int i = 0; i < boardCellValue.GetLength(0); i++)
{
    for (int j = 0; j < boardCellValue.GetLength(1); j++)
    {
        Console.Write(boardCellValue[i, j] + " ");
    }
    Console.WriteLine();
}*/


Start();
Playtime();

void Start()
{
    
    Console.WriteLine("-- Welcome to Tic Tac Toe --");
    
    //Number of players
    Console.WriteLine("Please enter the number of player 1 or 2");
    numPlayers = Convert.ToInt32(Console.ReadLine());
    numPlayers = (int)Math.Clamp((double)numPlayers, 1, 2);
    if (numPlayers == 2)
    {
        //Players enter name
        Console.WriteLine("Player 1, please enter your name");
        player1 = Console.ReadLine();
        Console.WriteLine("Player 2, please enter your name");
        player2 = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Player 1, please enter your name");
        player1 = Console.ReadLine();
        Console.WriteLine("Player 2 is HAL2000");
        player2 = "HAL2000";
    }

    Console.WriteLine(" ");
    Console.WriteLine("Lets Play !");
    Console.WriteLine(" ");
    //PrintBoardArray();
    //DrawBoard();
    //LetsPlay();
}

void PrintBoardArray()
{
//procedural generated board (string array)
    /*for (int i = 0; i < boardCellLocation.GetLength(0); i++)
    {
        for (int j = 0; j < boardCellLocation.GetLength(1); j++)
        {
            Console.Write("|" + boardCellLocation[i, j] + "|");
        }
        Console.WriteLine();
        for (int j = 0; j < boardCellLocation.GetLength(1); j++)
        {
            Console.Write("---");
        }
        Console.WriteLine();
    }*/
    
    Console.WriteLine($"{boardCellMarker[2,0]} | {boardCellMarker[2,1]} | {boardCellMarker[2,2]}");
    Console.WriteLine("- + - + - ");
    Console.WriteLine($"{boardCellMarker[1,0]} | {boardCellMarker[1,1]} | {boardCellMarker[1,2]}");
    Console.WriteLine("- + - + - ");
    Console.WriteLine($"{boardCellMarker[0,0]} | {boardCellMarker[0,1]} | {boardCellMarker[0,2]}");
}

void Playtime()
{
    while (hasWon == false)
    {
        Player1Turn();
        //Update();
        //WinCheck();
        Player2Turn();
        //Update();
        //WinCheck();
    } 
}

void Player1Turn() // player1 choose
{
    PrintBoardArray();
    Console.Write(player1);
    Console.WriteLine(" choose the Number of the square you want to place your x");
    string choicePlayer1 = Console.ReadLine();
}

void Player2Turn() // player2 choose
{
    PrintBoardArray();
    Console.Write(player2);
    Console.WriteLine(" choose the Number of the square you want to place your x");
    string choicePlayer1 = Console.ReadLine();
}



/*void DrawBoard()
{
    Console.Clear();
    //string row3 = $"{num7} | {num8} | {num9}";
    //string row2 = $"{num4} | {num5} | {num6}";
    //string row1 = $"{num1} | {num2} | {num3}";

    Console.WriteLine(row3);
    Console.WriteLine("- | - | - ");
    Console.WriteLine(row2);
    Console.WriteLine("- | - | - ");
    Console.WriteLine(row1);
}

void LetsPlay()
{
    while (hasWon == false)
    {
        Player1Turn();
        Update();
        WinCheck();
        Player2Turn();
        Update();
        WinCheck();
    }
}

void Player1Turn() // player1 choose
{
    DrawBoard();
    Console.Write(player1);
    Console.WriteLine(" choose the Number of the square you want to place your x");
    string choicePlayer1 = Console.ReadLine();

    if (choicePlayer1 == "1")
    {
        if ((num1 == "x") || (num1 == "o"))
        {
            Console.WriteLine("Cell already occupied, please choose another");
            Player1Turn();
        }
        else
            num1 = "x";
        k1I = 10;
    }
    else if (choicePlayer1 == "2")
    {        
        if ((num2 == "x") || (num2 == "o"))
        {
            Console.WriteLine("Cell already occupied, please choose another");
            Player1Turn();
        }
        else
            num2 = "x";
        k2I = 10;

    }
    else if (choicePlayer1 == "3")
    {
        if ((num3 == "x") || (num3 == "o"))
        {
            Console.WriteLine("Cell already occupied, please choose another");
            Player1Turn();
        }
        else
            num3 = "x";
        k3I = 10;
    }
    else if (choicePlayer1 == "4")
    {
        if ((num4 == "x") || (num4 == "o"))
        {
            Console.WriteLine("Cell already occupied, please choose another");
            Player1Turn();
        }
        else
            num2 = "x";
        k4I = 10;
    }
    else if (choicePlayer1 == "5")
    {
        if ((num5 == "x") || (num5 == "o"))
        {
            Console.WriteLine("Cell already occupied, please choose another");
            Player1Turn();
        }
        else
            num5 = "x";
        k5I = 10;
    }
    else if (choicePlayer1 == "6")
    {
        if ((num6 == "x") || (num6 == "o"))
        {
            Console.WriteLine("Cell already occupied, please choose another");
            Player1Turn();
        }
        else
            num6 = "x";
        k6I = 10;
    }
    else if (choicePlayer1 == "7")
    {
        if ((num7 == "x") || (num7 == "o"))
        {
            Console.WriteLine("Cell already occupied, please choose another");
            Player1Turn();
        }
        else
            num7 = "x";
        k7I = 10;
    }
    else if (choicePlayer1 == "8")
    {
        if ((num8 == "x") || (num8 == "o"))
        {
            Console.WriteLine("Cell already occupied, please choose another");
            Player1Turn();
        }
        else
            num8 = "x";
        k8I = 10;
    }
    else if (choicePlayer1 == "9")
    {
        if ((num9 == "x") || (num9 == "o"))
        {
            Console.WriteLine("Cell already occupied, please choose another");
            Player1Turn();
        }
        else
            num9 = "x";
        k9I = 10;
    }
    Update();
    WinCheck();
    DrawBoard();
}

void Player2Turn()// player2 choose
{
    DrawBoard();
    Console.Write(player2);
    Console.WriteLine(" choose the Number of the square you want to place your o");
    string choicePlayer2 = Console.ReadLine();
    // if occupied if cell = 0 or 10, choose another
    if (choicePlayer2 == "1")
    {
        if ((num1 == "x") || (num1 == "o"))
        {
            Console.WriteLine("Cell already occupied, please choose another");
            Player2Turn();
        }
        else
            num1 = "o";
        k1I = 0;
    }
    else if (choicePlayer2 == "2")
    {
        if ((num2 == "x") || (num2 == "o"))
        {
            Console.WriteLine("Cell already occupied, please choose another");
            Player2Turn();
        }
        else
            num2 = "o";
        k2I = 0;
    }
    else if (choicePlayer2 == "3")
    {
        if ((num3 == "x") || (num3 == "o"))
        {
            Console.WriteLine("Cell already occupied, please choose another");
            Player2Turn();
        }
        else
            num3 = "o";
        k3I = 0;
    }
    else if (choicePlayer2 == "4")
    {
        if ((num4 == "x") || (num4 == "o"))
        {
            Console.WriteLine("Cell already occupied, please choose another");
            Player2Turn();
        }
        else
            num4 = "o";
        k4I = 0;
    }
    else if (choicePlayer2 == "5")
    {
        if ((num5 == "x") || (num5 == "o"))
        {
            Console.WriteLine("Cell already occupied, please choose another");
            Player2Turn();
        }
        else
            num5 = "o";
        k5I = 0;
    }
    else if (choicePlayer2 == "6")
    {
        if ((num6 == "x") || (num6 == "o"))
        {
            Console.WriteLine("Cell already occupied, please choose another");
            Player2Turn();
        }
        else
            num6 = "o";
        k6I = 0;
    }
    else if (choicePlayer2 == "7")
    {
        if ((num7 == "x") || (num7 == "o"))
        {
            Console.WriteLine("Cell already occupied, please choose another");
            Player2Turn();
        }
        else
            num7 = "o";
        k7I = 0;
    }
    else if (choicePlayer2 == "8")
    {
        if ((num8 == "x") || (num8 == "o"))
        {
            Console.WriteLine("Cell already occupied, please choose another");
            Player2Turn();
        }
        else
            num8 = "o";
        k8I = 0;
    }
    else if (choicePlayer2 == "9")
    {
        if ((num9 == "x") || (num9 == "o"))
        {
            Console.WriteLine("Cell already occupied, please choose another");
            Player2Turn();
        }
        else
            num9 = "o";
        k9I = 0;
    } 
    
    DrawBoard();
    WinCheck();
}

void Update()
{
    aRowI = (k1I + k2I + k3I);
    bRowI = (k4I + k5I + k6I);
    cRowI = (k7I + k8I + k9I);
    xColumnI = (k1I + k4I + k7I);
    yColumnI = (k2I + k5I + k8I);
    zColumnI = (k3I + k6I + k9I);
    åDiagonalI = (k1I + k5I + k9I);
    öDiagonalI = (k3I + k5I + k7I);
}

void WinCheck() //need to add tie condition
{
    if (aRowI == 30 || bRowI == 30 || cRowI == 30 || xColumnI == 30 || yColumnI == 30 || zColumnI == 30 || åDiagonalI == 30 || öDiagonalI == 30)
    {
        Console.WriteLine($"{player1} WINS !");
        hasWon = true;
        HasWonCheck(hasWon);
    }
    else if (aRowI == 0 || bRowI == 0 || cRowI == 0 || xColumnI == 0 || yColumnI == 0 || zColumnI == 0 || åDiagonalI == 0 || öDiagonalI == 0)
    {
        Console.WriteLine($"{player2} WINS !");
        hasWon = true;
        HasWonCheck(hasWon);
    }

    else if (k1I != 5 && k2I != 5 && k3I != 5 && k4I != 5 && k5I != 5 && k6I != 5 && k7I != 5 && k8I != 5 && k9I != 5)
    {
        Console.WriteLine("It's a Draw !");
        PlayAgain();
    }
    
}*/

void HasWonCheck(bool hasWon)
{
    if (hasWon);
    PlayAgain();
}

void PlayAgain()
{
    Console.WriteLine("Would you like to play again?");
    Console.WriteLine("[1] for YES : [2] for NO");
    int playAgain = Convert.ToInt32(Console.ReadLine());
    if (playAgain == 1)
    {
        Console.Clear();
        Start();
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
