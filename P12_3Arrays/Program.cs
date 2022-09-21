//We'll make a text-driven Painting Tool!
// give X, Y, symbol as 2,3,O / 1,4,E / 2,4,Y

//delcare & initialise
string[,] paintToolArray = new String[5,5];
int getXcordinate;
int getYcordinate;
string getsymbol;

//initialize all values of array
for (int y = 0; y < 5; y++)
{
    for (int x = 0; x < 5; x++)
    {
        paintToolArray[x, y] = " ";
    }
}

P12_3Arrays();

void P12_3Arrays()
{
    for (int i = 0; i < 3; i++)
    {
        UserInput();
        PrintXYGrid();
    }
}

//print paintToolArray
void PrintXYGrid()
{
    Console.WriteLine("Y");
    for (int y = 0; y < 5; y++)
    {
        Console.Write($"{4-y}");
        for (int x = 0; x < 5; x++)
        {
            Console.Write($"{paintToolArray[x,(4-y)]}");
        }
        Console.WriteLine();
    }
    Console.Write("\\");
    for (int x = 0; x < 5; x++)
    {
        Console.Write(x);
    }
    Console.Write("X");
}

//get user input for symbol and position on array
void UserInput()
{
    Console.WriteLine();
    Console.WriteLine("Give me a X coordinate.");
    getXcordinate = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Give me a Y coordinate.");
    getYcordinate = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Give me a symbol to place.");
    getsymbol = Console.ReadLine();
    paintToolArray[getXcordinate, getYcordinate] = getsymbol;
}
