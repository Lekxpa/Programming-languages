// Задача 62. Напишите программу, которая заполнит спирально 
//массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

int[,] SpiralArray(int m, int n, int min, int max)
{
    int[,] result = new int[m,n];
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= result.GetLength(0) * result.GetLength(1))
    {
        result[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < result.GetLength(1) - 1) j++;
        else if (i < j && i + j >= result.GetLength(0) - 1) i++;
        else if (i >= j && i + j > result.GetLength(1) - 1) j--;
        else i--;
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int cols = 0; cols < array.GetLength(1); cols++)
        {
            if (array[rows,cols] < 10)
            Console.Write($"0{array[rows,cols]}  ");
            else Console.Write($"{array[rows,cols]}  ");
        }
        Console.WriteLine();
    }
}

int[,] MonArray = SpiralArray(4, 4, 1, 16);
PrintArray(MonArray);