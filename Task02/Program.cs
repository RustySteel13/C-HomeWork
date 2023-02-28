/// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. 

Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());
int min, max;
if (a > b)
{
    min = b;
    max = a;
}
else if (b > a)
{
    min = a;
    max = b;
}
else
{
    Console.WriteLine("a=b");
    return;
}

Console.WriteLine($"min = {min}; max = {max}");
