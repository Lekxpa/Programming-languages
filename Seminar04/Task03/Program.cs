// Задача 29: Напишите программу, которая задаёт массив 
//из N элементов, заполненных случайнми числами из [a, b) и 
//выводит их на экран.
// 5, 0, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 35 -> [6, 1, 33]

int[] InitArray(int num)
{
    int[] arr = new int[num];
    for(int i=0; i < num; i++)
    {
        arr[i] = new Random().Next(beginline, endline);
    }
    return arr;
}

void ReadArray(int[] arr)
{
    for(int i=0; i < num; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

Console.Write("Введите количество элементов в массиве: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите значение начала промежутка: ");
int beginline = int.Parse(Console.ReadLine());
Console.Write("Введите значение окончания промежутка: ");
int endline = int.Parse(Console.ReadLine());

ReadArray(InitArray());