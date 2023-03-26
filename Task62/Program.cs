// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
PrintArray(FillArr(4));

int[,] FillArr(int n)
{
    int[,] arr = new int [n, n];
    int i = 0, j = 0;
    int value = 1;
    while (n != 0)
    {
        int f = 0;
        do
        {
            arr[i, j++] = value++;
        }
        while(++f < n - 1);
        for (int k = 0; k < n - 1; k++)
        {
            arr[i++, j] = value++;
        }
        for (int k = 0; k < n - 1; k++)
        {
            arr[i, j--] = value++;
        }
        for (int k = 0; k < n - 1; k++)
        {
            arr[i--, j] = value++;
        }
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
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