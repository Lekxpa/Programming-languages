// Задача 36: Задайте одномерный массив, заполненный случайными 
//числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


double[] MonArray(double size, double min, double max)
{
    double[] res = new double[size];
    for (double i =0; i < size; i++)
        {
            res[i] = new Random().Next(min, max +1);
        }
    return res;
}

void ENNumbers(double[] array)
{
    double res = 0;

    for (double i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) res = res + array[i];
    }
  Console.WriteLine($"{res}");
}

Console.Write("Введите количество элементов в массиве: ");
double number = double.Parse(Console.ReadLine());
//double number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение начала интервала: ");
double beginline = double.Parse(Console.ReadLine());
//double beginline = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение окончания интервала: ");
double endline = double.Parse(Console.ReadLine());
//double endline = Convert.ToInt32(Console.ReadLine());

//Convert.ToInt32

double[] EvenArray = MonArray(number, beginline, endline);
Console.WriteLine(String.Join(" ", EvenArray));
ENNumbers(EvenArray);