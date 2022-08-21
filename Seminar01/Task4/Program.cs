Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
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