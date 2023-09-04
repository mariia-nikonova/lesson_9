Console.Write("Введите натуральное число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральное число N: ");
int n = int.Parse(Console.ReadLine()!);


int Sum(int k, int c)
{
     int s = k;
    if (k == c)
        return 0;
    else
    {
        k++;
        s = k + Sum(k, c);
        return s;
    }
}

Console.Write($"{Sum(m-1,n)} "); 
