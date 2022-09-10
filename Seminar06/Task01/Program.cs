// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3


int PositiveNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;  
    }
    return result;
}

Console.Write("Укажите количество чисел: ");
int number = int.Parse(Console.ReadLine());

int[] FillArray = new int[number];
for(int i = 0; i < number; i++)
    {
        Console.Write("Введите {0}-й элемент: " ,  i + 1);
        FillArray[i] = int.Parse(Console.ReadLine());
    }

int count = PositiveNumbers(FillArray);
Console.WriteLine($"Количество положительных чисел = {count}");