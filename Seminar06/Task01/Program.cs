// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3



Console.Write("Укажите количество чисел: ");
int count = int.Parse(Console.ReadLine());


int[] array = new int[count];
for(int i = 0; i < count; i++)
{
    Console.Write("Введите {0}-й элемент: " ,  i + 1);
    array[i] = int.Parse(Console.ReadLine());
}
int result = 0;
for (int i = 0; i < array.Length; i++) 
if (array[i] > 0) result++;  
Console.WriteLine($"Количество положительных чисел = {result}");