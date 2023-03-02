// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool result = SomeMethod(number);
Console.WriteLine(result ? "Это палиндром" : "Это не палиндром");
bool SomeMethod(int n)
{
    int someint = n;
    int res = 0;
    while (n > 0)
    {
        res = res * 10 + n % 10;
        n /= 10;
    }
    return someint == res;
}