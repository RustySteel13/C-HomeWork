// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = Method(num);
Console.WriteLine($"Произведение чисел от 1 до {num} = {count}");
int Method(int num)
{
    int tmp = 1;
    for (int i = 1; i <= num; i++)
    {
        tmp *= i;
    }
    return tmp;
}