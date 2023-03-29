// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(m, n));

int Akkerman(int m, int n)
{
    return n == 0 ? m + 1 : ((n != 0) && (m == 0)) ? Akkerman(n - 1, 1) : Akkerman(n - 1, Akkerman(n - 1, m));
}