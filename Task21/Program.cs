// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты x первой точки");
int coordinateAx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y первой точки");
int coordinateAy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты x второй точки");
int coordinateAz = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y второй точки");
int coordinateBx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y второй точки");
int coordinateBy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y второй точки");
int coordinateBz = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Расстояние равно : {Math.Round(GetAB(coordinateAx, coordinateAy, coordinateAz, coordinateBx, coordinateBy, coordinateBz),2 , MidpointRounding.ToZero)}");

double GetAB(int ax, int ay, int az, int bx, int by, int bz)
{
    return Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
}