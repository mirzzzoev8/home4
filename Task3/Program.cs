 int Max = -999999999;
 int Min = 999999999;
 int MinDigit (int n)
 {

    for (int i = n; i > 0; i/=10)
    {
        if(i%10 < Min)
        {
            Min = i%10;
        }
    }
    return Min;
 }
  int MaxDigit (int n)
 {

    for (int i = n; i > 0; i/=10)
    {
        if(i%10 > Max)
        {
            Max = i%10;
        }
    }
    return Max;
 }

 System.Console.WriteLine(MinDigit(1234));
 System.Console.WriteLine(MaxDigit(1234));
 System.Console.WriteLine(Min + Max );