int numberOfTimes = 13;
int currentCount = 0;
double startNum = 1;

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

    //double answerNum;
    double answerNum = (startNum * 2);
    Console.Write($" - {answerNum}");
    startNum = answerNum;
}
