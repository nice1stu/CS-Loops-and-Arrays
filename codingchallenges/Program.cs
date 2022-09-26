
//to minutes

Convert2Time();
FlipIntBool();
DivisbileBy5();
String2Int();

void Convert2Time()
{
    int inMinutes = 0;
    int inSeconds = 0;
    
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Enter a number to convert to time");
        int userinput = Convert.ToInt32(Console.ReadLine());
        inMinutes = userinput * 60;
        inSeconds = inMinutes * 60;
        Console.WriteLine($"{userinput} is {inMinutes} in minutes & {inSeconds} in seconds.");
        Console.WriteLine();
    }

}

//FlipintBool

void FlipIntBool()
{
    bool flipIntBool = true;
    
    // Convert bool to int.
    int i = flipIntBool ? 1 : 0;
    Console.WriteLine($"FlipIntBool {i}"); // 1

    // Example bool is false.
    bool f = false;
    
    // Convert bool to int.
    int y = Convert.ToInt32(f);
    Console.WriteLine($"FlipIntBool {y}"); // 0
    Console.WriteLine();
}

//divisible by 5

void DivisbileBy5()
{
    for (int i = 0; i < 3; i++)
    {
        bool divisibleBy5 = true;
        Console.WriteLine("Enter a number to test divisibnilty by 5");
        int userinput = Convert.ToInt32(Console.ReadLine());
        divisibleBy5 = Convert.ToBoolean(userinput % 5);
        string answer =  divisibleBy5 ? "False" : "True";
        Console.WriteLine($"{userinput} divisble by 5 is {answer}");
        Console.WriteLine();
    }
}

//string to int

void String2Int()
{
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("Enter a number to convert to integer");
        string userinput = Console.ReadLine();
        int userInputI = Int32.Parse(userinput);
        Console.WriteLine($"{userinput} is {userInputI}");
        Console.WriteLine();
    }
}

//return last in array

string[] tripleArray = new String [3];

for (int j = 0; j < 3; j++)
{
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine("please enter 3 elements to store");
        string userInput = Console.ReadLine();
        string store2Array = userInput;
        tripleArray[i] = store2Array;
    }

    Console.WriteLine($"The Last element of the array is {tripleArray[2]}");
    Console.WriteLine();
}

//reverse Array

void ReverseArray()
{
    for (int j = 0; j < 3; j++)
    {
        Console.WriteLine("How many elements in this array?");
        int numElements = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < numElements; i++)
        {

        }

        char[] reversingArray = new char[numElements];

    }

}