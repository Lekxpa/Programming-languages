//Задача 13: Напишите программу, которая выводит третью цифру 
//(слева направо) заданного числа или сообщает, что третьей цифры нет.
//645 -> 6
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int current;

if (num < 0) num = -num;

if (num >=100)
{
    current = (num % 1000) / 100;
    Console.WriteLine(current);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}