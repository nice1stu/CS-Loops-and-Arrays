Console.WriteLine("What Fibonacci number would you like?");
string input = Console.ReadLine();
int n = Convert.ToInt32(input);

int fibonacci(int n)
{
    if (n == 0)
    {
        return n;
    }
    if (n == 1)
    {
        return n;
    }
    else
        return fibonacci(n - 1) + fibonacci(n - 2);
}
Console.WriteLine(fibonacci(n));
return n;
    
