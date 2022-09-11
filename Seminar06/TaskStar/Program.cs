// Задача со звездочкой. Напишите программу, которая реализует обход
// введенного двумерного массива, начиная с крайнего нижнего левого
// элемента против часовой стрелки


//int[,] MyArray(int m, int n, int min, int max)
int[,] MyArray()
{
    int[,] result = new int[,];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(0, 0);
        }
    }
    return result;
}

void PrintImage(int[,] image)
{
    for (int i = 0; i < image.GetLength(0); i ++)
{
    for (int j = 0; j < image.GetLength(1); j ++)
    {
        if (image[i, j] == 0) Console.Write($" ");
        else Console.Write($"+");
    }
    
    Console.WriteLine();
}

}

// закрашиваем область внутри знаков

void FillImage (int row, int col)
{
   // int row = MArray.GetLength(0);
    //int col = 0;
    if(MyArray[row, col] == 0)
    {
        MyArray[row, col] = 1;
        FillImage(row-1, col); // шаг влево
        FillImage(row, col-1); // шак вниз
        FillImage(row+1, col); // шаг вправо
        FillImage(row, col+1); // шак вверх
    }
}

Console.Write("Введите количество строк: ");
int numrows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int numcols = int.Parse(Console.ReadLine());

//Console.Write("Введите минимальное значение: ");
//int minEl = int.Parse(Console.ReadLine());

//Console.Write("Введите максимальное значение: ");
//int maxEl = int.Parse(Console.ReadLine());

int[,] MonArray = MyArray(numrows, numcols, 0, 1);
PrintImage(MonArray);
FillImage (MonArray.GetLength(0), 0);
PrintImage(MonArray);