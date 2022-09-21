//We'll make a text-driven Painting Tool!

//Create a two-dimensional array as the canvas. We want to be able to store letters in that array. What type do you need? An array of size 5x5 should be enough for this demo.
//Repeatedly:
//Print all the contents of the two-dimensional array to the user by printing the complete array to the user. But also print the coordinates, so users understand which is the x and y coordinate and what values they have.
//Ask the user for a x coordinate
//Ask the user for a y coordinate
//Ask the user for a symbol
//Store the symbol at the correct index of the two dimensional array

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

UserInput();
PrintXYGrid();

//print paintToolArray
void PrintXYGrid()
{
    Console.WriteLine("Y");
    for (int y = 0; y < 5; y++)
    {
        Console.Write($"{4-y}");
        for (int x = 0; x < 5; x++)
        {
            Console.Write($"{paintToolArray[x,y]}");
        }
        Console.WriteLine();
    }
    Console.Write("\\");
    for (int x = 0; x < 5; x++)
    {
        Console.Write(" " + x);
    }
    Console.Write(" X");
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
