Console.Write("Введите натуральное число N: ");
int n = int.Parse(Console.ReadLine()!);

void number (int k)
{
    if (k!=0) 
    {
     Console.Write($"{k}, ");   
     number (k-1);
    }
}
number (n);
