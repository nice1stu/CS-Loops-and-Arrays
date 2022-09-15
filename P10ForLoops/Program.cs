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
for (currentCount = 0; currentCount < 11; currentCount++)
{
    double startNum = 0;
    double answerNum;
    answerNum = Math.Pow(2, startNum);
    Console.Write($"{answerNum} - ");
    startNum = answerNum;
}
