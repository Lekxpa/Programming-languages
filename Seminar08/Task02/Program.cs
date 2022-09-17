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
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int cols = 0; cols < array.GetLength(1); cols++)
        {
            Console.Write($"{array[rows,cols]}\t ");
        }
        Console.WriteLine();
    }
}

void SumOfElemOfRow (int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        int result = 0;
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            result = result + Array[i, j];
        }
        Console.WriteLine();
        Console.WriteLine(result    );
    }
      //Console.Write("Введите {0}-й элемент: " ,  i + 1);
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
SumOfElemOfRow(MonArray);