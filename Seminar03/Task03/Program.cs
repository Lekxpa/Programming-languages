//Задача 23  Напишите программу, которая принимает на вход 
//число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int current = 1;

while (current <= num)
{
    Console.Write($"{current*current*current}, ");
    current++;
}
Console.WriteLine();

for (int i = 1; i <= num; i++)
{
    Console.Write($"{i*i*i}, ");
}
Console.WriteLine();