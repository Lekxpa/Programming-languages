//Написать программу число и выдает, является ли число четным (делится
//ли оно на два без остатка)
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число не является четным");
}
