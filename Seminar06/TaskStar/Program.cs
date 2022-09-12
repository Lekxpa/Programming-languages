// Задача со звездочкой. Напишите программу, которая реализует обход
// введенного двумерного массива, начиная с крайнего нижнего левого
// элемента против часовой стрелки

//не получилось)

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
            Console.Write($"{array[rows,cols]} ");
        }
        Console.WriteLine();
    }
}

void FillImage (int[,] Fillarray)

{
    int step = Fillarray[Fillarray.GetLength(0),0]; 
    for (int row = Fillarray.GetLength(0); row < Fillarray.GetLength(0); row--)
    {
        for (int col = 0; col < Fillarray.GetLength(1); col++)
        {
            Console.Write($"{step} ");
            step = Fillarray[row - 1, col];
            Console.Write($"{step} ");
            step = Fillarray[row, col-1];
            Console.Write($"{step} ");
            step = Fillarray[row + 1, col];
            Console.Write($"{step} ");
            step = Fillarray[row, col + 1];
            Console.Write($"{step} ");
        }
    }
}

Console.Write("Введите количество строк: ");
int numrows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int numcols = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение элемента: ");
int minEl = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение элемента: ");
int maxEl = int.Parse(Console.ReadLine());

int[,] MonArray = MyArray(numrows, numcols, minEl, maxEl);
PrintArray(MonArray);
FillImage(MonArray);
Console.WriteLine();
PrintArray(MonArray);
