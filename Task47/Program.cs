// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите переменную m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите переменную n: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintArray(FillArray(m, n, -10, 10));

double[,] FillArray(int m, int n, int min, int max)
{
    Random random = new Random();
    var arr = new double[m,n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = Math.Round(random.NextDouble() * (min - max) + min, 1);
        }
    }
    return arr;
} 

void PrintArray(double[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}