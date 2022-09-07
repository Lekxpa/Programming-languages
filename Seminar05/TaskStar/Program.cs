// Задача "со звездочкой": Разобраться с алгоритмом сортировки 
//методом пузырька. Реализовать невозрастающую сторировку.
//[3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
//[1,2,2,3,2] -> [3, 2, 2, 2, 1]

int[] MonArray(int size, int min, int max)
{
    int[] res = new int[size];
    for (int i =0; i < size; i++)
        {
            res[i] = new Random().Next(min, max +1);
        }
    return res;
}

void SortBall(int[] array)
{
    int temp = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            while (array[i] < array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }                   
        }            
   }
}

void PrintSortBall(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{1} ", i, array[i]);
    }
}

Console.Write("Введите количество элементов в массиве: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите значение начала интервала: ");
int beginline = int.Parse(Console.ReadLine());
Console.Write("Введите значение окончания интервала: ");
int endline = int.Parse(Console.ReadLine());

int[] EvenArray = MonArray(number, beginline, endline);
Console.WriteLine(String.Join(" ", EvenArray));
SortBall(EvenArray);
PrintSortBall(EvenArray);
