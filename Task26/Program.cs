// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите натурально число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digitCount = DigitCount(number);
Console.WriteLine($"Количество цифр введенного числа : {number}, {digitCount}");
int DigitCount(int num)
{
    int i = 0;
    while (num > 0)
    {
        i++;
        num /= 10;
    }
    return i;
}