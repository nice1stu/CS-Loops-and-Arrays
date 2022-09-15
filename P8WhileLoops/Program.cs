int startMatches = 10;
int remainingMatches = startMatches;

Console.WriteLine("There are 10 Matches.");


while (remainingMatches > 0)
{
    Console.WriteLine("How many do you want to draw?");
    string choice = Console.ReadLine();
    int choiceI = Convert.ToInt32(choice);
    remainingMatches = startMatches - choiceI;
    Console.WriteLine($"There are {remainingMatches} matches.");
    startMatches = remainingMatches;
}
Console.WriteLine("Game Over");
