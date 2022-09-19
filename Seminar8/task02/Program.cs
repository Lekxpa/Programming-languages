// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт 
//номер строки с наименьшей суммой элементов: 1 строка

int[,] MyArray(int m, int n, int min, int max)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int lines = 0; lines < array.GetLength(0); lines++)
    {
        for (int cols = 0; cols < array.GetLength(1); cols++)
        {
            Console.Write($"{array[lines,cols]}\t ");
        }
        Console.WriteLine();
    }
}

int SumOfElementsOfLine(int[,] array, int i)
{
    int SumLine = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        SumLine += array[i,j];
    }
    Console.WriteLine($"Сумма элементов {i + 1}-й строки: {SumLine}");
    return SumLine;
}

void MinOfSumOfElementsOfLine(int[,] array)
{
    int result = 0;
    int tempsum = SumOfElementsOfLine(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int SumLine = SumOfElementsOfLine(array, i);
        if (tempsum > SumLine)
        {
            tempsum = SumLine;
            result = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в {result+1} строке");
}

Console.Write("Введите количество строк в массиве: ");
int lines = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Введите значение начала интервала: ");
int beginline = int.Parse(Console.ReadLine());
Console.Write("Введите значение окончания интервала: ");
int endline = int.Parse(Console.ReadLine());


int[,] MonArray = MyArray(lines, columns, beginline, endline);
PrintArray(MonArray);
MinOfSumOfElementsOfLine(MonArray);