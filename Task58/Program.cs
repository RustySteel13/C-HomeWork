// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] m1 = FillArr(3, 3, 1, 9), m2 = FillArr(3, 2, 1, 9);
PrintArray(m1);
Console.WriteLine("---");
PrintArray(m2);
Console.WriteLine("---");

if (Check(m1, m2))
{
    PrintArray(MatrixProduct(m1, m2));
}
else
{
    Console.WriteLine("Матрицы не согласованы");
}


int[,] FillArr(int m, int n, int min, int max)
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

bool Check(int[,] matrix1, int[,] matrix2)
{
    return (m1.GetLength(1) == m2.GetLength(0));
}

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
{
    int[,] arrTmp = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(1); k++)
            {
                arrTmp[i, k] += matrix1[i, j] * matrix2[j, k];
            }
        }
    }
    return arrTmp;
}