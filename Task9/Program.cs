int Min(int val1, int val2)
{
    if(val1 > val2)
    {
        return val2;
    }
    else
    {
        return val1;
    }
}

System.Console.WriteLine(Min(4,3));