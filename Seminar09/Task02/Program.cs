//Задача 68: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9

int FunctionOfAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FunctionOfAkkerman(m - 1, 1);
    else return FunctionOfAkkerman(m - 1, FunctionOfAkkerman(m, n - 1));
}

Console.Write("Введите число m: ");
int NumM = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int NumN = int.Parse(Console.ReadLine());

Console.WriteLine();
if (NumM < 0 || NumN < 0)  Console.WriteLine($"Можно использовать только положительные числа. Попробуйте еще раз!");
else Console.Write($"Функция Аккермана: {FunctionOfAkkerman(NumM, NumN)}");
Console.WriteLine();  // для красоты