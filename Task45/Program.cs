// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] array = new int[10];

FillArray(array);
Console.WriteLine("Ваш массив: ");
PrintArray(array);
Console.WriteLine("Скопированный поэлементно : ");
PrintArray(CopyArray(array));

void FillArray(int[] arrayValue)
{
    Random rnd = new Random();
    for (int i = 0; i < arrayValue.Length; i++)
    {
        arrayValue[i] = rnd.Next(1, 10);
    }
}

void PrintArray(int[] array_value)
{
    for (int i = 0; i < array_value.Length; i++)
    {
        if (i != array_value.Length - 1) Console.Write($"{array_value[i]}, ");
        else Console.Write($"{array_value[i]}\n");
    }
}

int[] CopyArray(int[] arr)
{
    int[] copyArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArr[i] = arr[i];
    }
    return copyArr;
}