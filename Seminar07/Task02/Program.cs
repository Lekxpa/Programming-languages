// Задача 50. Напишите программу, которая на вход 
//принимает число и генерирует случайный двумерный массив, 
//и возвращает индексы этого элемента или же указание, что такого 
//элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

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

void SearchNumber(int[,] Array)
{
    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    {
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                if(num == Array[i,j])
                {  
                    Console.WriteLine($"Индексы заданного числа: ({i}, {j}) ");
                    return;
                    break;
                }
             } 
        }
    }
    Console.WriteLine("Такого числа в массиве нет"); 
}
    
Console.Write("Введите количество строк в массиве: ");
int lines = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int[,] MonArray = MyArray(lines, columns, -100, 100);
PrintArray(MonArray);
SearchNumber(MonArray);