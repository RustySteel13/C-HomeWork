// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] array = FillRndArray(4, 4, 1, 9);
PrintArray(array);
Console.WriteLine($"Номер строки с наиментшей суммой элементов : {MinRowIndex(array) + 1}");

int[,] FillRndArray(int m, int n, int min, int max)
{
    Random random = new Random();

    int[,] arr = new int[m, n];
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(min, max + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

int MinRowIndex(int[,] arr)
{
    int[] arrTmp = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            arrTmp[i] += arr[i, j];
        }
    }
    int min = 0;
    for (int i = 0; i < arrTmp.Length; i++)
    {
        if (arrTmp[min] > arrTmp[i])
        {
            min = i;
        }
    }
    return min;
}