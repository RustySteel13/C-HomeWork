// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Write("Введите размер массива:");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];
FillArray(array);
PrintArray(array);
PrintArray(MultiplicationArrayElem(array));

void FillArray(int[] arrayValue)
{
    Random rnd = new Random();
    for (int i = 0; i < arrayValue.Length; i++)
    {
        arrayValue[i] = rnd.Next(1, 10);
    }
}

void PrintArray(int[] array_value)
{
    for (int i = 0; i < array_value.Length; i++)
    {
        if (i != array_value.Length - 1) Console.Write($"{array_value[i]}, ");
        else Console.Write($"{array_value[i]}\n");
    }
}

int[] MultiplicationArrayElem(int[] arrayValue)
{
    int newArraySize = arrayValue.Length % 2 == 0 ? arrayValue.Length / 2 : arrayValue.Length / 2 + 1;
    int[] newArray = new int[newArraySize];
    for (int i = 0; i <= arrayValue.Length; i++)
    {
        if (i == newArraySize - 1) 
        {
            if (arrayValue.Length % 2 == 0) 
                newArray[i] = array[i] * array[arrayValue.Length - 1 - i];
            else 
                newArray[i] = array[i];
            break;
        }
        newArray[i] = array[i] * array[arrayValue.Length - 1 - i];
    }
    return newArray;
}