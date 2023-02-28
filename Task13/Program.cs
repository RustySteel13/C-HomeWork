// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
SomeMethod(Convert.ToInt32(Console.ReadLine())); 
        void SomeMethod(int num) 
        { 
            if (num < 100) 
            { 
                Console.WriteLine("Третьей цифры нет"); 
            } 
            else if (num < 1000) 
            { 
                Console.WriteLine(num % 10); 
            } 
            else 
            { 
                int i = 10; 
                while (true) 
                { 
                    if (num / i < 1000) 
                    { 
                        Console.WriteLine(num / i % 10); 
                        break; 
                    } 
                    else 
                    { 
                        i *= 10; 
                    } 
                } 
            } 
        }

//Или :)


//Console.WriteLine(Console.ReadLine()[2]);