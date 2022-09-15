int numberOfTimes = 13;
int currentCount = 0;

Console.WriteLine("Here is 13 random numbers (1-6):");

RandomGenLoop:

for (currentCount = 0; currentCount < numberOfTimes; currentCount++)
{
    Random random = new Random();
    int randomNum = random.Next(1, 6);
    Console.Write(randomNum);
    
}
