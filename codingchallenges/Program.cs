
//to minutes
int inMinutes = 0;
int inSeconds = 0;


Convert2Time();
FlipIntBool();

void Convert2Time()
{
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
}


