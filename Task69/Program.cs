// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int number = Input("Введите целое положительное число: ");

int num = SumNumbersDigits(number);
Console.Write(num);

int SumNumbersDigits(int n)
 {
     if (n == 0) return 0;
     else return n % 10 + SumNumbersDigits(n / 10);
 }

 int Input(string text);