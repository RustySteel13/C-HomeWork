// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int numberA = Input("Введите целое положительное число A: ");
int numberB = Input("Введите целое положительное число B: ");

int multi = MultiNumbers(numberA, numberB);
Console.Write(multi);

int MultiNumbers(int a, int b)
 {
     if (b == 0) return 1;
     else return checked (a * MultiNumbers(a, b - 1));
 }

 int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
