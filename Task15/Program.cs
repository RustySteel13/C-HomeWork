// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1)
{
    Console.Write("нет");
}
else if (day == 2)
{
    Console.Write("нет");
}
else if (day == 3)
{
    Console.Write("нет");
}
else if (day == 4)
{
    Console.Write("нет");
}
else if (day == 5)
{
    Console.Write("нет");
}
else if (day == 6)
{
    Console.Write("да");
}
else if (day == 7)
{
    Console.Write("да");
}
else
Console.WriteLine("Введено не корректное число");
