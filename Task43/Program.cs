// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = GetValue("b1"), k1 = GetValue("k1"), b2 = GetValue("b2"), k2 = GetValue("k2"); double x = GetX(b1, k1, b2, k2), y = GetY(x, b2, k2);
Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}; Y: {y}"); double GetX(double b1, double k1, double b2, double k2)
{
    return (-b2 + b1) / (-k1 + k2);
}
double GetY(double x, double b2, double k2)
{
    return k2 * x + b2;
}
double GetValue(string name)
{
    Console.Write($"Введите {(name.Contains("k") ? "число" : "значение")} {name}: ");
    return Convert.ToDouble(Console.ReadLine());
}