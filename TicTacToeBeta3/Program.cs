// Tic Tac Toe
// Setup variables & Arrays
//--Variables--
int numPlayers;

//--Arrays--
string[] playerNames = new string[4]; //Store Player Names

string[,] cellSymbol = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } }; //Numbers represent squares to input. Represent numPad
//locations (2,0),(2,1),(2,2) | (1,0),(1,1),(1,2) | (0,0),(0,1),(0,2)
int[,] CellValue = { { 5, 5, 5 }, { 5, 5, 5 }, { 5, 5, 5 } }; //Value of each cell

//Setup Game


SetUp();
DrawBoard();

void SetUp()
{
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
            Console.WriteLine("Player 1, please enter your name");
            string playerAnswer = Console.ReadLine();
            playerNames[i] = playerAnswer;
        }

    }
    else
    {
        Console.WriteLine("Player 1, please enter your name");
        string playerAnswer = Console.ReadLine();
        playerNames[0] = playerAnswer;
        Console.WriteLine("Player 2 is HAL2000");
        playerNames[2] = "HAL2000";
    }

    Console.WriteLine(" ");
    Console.WriteLine("Lets Play !");
    Console.WriteLine(" ");
}

//Drawboard
void DrawBoard()
{
    Console.WriteLine($"{cellSymbol[2,0]} | {cellSymbol[2,1]} | {cellSymbol[2,2]}");
    Console.WriteLine("- + - + - ");
    Console.WriteLine($"{cellSymbol[1,0]} | {cellSymbol[1,1]} | {cellSymbol[1,2]}");
    Console.WriteLine("- + - + - ");
    Console.WriteLine($"{cellSymbol[0,0]} | {cellSymbol[0,1]} | {cellSymbol[0,2]}");
}
//Player input
//check valid move
//check win
//check draw