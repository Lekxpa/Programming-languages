// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
//между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76

//не получилось в числах сделать после запятой поменьше знаков

double[] MonArray (int size, double min, double max)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble()*10;  
    }
return res;
}
void MinMaxNumbers(Double[] array)
{
    Double mn =  array[0];
    Double mx =  array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < mn) mn = array[i];
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальное значение: {mn}");

    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > mx) mx = array[j];
    }
    Console.WriteLine();
    Console.WriteLine($"Максимальное значение: {mx}");

    Double result = mx - mn;
    
    Console.WriteLine();
    Console.WriteLine($"Разница между max и min эл-тами массива: {result}");
    Console.WriteLine();
}

Console.Write("Введите количество элементов в массиве: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите значение начала интервала: ");
Double beginline = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение окончания интервала: ");
Double endline = Convert.ToDouble(Console.ReadLine());

Double[] EvenArray = MonArray(number, beginline, endline);
Console.WriteLine(String.Join(" ", EvenArray));
MinMaxNumbers(EvenArray);