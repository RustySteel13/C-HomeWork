// // Задача 20: Напишите программу, которая
// // принимает на вход координаты двух точек и
// // находит расстояние между ними в 2D
// // пространстве.
// // A (6); B (2,1) -> 5,09
// // A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты x первой точки");
int coordinateAx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y первой точки");
int coordinateAy = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты x второй точки");
int coordinateBx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты y второй точки");
int coordinateBy = Convert.ToInt32(Console.ReadLine());

double pyphagor = Pyphgor(coordinateAx,coordinateAy,coordinateBx,coordinateBy);
double result = Math.Round(pyphagor, 2, MidpointRounding.ToZero);
Console.WriteLine(result);


double Pyphgor(int ax, int ay, int bx, int by)
{
   return Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));  
}