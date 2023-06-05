// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray (int elements_number)
{
    int[] array = new int[elements_number];
    for (int i = 0; i < elements_number; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Укажите желаемое количество элементов массива - ");
int count = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(count);
PrintArray(arr);

int CountEven (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    
    return count;
}

int count_even = CountEven(arr);
Console.WriteLine($"Количество четных элементов массива равно {count_even}");