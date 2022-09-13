int timer = 5;

void Countdown()
{
        Console.WriteLine();
        Console.WriteLine(timer);
        timer = timer - 1;
}
while (timer >= 0)
{
Countdown();
}

Console.WriteLine("Launch!");

