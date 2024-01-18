int EvenCount(int n)
{
    int cnt = 0;
    for (int i = 0; i < n; i++)
    {
        if(i % 2 == 0)
        {
            cnt++;
        }
    }
    return cnt;
}

int OddCount(int n)
{
    int cnt = 0;
    for (int i = 0; i < n; i++)
    {
        if(i % 2 != 0)
        {
            cnt++;
        }
    }
    return cnt;
}

int DigitCount(int n)
{
    int cnt = 0;
    for (int i = 0; i < n; i++)
    {
        cnt++;
    }
    return cnt;
}

int SumDigit(int n)
{
    int cnt = 0;
    for (int i = 0; i < n; i++)
    {
        cnt+=i;   
    }
    return cnt;
}
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Even: " + EvenCount(a));
System.Console.WriteLine("Odd: " + OddCount(a));
System.Console.WriteLine("Digit: " + DigitCount(a));
System.Console.WriteLine("Sum: " + SumDigit(a));

