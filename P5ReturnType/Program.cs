// Rock-Paper-Scissors Mini-Game.

string playerChoice;
string aIChoice;
Random random = new Random();
bool playAgain = true;

void PlayerChoice()
{
    playerChoice = "";
    while (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
    {
        Console.WriteLine("Pick rock, paper or scissors.");
        playerChoice = Console.ReadLine();
        playerChoice = playerChoice.ToLower();
    }

}

void AIChoice()
{
    int random 
    if (random == 1)
    {
        aIChoice = "rock";
    }
    else if (random == 2)
    {
        aIChoice = "paper";
    }
    else if (random == 3)
    {
        aIChoice = "scissors";
    }

}
PlayerChoice();
Console.WriteLine(playerChoice);
AIChoice();
Console.WriteLine(aIChoice);