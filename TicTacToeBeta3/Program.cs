// Tic Tac Toe
//--Variables--
int numPlayers;

//--Arrays--
string[] playerNames = new string[4];




SetUp();

void SetUp()
{

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