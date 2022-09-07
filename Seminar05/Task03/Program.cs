// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
//между максимальным и минимальным элементом массива.
// [3 7 22 2 78] -> 76


int[] MonArray(int size, int min, int max)
{
    int[] res = new int[size];
    for (int i =0; i < size; i++)
        {
            res[i] = new Random().Next(min, max +1);
        }
    return res;
}

void MinNumbers(int[] array)
{
    int mn =  array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < mn) mn = array[i];
    }
  Console.WriteLine($"Минимальное значение: {mn}");
}

void MaxNumbers(int[] array)
{
    int mx =  array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > mx) mx = array[i];
    }
    //return mx;
  Console.WriteLine($"Максимальное значение: {mx}");
}

//int result = MaxNumbers - MinNumbers;
//Console.WriteLine(result);

Console.Write("Введите количество элементов в массиве: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите значение начала интервала: ");
int beginline = int.Parse(Console.ReadLine());
Console.Write("Введите значение окончания интервала: ");
int endline = int.Parse(Console.ReadLine());

int[] EvenArray = MonArray(number, beginline, endline);
Console.WriteLine(String.Join(" ", EvenArray));
MinNumbers(EvenArray);
MaxNumbers(EvenArray);

//int res1 = MinNumbers(EvenArray);

//int result = mx - mn;
//Console.WriteLine(res1);