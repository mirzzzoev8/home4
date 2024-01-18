int Max(int val1, int val2)
{
    if(val1 < val2)
    {
        return val2;
    }
    else
    {
        return val1;
    }
}

System.Console.WriteLine(Max(4,3));