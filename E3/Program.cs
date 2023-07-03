// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (можно указать любой промежуток)
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int size = 8;
int[] array = GetArray(size);
Console.WriteLine($"Исходный массив : [{String.Join(", ", array)}]");

// Функция заполнения массива
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите элемент массива № {i+1} : ");
        result[i] = int.Parse(Console.ReadLine())!;
    }
    return result;
}

// Второй вариант решения:

Console.WriteLine("Введите размер  массива : ");
int size2 = int.Parse(Console.ReadLine())!;
int[] array2 = GetArray2(size2);
Console.WriteLine($"Исходный массив : [{String.Join(", ", array2)}]");

// Функция заполнения массива
int[] GetArray2(int size2)
{
    int[] result = new int[size2];
    for (int i = 0; i < size2; i++)
    {
        result[i] = new Random().Next(-200, 200);
    }
    return result;
}


