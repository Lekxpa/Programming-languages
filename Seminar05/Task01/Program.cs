// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] MyArray(int size, int min, int max)
{
int[] res = new int[size];
//int count = 0;
for (int i =0; i < size; i++)
{
    res[i] = new Random().Next(min, max +1);
  
    //if (res[i] % 2 == 0) count++;
}
//Console.WriteLine($"{count}");
return res;
}

int[] EvenNumbers(int[] array)

//void EvenNumbers(int[] array)
{
   int count = 0;
    //foreach(int m in array)
    for (int i = 0; i < array.Length; i++)
    {
        //count += m % 2  == 0 ? 1 : 0;
        if (array[i] % 2 == 0)  count++;
    }
    Console.WriteLine($"{count}");
    return array;
}

Console.Write("Введите количество элементов в массиве: ");
int number = int.Parse(Console.ReadLine());

int[] EvenArray = MyArray(number, 100, 1000);
int[] result = EvenNumbers(EvenArray);
Console.WriteLine(String.Join(" ", EvenArray));
//Console.WriteLine(String.Join(" ", result));
//EvenNumbers(EvenArray);
//Console.WriteLine($"{count}");
