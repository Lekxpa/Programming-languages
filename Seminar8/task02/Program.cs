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
    int minSumLine = 0;
    int[,] res = new int[Array.GetLength(0),Array.GetLength(1)];
    int sumLine = res[0, 0];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
    //    int res = 0;

    //int temp = res;
       // int[,] res = new int[Array.GetLength(0),Array.GetLength(1)];
  

        for (int j = 0; j < Array.GetLength(1); j++)
        {
        int tempSumLine = res[0, j];
         if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            minSumLine = i;
        }
            Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");
    }
       // {
       //     res = res + Array[i, j];
                 //if (temp > res) temp = res;  
       // }
        //Console.WriteLine();
       // Console.WriteLine(res    );

    //}
     
      //Console.Write("Введите {0}-й элемент: " ,  i + 1);
      
}

//void SumOfElemOfRow (int[,] Array)
//{
    //int[,] res = new int[Array.GetLength(0),Array.GetLength(1)];
//int minSumLine = 0;
//int sumLine = res[Array, 0];
//for (int i = 1; i < Array.GetLength(0); i++)
//{
 // int tempSumLine = res[Array, i];
 // if (sumLine > tempSumLine)
 // {
  //  sumLine = tempSumLine;
  //  minSumLine = i;
  //}
 //Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");
//}

//Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");
//}

int[,] SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
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
SumLineElements(MonArray);