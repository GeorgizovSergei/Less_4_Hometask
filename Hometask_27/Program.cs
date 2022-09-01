// Задача 27: 
// Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Summ(int numc)
{
    int res = 0;
    while (numc > 0)
    {
        int a = numc % 10;
        res = res + a;
        numc /= 10;
    }
    return res;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = Summ(num);

Console.Write($"Сумма цифр в числе равна {result}. ");