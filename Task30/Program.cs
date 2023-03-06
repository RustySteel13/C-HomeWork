// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]



int[] arr = Method(new int[8]);
Console.WriteLine(string.Join(",", arr));
int[] Method(int[] arr)
{
    Random rndm = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rndm.Next(0, 2);
    }
    return arr;
}
