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

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите  число до 10 знаков: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Длина числа  {number} итог = {getLength(number)}");

Console.WriteLine($"Сумма цифр в введенном вами числе {number} = {getSumm(number, getLength(number))}");

// вычисляем сумму цифр
int getSumm(int chislo, int dlina)
{
   
   int ostatok = chislo%10;
   int k = chislo / 10;
   int result = ostatok;
   //Console.WriteLine($"До цикла сумма  = { result }; число K = { k }; остаток сейчас = { ostatok }");
   for ( int i = 1; i < dlina;  i++)
  { 
    ostatok = k % 10;
    k = k / 10;
    
     result += ostatok;
    //Console.WriteLine($"Сумма сейчас  = { result }; число K = { k }; остаток сейчас = { ostatok }");
  }
    return result;
}

// определяем длину числа
int getLength(int n)
{
    int res = 1;
    int k = n / 10;
    //Console.WriteLine($"Длина числа сейчас = { res }, к= { k }");
    while ( k > 0)
    {
        res += 1;
        k = k / 10;
        //Console.WriteLine($"Длина числа внутри цикла сейчас = { res }, к = { k }");
    }
    return res;
}