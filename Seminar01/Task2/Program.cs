Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());
int result = 0;
if (a > b)
{
    result = a;
    Console.WriteLine($"max = {result}");
}
else
{
    result = b;
    Console.WriteLine($"max = {result}");
}