// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

PrintArray(FillArray(8));
int[] FillArray(int cnt)
{
    Random random = new Random();
    int[] arr = new int[cnt];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next();
    }
    return arr;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(i < arr.Length - 1 ? $"{arr[i]}, " : arr[i]);
    }
    Console.WriteLine();
}