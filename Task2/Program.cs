int Add(int a,int b)
{
    return a + b;
}

int Subtract(int a,int b)
{
    return a - b;
}

int Multiply(int a,int b)
{
    return a * b;
}

int Division (int a,int b)
{
    return a / b;
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Add: " + Add(a,b));
System.Console.WriteLine("Subtract: " + Subtract(a,b));
System.Console.WriteLine("Multiply: " + Multiply(a,b));
System.Console.WriteLine("division: " + Division(a,b));
