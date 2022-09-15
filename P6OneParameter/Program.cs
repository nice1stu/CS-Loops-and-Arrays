/*Console.WriteLine("What Fibonacci number would you like?");
string input = Console.ReadLine();
int n = Convert.ToInt32(input);
fibonacci((int n);
int fibonacci(int n)
{
    n = 7;
    if ((n == 0 || n == 1))
    {
        return n;
    }
    else
        return fibonacci(n - 1) + fibonacci(n - 2);
}

if (n == 1)
{
    return 1;
}

return n;
    

Console.WriteLine(fibonacci);*/
int n;
int f(int n)
{
    if (n == 0 || n == 1)
        return n;
    else
        return f(n - 1) + f(n - 2);
}
    
    Console.WriteLine(f);