// Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double[,] MyArray(int m, int n, double min, double max)
{
    double[,] result = new double[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().NextDouble()*10;
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int cols = 0; cols < array.GetLength(1); cols++)
        {
            Console.Write($"{array[rows,cols]:F2}\t ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк в массиве: ");
int lines = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());
Console.Write("Введите значение начала интервала: ");
Double beginline = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение окончания интервала: ");
Double endline = Convert.ToDouble(Console.ReadLine());

double[,] MonArray = MyArray(lines, columns, beginline, endline);
PrintArray(MonArray);