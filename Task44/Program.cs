// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите количествно выводимых чисел Фибоначчи: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(string.Join(" ", Fib(n)));


int[] Fib(int n)
{
    int[] arr = new int[n];
    arr[0] = 0; arr[1] = 1;
    for (int i = 2; i < arr.Length; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }
    return arr;
}