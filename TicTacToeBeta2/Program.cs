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
int aRowI = (k1I + k2I + k3I);
int bRowI = (k4I + k5I + k6I);
int cRowI = (k7I + k8I + k9I);
int xColumnI = (k1I + k4I + k7I);
int yColumnI = (k2I + k5I + k8I);
int zColumnI = (k3I + k6I + k9I);
int åDiagonalI = (k1I + k5I + k9I);
int öDiagonalI = (k3I + k5I + k7I);
// What value is shown
int[] num = new int[9];
num[0] = 0;
num[1] = 0;
num[2] = 0;
num[3] = 0;
num[4] = 0;
num[5] = 0;
num[6] = 0;
num[7] = 0;
num[8] = 0;
//string row3 = $"{num7} | {num8} | {num9}";
//string row2 = $"{num4} | {num5} | {num6}";
//string row1 = $"{num1} | {num2} | {num3}";
/*replace with Array
char[,] num = new char [3,3];*/
/*t num = 0;

for (int i = 0; i < 9; i++)
{
    num[i] = 0;
}*/

int userTurn = -1;
int aiTurn = -1;
Random randomNum = new Random();

printBoard();

while (checkForWinner() == 0)
{
    // don't allow choosing occupied squares
    while (userTurn == -1 || num[userTurn] !=0)
    {
        Console.WriteLine("Please enter a number between 0 - 8");
        userTurn = int.Parse(Console.ReadLine());
        Console.WriteLine("You typed " + userTurn);
    }
    num[userTurn] = 1;

    // don't allow choosing occupied squares
    while (aiTurn == -1 || num[aiTurn] != 0)
    {
        aiTurn = randomNum.Next(8);
        Console.WriteLine("AI chooses " + aiTurn);
    }
    num[aiTurn] = 2;

    printBoard();
}
Console.WriteLine("Player "+ checkForWinner() + " won the game!");

int checkForWinner()
{
    // returns 0 if nobody won. return the player number if they won
    
    //Top Row
    if (num[0] == num[1] && num[1] == num[2])
    {
        return num[0];
    }
    //Middle Row
    if (num[3] == num[4] && num[4] == num[5])
    {
        return num[3];
    }    
    //Bottom Row
    if (num[6] == num[7] && num[7] == num[8])
    {
        return num[6];
    }
    //1st Column
    if (num[0] == num[3] && num[3] == num[6])
    {
        return num[0];
    }
    //2nd Column
    if (num[1] == num[4] && num[4] == num[7])
    {
        return num[1];
    }    
    //3rd Column
    if (num[2] == num[5] && num[5] == num[8])
    {
        return num[2];
    }
    //Forward Diagonal
    if (num[0] == num[4] && num[4] == num[8])
    {
        return num[0];
    }    
    //Back Diagonal
    if (num[2] == num[4] && num[4] == num[6])
    {
        return num[2];
    }

    return 0;
}

//print board
void printBoard()
{
    for (int i = 0; i < 9; i++)
    {
        //Console.WriteLine("Square " + i + " contains " + num[i]);
        //print X or O for each square
        // 0 means unoccupied. 1 means player1 (X) 2 means player2 (O)
        if (num[i] == 0 )
        {
            Console.Write(".");
        }
        if (num[i] == 1 )
        {
            Console.Write("X");
        }
        if (num[i] == 2 )
        {
            Console.Write("O");
        }
        // print new line every 3rd character
        if (i == 2 || i == 5 || i == 8)
        {
            Console.WriteLine();   
        }
    }
}



/*Start();

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

void DrawBoard()
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

void player1Turn() // player1 choose
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
            player1Turn();
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
            player1Turn();
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
            player1Turn();
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
            player1Turn();
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
            player1Turn();
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
            player1Turn();
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
            player1Turn();
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
            player1Turn();
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
            player1Turn();
        }
        else
        num9 = "x";
        k9I = 10;
    }
    update();
    winCheck();
    DrawBoard();
}

void player2Turn()// player2 choose
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
            player2Turn();
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
            player2Turn();
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
            player2Turn();
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
            player2Turn();
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
            player2Turn();
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
            player2Turn();
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
            player2Turn();
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
            player2Turn();
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
            player2Turn();
        }
        else
        num9 = "o";
        k9I = 0;
    } 
    
    DrawBoard();
    winCheck();
}

void update()
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

void winCheck() //need to add tie condition
{
    if (aRowI == 30 || bRowI == 30 || cRowI == 30 || xColumnI == 30 || yColumnI == 30 || zColumnI == 30 || åDiagonalI == 30 || öDiagonalI == 30)
    {
        Console.Write(player1);
        Console.WriteLine(" WINS !");
        hasWon = true;
        hasWonCheck(hasWon);
    }
    else if (aRowI == 0 || bRowI == 0 || cRowI == 0 || xColumnI == 0 || yColumnI == 0 || zColumnI == 0 || åDiagonalI == 0 || öDiagonalI == 0)
    {
        Console.Write(player2);
        Console.WriteLine(" WINS !");
        hasWon = true;
        hasWonCheck(hasWon);
    }

    else if (k1I != 5 && k2I != 5 && k3I != 5 && k4I != 5 && k5I != 5 && k6I != 5 && k7I != 5 && k8I != 5 && k9I != 5)
    {
        Console.WriteLine("It's a Draw !");
        PlayAgain();
    }
    
}

void hasWonCheck(bool hasWon)
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
}*/
