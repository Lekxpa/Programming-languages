//Задача 10 Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());

int current = (num % 100) / 10;
if (num < 0) current = -current;
Console.WriteLine (current);
