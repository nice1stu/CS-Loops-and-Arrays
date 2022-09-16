// TicTacToe

int numPlayers;
string player1;
string player2;
bool hasWon = false;
// assign player1 = x, assign player2 = o
int x = 10;
int o = 0;
//What value is stored
int k1I = 5;
int k2I = 5;
int k3I = 5;
int k4I = 5;
int k5I = 5;
int k6I = 5;
int k7I = 5;
int k8I = 5;
int k9I = 5;
int k1k3RowI = (k1I + k2I + k3I);
int k4k6RowI = (k4I + k5I + k6I);
int k7k9RowI = (k7I + k8I + k9I);
int k1k7ColumnI = (k1I + k4I + k7I);
int k2k8ColumnI = (k2I + k5I + k8I);
int k3k9ColumnI = (k3I + k6I + k9I);
int k1k9DiagonalI = (k1I + k5I + k9I);
int k3k7DiagonalI = (k3I + k5I + k7I);
// What value is shown use readkey
string num1 = "1";
string num2 = "2";
string num3 = "3";
string num4 = "4";
string num5 = "5";
string num6 = "6";
string num7 = "7";
string num8 = "8";
string num9 = "9";

Start();
//update();
// add hasWon bool to end game or loop
/*
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

start();*/

//Game start
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
    DrawBoard();
    letsPlay();
}

//Draw Board
//Clear screen !
void DrawBoard()
{
    Console.Clear();
    string row3 = $"{num7} | {num8} | {num9}";
    string row2 = $"{num4} | {num5} | {num6}";
    string row1 = $"{num1} | {num2} | {num3}";

    Console.WriteLine(row3);
    Console.WriteLine("- | - | - ");
    Console.WriteLine(row2);
    Console.WriteLine("- | - | - ");
    Console.WriteLine(row1);
}

void letsPlay()
{
    while (hasWon == false)
    {
        player1Turn();
        update();
        winCheck();
        player2Turn();
        update();
        winCheck();
    }
}

void winCheck()
{
    if (k1k3RowI == 30 || k4k6RowI == 30 || k7k9RowI == 30 || k1k7ColumnI == 30 || k2k8ColumnI == 30 || k3k9ColumnI == 30 || k1k9DiagonalI == 30 || k3k7DiagonalI == 30)
    {
        Console.Write(player1);
        Console.WriteLine(" WINS !");
        hasWon = true;
        hasWonCheck(hasWon);
    }
    else if (k1k3RowI == 0 || k4k6RowI == 0 || k7k9RowI == 0 || k1k7ColumnI == 0 || k2k8ColumnI == 0 || k3k9ColumnI == 0 || k1k9DiagonalI == 0 || k3k7DiagonalI == 0)
    {
        Console.Write(player2);
        Console.WriteLine(" WINS !");
        hasWon = true;
        hasWonCheck(hasWon);
    }
}

void hasWonCheck(bool hasWon)
{
    if (hasWon);
    PlayAgain();
    //Console.WriteLine(" Thanks for playing");
}


// Player Turns
// !!! Note add condition if cell already used, can't over-ride
void cellCheck()
{
    
}

//DrawBoard();

void player1Turn() // player1 choose
{
    Console.Write(player1);
    Console.WriteLine(" choose the Number of the square you want to place your x");
    string choicePlayer1 = Console.ReadLine();
    // if occupied if cell = 0 or 10, choose another
    if (choicePlayer1 == "1")
    {
        num1 = "x";
        k1I = 10;
    }
    else if (choicePlayer1 == "2")
    {
        num2 = "x";
        k2I = 10;

    }
    else if (choicePlayer1 == "3")
    {
        num3 = "x";
        k3I = 10;
    }
    else if (choicePlayer1 == "4")
    {
        num2 = "x";
        k4I = 10;
    }
    else if (choicePlayer1 == "5")
    {
        num5 = "x";
        k5I = 10;
    }
    else if (choicePlayer1 == "6")
    {
        num6 = "x";
        k6I = 10;
    }
    else if (choicePlayer1 == "7")
    {
        num7 = "x";
        k7I = 10;
    }
    else if (choicePlayer1 == "8")
    {
        num8 = "x";
        k8I = 10;
    }
    else if (choicePlayer1 == "9")
    {
        num9 = "x";
        k9I = 10;
    }

    DrawBoard();
    winCheck();
}

void player2Turn()// player2 choose
{
    Console.Write(player2);
    Console.WriteLine(" choose the Number of the square you want to place your o");
    string choicePlayer2 = Console.ReadLine();
    // if occupied if cell = 0 or 10, choose another
    if (choicePlayer2 == "1")
    {
        num1 = "o";
        k1I = 0;
    }
    else if (choicePlayer2 == "2")
    {
        num2 = "o";
        k2I = 0;
    }
    else if (choicePlayer2 == "3")
    {
        num3 = "o";
        k3I = 0;
    }
    else if (choicePlayer2 == "4")
    {
        num4 = "o";
        k4I = 0;
    }
    else if (choicePlayer2 == "5")
    {
        num5 = "o";
        k5I = 0;
    }
    else if (choicePlayer2 == "6")
    {
        num6 = "o";
        k6I = 0;
    }
    else if (choicePlayer2 == "7")
    {
        num7 = "o";
        k7I = 0;
    }
    else if (choicePlayer2 == "8")
    {
        num8 = "o";
        k8I = 0;
    }
    else if (choicePlayer2 == "9")
    {
        num9 = "o";
        k9I = 0;
    } 
    
    DrawBoard();
}

void update()
{
    k1k3RowI = (k1I + k2I + k3I);
    k4k6RowI = (k4I + k5I + k6I);
    k7k9RowI = (k7I + k8I + k9I);
    k1k7ColumnI = (k1I + k4I + k7I);
    k2k8ColumnI = (k2I + k5I + k8I);
    k3k9ColumnI = (k3I + k6I + k9I);
    k1k9DiagonalI = (k1I + k5I + k9I);
    k3k7DiagonalI = (k3I + k5I + k7I);
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
