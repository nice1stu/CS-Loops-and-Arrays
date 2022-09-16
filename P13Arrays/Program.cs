Console.WriteLine("I will roll 10.000 numbers between 0 and 10:");

Random result = new Random();

//Fill array with random numbers
int[] table = new int[10000];
for (int count = 0; count < table.Length; count++)
    table[count] = result.Next(0, 11);

//Count how many times a number occurs
int[] numberCounts = new int[11];
for (int count = 0; count < table.Length; count++)
    numberCounts[table[count]]++;

//Print the count of the numbers
for (int count = 0; count < numberCounts.Length; count++)
    Console.WriteLine($"I rolled {count}'s a total of {numberCounts[count]} times");