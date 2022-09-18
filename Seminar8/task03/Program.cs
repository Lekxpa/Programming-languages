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
    //if (m != n) Console.WriteLine("Количество строк должно совпадать с количеством столбцов. Попробуйте еще раз!");
    //else
    //{
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                result[i,j] = new Random().Next(min, max + 1);
            }
        }
    //}
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


void MultiplyMatrix(int[,] FirstMartrix, int[,] SecomdMartrix, int[,] ResM)
{
    if (FirstMartrix != SecomdMartrix) Console.WriteLine("Количество строк должно совпадать с количеством столбцов. Попробуйте еще раз!");
    else
    {
        for (int i = 0; i < ResM.GetLength(0); i++)
        {
            for (int j = 0; j < ResM.GetLength(1); j++)
            {
            
            //else
            //{
                int sum = 0;
                for (int k = 0; k < FirstMartrix.GetLength(1); k++)
                {
                    sum += FirstMartrix[i,k] * SecomdMartrix[k,j];
                }
                ResM[i,j] = sum;
            }
        }
    }
}



Console.Write("Введите количество строк в каждой матрице: ");
int Lines = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в каждой матрице: ");
int Coloms = int.Parse(Console.ReadLine());
//if (Lines != Coloms) Console.WriteLine("Количество строк должно совпадать с количеством столбцов. Попробуйте еще раз!");
Console.Write("Введите значение начала интервала: ");
int beginline = int.Parse(Console.ReadLine());
Console.Write("Введите значение окончания интервала: ");
int endline = int.Parse(Console.ReadLine());

int[,] FirstMartrix = MyArray(Lines, Coloms, beginline, endline);
//Console.WriteLine($"\nПервая матрица:");
PrintArray(FirstMartrix);

Console.WriteLine();

int[,] SecomdMartrix = MyArray(Lines, Coloms, beginline, endline);
//Console.WriteLine($"\nВторая матрица:");
PrintArray(SecomdMartrix);

Console.WriteLine();

int[,] ResM = MyArray(Lines, Coloms, beginline, endline);

MultiplyMatrix(FirstMartrix, SecomdMartrix, ResM);
//Console.WriteLine($"\nПроизведение первой и второй матриц:");
PrintArray(ResM);

