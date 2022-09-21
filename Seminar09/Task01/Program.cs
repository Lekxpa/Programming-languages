//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumOfElements(int numM, int numN)
{
    int result = 0;
    if (numM > numN) return result;
    return  result + numM + SumOfElements(++numM, numN);
}

Console.Write("Введите значение - начало промежутка: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение - окончание промежутка: ");
int n = int.Parse(Console.ReadLine());
int result = SumOfElements(m, n);
Console.WriteLine(result);