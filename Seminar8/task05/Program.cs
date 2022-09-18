// Задача 62. Напишите программу, которая заполнит спирально 
//массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

//Console.Clear();
//Console.WriteLine($"Задача 62: Заполните спирально массив 4 на 4.");

//void SpiralArray (int[,] array)
int[,] SpiralArray(int[,] array)
{
    //Console.Write("Введите количество строк и столбцов в массиве: ");
    //int numLineAndCols = int.Parse(Console.ReadLine());
    //int[,] MyArray = new int[int m, int n, int min, int max];


    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
        i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
        j--;
        else
        i--;
    }
    return array; //MyArray;
}

//WriteArray(sqareMatrix);

//void WriteArray (int[,] array)
//{
//  for (int i = 0; i < array.GetLength(0); i++)
//  {
//    for (int j = 0; j < array.GetLength(1); j++)
 //   {
 //     if (array[i,j]  < 10)
 //     Console.Write($" {array[i,j]}  ");

  //    else Console.Write($"{array[i,j]}  ");
  //  }
  //  Console.WriteLine();
 // }
//}

void PrintArray(int[,] array)
{
    for (int rows = 0; rows < array.GetLength(0); rows++)
    {
        for (int cols = 0; cols < array.GetLength(1); cols++)
        {
            if (array[rows,cols]  < 10)
            Console.Write($" {array[rows,cols]}  ");
            else Console.Write($"{array[rows,cols]}  ");
        }
    }
}


  Console.Write("Введите количество строк и столбцов в массиве: ");
    int numLineAndCols = int.Parse(Console.ReadLine());
    int numbers = numLineAndCols * numLineAndCols;
    int[,] MyArray = SpiralArray(numLineAndCols, numLineAndCols, 1, numbers);
//Console.Write("Введите количество строк и столбцов в массиве: ");
//int numLineAndCols = int.Parse(Console.ReadLine());

int[,] MonArray = SpiralArray(4, 4, 1, 16);
PrintArray(MyArray);
//OrderOfElementsOfArray(MonArray);
