for (int i = 0;; i++)
{
    if ((i%2==0) || (i==5))
        continue;
    if (i == 13)
        break;
    Console.WriteLine(i);
}

Console.WriteLine("Done.");