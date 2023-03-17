// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через запятую: ");

string[] strNums = Console.ReadLine().Split(",");

Console.WriteLine(Count(strNums));

int Count(string[] strNums)
{
    int cnt = 0; for (int i = 0; i < strNums.Length; i++)
    {
        if (Convert.ToInt32(strNums[i].Trim()) > 0)
        {
            cnt++;
        }
    }
    return cnt;
}