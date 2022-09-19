// Задача 60. ...Сформируйте трёхмерный массив из 
//неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы 
//каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int[,,] MyArray(int x, int y, int z, int min, int max)
{
    int[,,] result = new int[x,y,z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                result[i,j,k] = new Random().Next(min, max + 1);
            }
        }
    }
    return result;
}

void PrintArray (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ");
                Console.Write($"({i}, {j}, {k})\t");
            }
            Console.WriteLine();
        }
    }
}

void FillArray(int[,,] Array)
{
    int[] temp = new int[Array.GetLength(0) * Array.GetLength(1) * Array.GetLength(2)];
    int number = 0;
    int count = 0; 
    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = new Random().Next(0, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(0, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    for (int x = 0; x < Array.GetLength(0); x++)
    {
        for (int y = 0; y < Array.GetLength(1); y++)
        {
            for (int z = 0; z < Array.GetLength(2); z++)
            {
                Array[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

Console.WriteLine("Введите размер массива (k x m x n): ");
Console.Write("Введите k: ");
int k = int.Parse(Console.ReadLine());
Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

int[,,] MonArray = MyArray(k, m, n, 0, 100);
PrintArray(MonArray);
FillArray(MonArray);