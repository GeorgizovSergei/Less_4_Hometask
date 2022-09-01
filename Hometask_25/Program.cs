// Задача 25: 
// Напишите цикл, который 
// 1. принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



int Degree(int numc, int degc)
{
    int res = 1;
    for (int i = 1; i <= degc; i++)
    {
        res = res * numc;
    }
    return res;
}
Console.Write("Введите число A: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите степень B: ");
int deg = Convert.ToInt32(Console.ReadLine());

int result = Degree(num, deg);
Console.WriteLine($"Результат возведения числа А = {num} в степень B = {deg} равен: {result}");
