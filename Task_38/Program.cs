// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double[] arr = new double[5]{3.22, 4.2, 1.15, 77.15, 65.2};

double[] FillArray (int elem_count, int minValue, int maxValue)
{
    double[] array = new double[elem_count];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * (maxValue - minValue) + minValue; // с таким условием можно задавать промежутки генерации вещ чисел, исх метод генерит только от 0 до 1
        array[i] = Math.Round(array[i], 2); // округляю значения массива до 2 знаков для повышения читабельности в терминале
    }
    return array;
}

void PrintArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Укажите желаемое количество элементов массива - ");
int count = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите минимальное значение эл-та массива - ");
int minimum = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите максимальное значение эл-та массива - ");
int maximum = Convert.ToInt32(Console.ReadLine());
double[] arr = FillArray(count, minimum, maximum);

PrintArray(arr);

double MaxMinDiff (double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    double result = Math.Round(max - min, 2);
    return result;
}

double diff = MaxMinDiff(arr);

Console.WriteLine($"Разница между максимальным и минимальным значениями массива равна {diff}");