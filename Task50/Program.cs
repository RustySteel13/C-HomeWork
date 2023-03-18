// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количство столбцов массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
var arr = FillRndArray(m, n, -10, 10);
PrintArray(arr);

Console.WriteLine("Введите введите позицию по горизонтали: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите введите позицию по вертикали: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetElem(arr,row,col));

string GetElem(int[,] arr,int row, int col)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        // Проверяем есть ли такая строка сразу, что бы просто так не запускать второй цикл.
        if(i + 1 == row)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if(j + 1 == col)
                {
                    return arr[i,j].ToString();
                }
            }
        }
    }
    return "Такого числа в массиве нет";
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