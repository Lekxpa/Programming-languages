Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int c = int.Parse(Console.ReadLine());
int result = 0;
if (a > b)
{
    if (a > c)
    {
      result = a;
    }
    else
    {
        result = c;
    }
}
else
{
    if (b > c)
    {
         result = b;
    }
    else
    {
        result = c;
    }
}
 Console.WriteLine($"max = {result}");