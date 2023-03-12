// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
Console.WriteLine("Размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

FillArray(numbers);
PrintArray(numbers);
Check(numbers);

void Check(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0)
            count++;
    Console.WriteLine($"введено {arr.Length} чисел, {count} чётные");
}

void FillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] arr)
{
    int cnt = 0;
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(i < arr.Length - 1 ? $"{arr[i]}, " : arr[i]);
        if (arr[i] % 2 == 0)
        {
            cnt++;
        }
    }
    Console.Write($"] -> {cnt}");
    Console.WriteLine();
}