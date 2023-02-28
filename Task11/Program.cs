// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int result = firstDigit * 10 + thirdDigit;
// Console.WriteLine($"результат -> {result}");

int numbers = new Random().Next(100, 1000);
Console.WriteLine($"Случайное  трехзначное число -> {numbers}");

int delSecondDigit(int num)
{    
    int firstDigit = num / 100;
    int lastDigit = num % 10;    
    int sumD = firstDigit * 10 + lastDigit;    
    return sumD;
}
int sumDigit = delSecondDigit(numbers); 
Console.WriteLine($"Полученное двухзначное число -> {delSecondDigit}");