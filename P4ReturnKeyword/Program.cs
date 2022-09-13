void MyFunction()
{
    Console.WriteLine("What's your name?");
    if (Console.ReadLine() == "Neo")
    {
        return;
    }
    Console.WriteLine("How old are you?");
    string input = Console.ReadLine();
    int InputInt = Convert.ToInt32(input);
    
    if (InputInt < 18)
    {
        return;
    }
    Console.WriteLine("Do you want to enter?");
    if (Console.ReadLine() == "Yes")
    {
        return;
    }
    Console.WriteLine("Do you want to turn back??");
    if (Console.ReadLine() == "No")
    {
        Console.WriteLine("Congratulations, you made it in.");
    }
}

MyFunction();
