void Swap(ref int a, ref int b)
{
    int c = 0;
    c = b;
    b = a;
    a = c;
}

int a = Convert.ToInt32(Console.ReadLine());

int b = Convert.ToInt32(Console.ReadLine());

Swap(ref a, ref b);
System.Console.WriteLine(a);

System.Console.WriteLine(b);