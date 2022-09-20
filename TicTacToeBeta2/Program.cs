// TicTacToe


int[] num = new int[9];
/*num[0] = 0;
num[1] = 0;
num[2] = 0;
num[3] = 0;
num[4] = 0;
num[5] = 0;
num[6] = 0;
num[7] = 0;
num[8] = 0;*/

for (int i = 0; i < 9; i++)
{
    num[i] = 0;
}

int userTurn = -1;
int aiTurn = -1;
Random randomNum = new Random();

//void Start()

    PrintBoard(); 
    
    while (CheckForWinner() == 0) 
    { 
        // don't allow choosing occupied squares
        // while (userTurn == -1 || num[userTurn] !=0)
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
        
        PrintBoard(); 
    } 
    Console.WriteLine("Player "+ CheckForWinner() + " won the game!"); 
    PlayAgain();

int CheckForWinner()
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
void PrintBoard()
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

//Play Again
void PlayAgain()
{
    Console.WriteLine("Would you like to play again?");
    Console.WriteLine("[1] for YES : [2] for NO");
    int playAgain = Convert.ToInt32(Console.ReadLine());
    if (playAgain == 1)
    {
        Console.Clear();
        //Start();
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