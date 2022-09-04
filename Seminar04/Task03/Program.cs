// Задача 29: Напишите программу, которая задаёт массив 
//из N элементов, заполненных случайными числами из [a, b) и 
//выводит их на экран.
// 5, 0, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 35 -> [6, 1, 33]

int[] IArray(int num, int begl, int endl)
{
    int[] arr = new int[num];

    for(int i=0; i < num; i++)
    {
        arr[i] = new Random().Next(begl, endl); //тк в условиях b) +1 не делаю
    }
    return arr;
}


Console.Write("Введите количество элементов в массиве: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите значение начала интервала: ");
int beginline = int.Parse(Console.ReadLine());
Console.Write("Введите значение окончания интервала: ");
int endline = int.Parse(Console.ReadLine());

int[] myArray = IArray(number, beginline, endline);
Console.Write(String.Join(", ", myArray));
