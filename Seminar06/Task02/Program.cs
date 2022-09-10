// Задача 43: Напишите программу, которая найдёт точку 
//пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
    }
}


void PointOfIntersection (int[,] array)
{
//FirstLine SecondLine
    
    int x = (n2 - n1) / (m1 - m2);

    int y = m1 * (n2 - n1) / (m1 - m2) + n1;
    Console.Write($"{x}, {y}");
}

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int max = int.Parse(Console.ReadLine());

//Console.Write("Введите первое значение - k1: ");
//int k1 = int.Parse(Console.ReadLine());
//Console.Write("Введите второе значение - b1: ");
//int b1 = int.Parse(Console.ReadLine());
//Console.Write("Введите третье значение - k2: ");
//int k2 = int.Parse(Console.ReadLine());
//Console.Write("Введите четвертое значение - b2: ");
//int b2 = int.Parse(Console.ReadLine());

//int[,] EvenArray = PointOfIntersection[,];
//Console.WriteLine(String.Join(" ", EvenArray));
//CrossLine(EvenArray);

int[,] MonArray = MyArray(m, n, min, max);
PrintArray(MonArray);
PointOfIntersection(MonArray);