int min = 1;
int max = 10;
int guess;
int number = 0;

int AskNumberBetween()
    {
        Random random = new Random();
        number = random.Next(min, max);
        Console.WriteLine(number);
        return number;
    }
do
    {
        AskNumberBetween();
        Console.WriteLine($"Please give me a number between {min} and {max}");
        string input = Console.ReadLine();
        guess = Convert.ToInt32(input);
    } while (number != guess);

    Console.WriteLine($"You gave the number {guess}");