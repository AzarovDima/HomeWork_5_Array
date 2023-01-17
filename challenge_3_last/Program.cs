/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
 */

Console.Write("Дан массив... ");

int[] array = GetRandomArray(8, 1, 30);
int max = GetMaxNumber(array);

Console.WriteLine($"[{String.Join(", ", array)}]");
Console.Write("Максимальное число в массиве - ");
Console.WriteLine(max);

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rnd.Next(minValue, maxValue);
    }

    return result;
}

int GetMaxNumber(int[] array)
{
    int maxNumber = 0;
    int i = 0;
    int lenght = array.Length;
    while (i < lenght)
    {
        if (array[i] > maxNumber) maxNumber = array[i];
        i++;
    }
    return maxNumber;
}