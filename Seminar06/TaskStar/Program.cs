// Задача со звездочкой. Напишите программу, которая реализует обход
// введенного двумерного массива, начиная с крайнего нижнего левого
// элемента против часовой стрелки


int[,] MyArray(int m, int n, int min, int max)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(0, 2);
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
            Console.Write($"{array[rows,cols]} ");
        }
        Console.WriteLine();
    }
}

int FillImage (int[,] Fillarray)
{
    int step = Fillarray[Fillarray.GetLength(0),0];
    for (int row = Fillarray.GetLength(0); row < Fillarray.GetLength(0); row--)
    {
        for (int col = 0; col < Fillarray.GetLength(1); col++)
        {
            if (step == 0)
            {
                step = 1;
                step = Fillarray[row - 1, col];
            }
            if (step == 0)
            {
                step = 1;
                step = Fillarray[row, col-1];
            }
                if (step == 0)
            {
                step = 1;
                step = Fillarray[row + 1, col];
            }
            if (step == 0)
            {
                step = 1;
                step = Fillarray[row, col + 1];
            }
            Console.Write($"{Fillarray[row,col]} ");
        }
    }
    return step;
}

//void FillImage (int row, int col)
//{
   // if(MyArray[row, col] = 0)
    //{
     //   MyArray[row, col] = 1;
      //  FillImage(row-1, col); // шаг влево
      //  FillImage(row, col-1); // шаг вниз
       // FillImage(row+1, col); // шаг вправо
       // FillImage(row, col+1); // шаг вверх
   // }
//}

Console.Write("Введите количество строк: ");
int numrows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int numcols = int.Parse(Console.ReadLine());

int[,] MonArray = MyArray(numrows, numcols, 0, 2);
PrintArray(MonArray);
FillImage(MonArray);
Console.WriteLine();
PrintArray(MonArray);
