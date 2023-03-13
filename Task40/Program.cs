// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите число a: ");
int ab = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int bc = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int ac = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Check(ab, bc, ac) ? "может" : "Не может");

bool Check(int ab, int bc, int ac)
{
   return ab < bc + ac && bc < ab + ac && ac < ab + bc;
}