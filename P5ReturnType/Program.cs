// Rock-Paper-Scissors Mini-Game.

string playerChoice;
string aIChoice;
string answer;
Random random = new Random();
bool playAgain = true;


while (playAgain)
{
    aIChoice = "";
    
    PlayerInput();
    AiChoice();
    Console.WriteLine("I pick " + aIChoice);

    switch (playerChoice)
    {
        case "rock":
            if (aIChoice == "rock")
            {
                Console.WriteLine("It's a draw!");
            }
            else if (aIChoice == "paper")
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("You win!");   
            }
            break;
        
        case "paper":
            if (aIChoice == "rock")
            {
                Console.WriteLine("You win!");
            }
            else if (aIChoice == "paper")
            {
                Console.WriteLine("It's a draw!");
            }
            else
            {
                Console.WriteLine("You lose!");   
            }
            break;
        case "scissors":
            
            if (aIChoice == "rock")
            {
                Console.WriteLine("You lose!");
            }
            else if (aIChoice == "paper")
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("It's a draw!");   
            }
            break;
    }
    Console.WriteLine("Would you like to play again?(y/n): ");
    answer = Console.ReadLine();
    answer = answer.ToLower();

    if (answer == "y")
    {
        playAgain = true;
        Console.Clear();
    }
    else
    {
        playAgain = false;
        Console.Clear();
    }
}
Console.WriteLine("Thanks for playing");

// Methods
string PlayerInput()
{
    Console.WriteLine("Pick rock, paper or scissors.");
    playerChoice = Console.ReadLine();
    playerChoice = playerChoice.ToLower();
    if (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
    {
        Console.WriteLine("That's not a valid input.");
        PlayerInput();
    }
    return playerChoice;
}

string AiChoice()
{
    switch (random.Next(1, 4))
    {
        case 1:
            aIChoice = "rock";

            break;
        case 2:
            aIChoice = "paper";
            
            break;
        case 3:
            aIChoice = "scissors";
            break;
    }

    return aIChoice;
}