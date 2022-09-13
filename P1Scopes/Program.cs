

{
    Console.WriteLine("Give me a number.");
    //string input = Console.ReadLine();
    int input = Convert.ToInt32(Console.ReadLine());
    Console.Write(input);
    Console.WriteLine(1);
}
{
    Console.WriteLine("Give me another number.");
    int input = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(input + 1);
}
{
    Console.WriteLine("Give me another number.");
    char input = Convert.ToChar(Console.ReadLine());
    Console.WriteLine(input ++ );
}
