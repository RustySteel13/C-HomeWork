// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array = FillRndArray(4, 4, 1, 9);
PrintArray(array);
array = BubbleSortDesc(array);
Console.WriteLine();
PrintArray(array);

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

int[,] BubbleSortDesc(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = j + 1, tmp; k < arr.GetLength(1); k++)
            {
                if (arr[i, j] < arr[i, k])
                {
                    tmp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = tmp;
                }
            }
        }
    }
    return arr;
}