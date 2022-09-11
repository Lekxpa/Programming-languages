// Задача 43: Напишите программу, которая найдёт точку 
//пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

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

void PointOfIntersection (int[,] Array)
{
    if(Array[0,0] * Array[1,1] - Array[1,0] * Array[0,1] == 0)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        int x = (Array[0,0] - Array[1,0]) /(Array[1,1] - Array[0,1]);
        int y = Array[0,1] * x + Array[0,0];
        int[,] result = new int[x,y];
        Console.Write($"Точка пересечения: {x:F1}, {y:F1}");
    }
}

Console.Write("Введите минимальное значение: ");
int minEl = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int maxEl = int.Parse(Console.ReadLine());

int[,] MonArray = MyArray(2, 2, minEl, maxEl);
PrintArray(MonArray);
PointOfIntersection(MonArray);
Console.WriteLine();