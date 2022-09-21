//We'll make a text-driven Painting Tool!

//Create a two-dimensional array as the canvas. We want to be able to store letters in that array. What type do you need? An array of size 5x5 should be enough for this demo.
//Repeatedly:
//Print all the contents of the two-dimensional array to the user by printing the complete array to the user. But also print the coordinates, so users understand which is the x and y coordinate and what values they have.
//Ask the user for a x coordinate
//Ask the user for a y coordinate
//Ask the user for a symbol
//Store the symbol at the correct index of the two dimensional array

char[,] paintToolArray = new char[5,5];

for (int y = 0; y < 5; y++)
{
    Console.WriteLine(4-y);
}

for (int x = 0; x < 5; x++)
{
    Console.Write(x);
}