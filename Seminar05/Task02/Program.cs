// Задача 36: Задайте одномерный массив, заполненный случайными 
//числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int[] MonArray(int size, int min, int max)
{
    int[] res = new int[size];
    for (int i =0; i < size; i++)
        {
            res[i] = new Random().Next(min, max +1);
        }
    return res;
}

void ENNumbers(int[] array)
{
    int res = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) res = res + array[i];
    }
  Console.WriteLine($"{res}");
}

Console.Write("Введите количество элементов в массиве: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите значение начала интервала: ");
int beginline = int.Parse(Console.ReadLine());
Console.Write("Введите значение окончания интервала: ");
int endline = int.Parse(Console.ReadLine());

int[] EvenArray = MonArray(number, beginline, endline);
Console.WriteLine(String.Join(" ", EvenArray));
ENNumbers(EvenArray);