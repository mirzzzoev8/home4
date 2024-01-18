void Divisors(int x) 

{
    int a = 0;
    for (int i = 1; i <= x; i++)
    {
        if(x%i == 0)
        {
            System.Console.WriteLine(i);
        }
    }
}

Divisors(8);