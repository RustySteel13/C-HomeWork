// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.WriteLine("Введите десятичное число: ");
int num10 = Convert.ToInt32(Console.ReadLine());

int num2 = ToBinary(num10);

Console.WriteLine(num2);

int ToBinary(int num)
{
    return num < 2 ? num % 2 : (num % 2) + 10 * ToBinary(num / 2);
}