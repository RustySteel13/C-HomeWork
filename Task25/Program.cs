// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите натуральное число A: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int exponent = Exponent(firstNumber, secondNumber);
Console.WriteLine(exponent);

int Exponent(int a, int b)
{
    int exp = (int)Math. Pow(a, b);
    return exp;
}
