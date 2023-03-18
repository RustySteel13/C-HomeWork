// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количство столбцов массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
var arr = FillRndArray(m, n, 0, 10);
PrintArray(arr);

double[] colAvg = ColAverages(arr);
for (int i = 0; i < colAvg.Length; i++)
{
    Console.WriteLine(colAvg[i] + "; ");
}

double[] ColAverages(int[,] arr)
{
    double[] colAverages = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double avg = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            avg += arr[i,j];
        }
        colAverages[j] = Math.Round(avg / arr.GetLength(1), 1);
    }
    return colAverages;
}


int[,] FillRndArray(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
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