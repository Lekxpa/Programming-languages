//Задача 25: Напишите цикл, который принимает на вход 
//два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int GetNums(int num1, int num2)
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result * num1;
    }
    return result;
}

Console.WriteLine("Напишите число А: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите число B: ");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine(num1);