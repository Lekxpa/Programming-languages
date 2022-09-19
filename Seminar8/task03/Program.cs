// Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

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


int[,] MultiplyMatrix(int[,] FirstArr, int[,] SecondArr)
{
    int rows1 = FirstArr.GetLength(0);
    int cols1 = FirstArr.GetLength(1);
    int cols2 = SecondArr.GetLength(1);
    int[,] res = new int[rows1, cols2];
    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            for (int k = 0; k < cols1; k++)
            {
                res[i,j] += FirstArr[i,k] * SecondArr[k,j];
            }
        }
    }
    return res;
}

Console.Write("Введите количество строк первой матрицы: ");
int Rows1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов первой матрицы: ");
int Coloms1 = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк второй матрицы: ");
int Rows2 = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов второй матрицы: ");
int Coloms2 = int.Parse(Console.ReadLine());
Console.Write("Введите значение начала интервала: ");
int beginline = int.Parse(Console.ReadLine());
Console.Write("Введите значение окончания интервала: ");
int endline = int.Parse(Console.ReadLine());

if (Coloms1 == Rows2)
{
    int[,] FirstMatrix = MyArray(Rows1, Coloms1, beginline, endline);
    Console.WriteLine("Первая матрица:");
    PrintArray(FirstMatrix);
    int[,] SecomdMatrix = MyArray(Rows2, Coloms2, beginline, endline);
    Console.WriteLine("Вторая матрица:");
    PrintArray(SecomdMatrix);
    int[,] ResMatrix = MultiplyMatrix(FirstMatrix, SecomdMatrix);
    Console.WriteLine("Произведение двух матриц:");
    PrintArray(ResMatrix);
}
else
{
    Console.WriteLine();
    Console.WriteLine("Количество строк первой матрицы должно совпадать с количеством столбцов второй матрицы");
    Console.WriteLine("Попробуйте еще раз!");
    Console.WriteLine();
}