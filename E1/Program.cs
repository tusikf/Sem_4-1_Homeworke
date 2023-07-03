// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {number1} в степени числа {number2} = {getStepen(number1,number2)}");

int getStepen(int chislo, int stepen)
{
    int result = 1;
    for (int i = 1; i <= stepen; i++)
    {
        result *= chislo;
    }
    return result;
}