int min = 1;
int max = 10;
int guess;
int number = 0;
//AskNumberBetween();

    int AskNumberBetween()
    {
        Random random = new Random();
        int number = random.Next(min, max);
        return number;
    }
Console.WriteLine(number);

    do
    {
        Console.WriteLine($"Please give me a number between {min} and {max}");
        string input = Console.ReadLine();
        guess = Convert.ToInt32(input);
    } while (AskNumberBetween() != guess);

    Console.WriteLine($"You gave the number {guess}");