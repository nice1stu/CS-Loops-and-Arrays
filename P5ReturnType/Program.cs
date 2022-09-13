// Rock-Paper-Scissors Mini-Game.

string playerChoice;
string aIChoice;

void PlayerChoice()
{
    Console.WriteLine("Pick Rock, Paper or Scissors.");
    string playerChoice = Console.ReadLine();
    if (playerChoice != "Rock" || playerChoice != "Paper" || playerChoice != "Scissors")
    {
        return PlayerChoice()
            Console.WriteLine("That's not a valid input.");
    }

}

void AIChoice()
{
    Random random = new Random(1, 3);
    if (random == 1)
    {
        aIChoice = "Rock";
    }
    else if (random == 2)
    {
        aIChoice = "Paper";
    }
    else if (random == 3)
    {
        aIChoice = "Scissors";
    }

}
PlayerChoice();
Console.WriteLine(playerChoice);
AIChoice();
Console.WriteLine(aIChoice);