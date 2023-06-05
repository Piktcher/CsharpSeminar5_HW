// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray (int elements_number)
{
    int[] array = new int[elements_number];
    for (int i = 0; i < elements_number; i++)
    {
        array[i] = new Random().Next(-10, 11);
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

int SumOddElements (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int sum_odd_elements = SumOddElements(arr);
Console.WriteLine($"Сумма элементов нечетных позиций массива равна {sum_odd_elements}");