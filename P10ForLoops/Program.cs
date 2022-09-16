int numberOfTimes = 13;
int currentCount = 0;


Console.WriteLine("Here are 13 random numbers (1-6):");

RandomGenLoop:
for (currentCount = 0; currentCount < numberOfTimes; currentCount++)
{
    Random random = new Random();
    int randomNum = random.Next(1, 6);
    Console.Write(randomNum);
}
Console.WriteLine("");
Console.WriteLine("Here's the power of 2's:");
PowersLoop:
Console.Write($"1");
for (currentCount = 0; currentCount < 10; currentCount++)
{

    double startNum = 1;
    double answerNum = (startNum * 2);
    Console.Write($" - {answerNum}");
    startNum = answerNum;
}
Console.WriteLine("");
Console.WriteLine("I'm counting down!");
CountdownLoop:
int countdown = 9;
Console.Write($"10");
for (currentCount = 0; currentCount < 9; currentCount++)
{
    
    Console.Write($".. {countdown}");
    countdown--;
}


