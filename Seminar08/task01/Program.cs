// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки 
//двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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

void OrderOfElementsOfArray(int[,] Array)
{
    int[,] OrderArray = new int[Array.GetLength(0),Array.GetLength(1)];
    int temp = 0;  //Array[Array.GetLength(0), Array.GetLength(1)];
    //for (int i = 0; i < Array.GetLength(0); i++)
   // {
   //     for (int k = i + 1; k < Array.GetLength(0); k++)
    //    {
    //        for (int j = 0; j < Array.GetLength(1); j++)
    //        {
     //            while (Array[i,j] < Array[k,j])
     //           {
     //               temp = Array[i,j];
      //              Array[i,j] = Array[k,j];
      //              Array[k,j] = temp;
       //         }
       //         Console.Write($"{temp}");               
       //      } 
       // }
    //}
//}

    
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                    {
                        for (int k = 0; k < Array.GetLength(0); k++)
                            {
                            for (int m = 0; m < Array.GetLength(1); m++)
                                    {
                                if (((i!=k)&&(j!=m))&&(a[i,j] > a[k,m]))
                                            {
                                                int t = a[i,j];
                                                a[i,j] = a[k,m];
                                                a[k,m] = t;
                                            }
                                     }
 
                            }
                    }
            }
        }

//void PrintOrderOfElementsOfArray(int[,] Arr)
//{
  //  for (int i = 0; i < Arr.Length; i++)
    //{
      //  for (int j = 0; j < Arr.GetLength(1); j++)
       // {
         //   Console.Write(Arr[i,j]);
        //}
    //}
//}

Console.Write("Введите количество строк в массиве: ");
int lines = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int[,] MonArray = MyArray(lines, columns, -100, 100);
PrintArray(MonArray);
OrderOfElementsOfArray(MonArray);
//PrintOrderOfElementsOfArray(MonArray);