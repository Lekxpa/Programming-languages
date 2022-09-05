// Задача 34: Задайте массив, заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] MyArray(int size, int min, int max)
{
    int[] res = new int[size];
    for (int i =0; i < size; i++)
    {
        res[i] = new Random().Next(min, max +1);
    }
    return res;
}

void EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count ++;
    }
  Console.WriteLine($"{count}");
}

Console.Write("Введите количество элементов в массиве: ");
int number = int.Parse(Console.ReadLine());

int[] EvenArray = MyArray(number, 100, 1000);
Console.WriteLine(String.Join(" ", EvenArray));
EvenNumbers(EvenArray);