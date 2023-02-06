/*//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Write($"Enter a positive number: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
if (n < 1)
{
    Console.WriteLine("Enter a non-positive number");
}

Console.WriteLine(PositiveNumber(n, m));

int PositiveNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{PositiveNumber(n, m + 1)}, ");
    return m;
}
*/

/*//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write($"Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Summary of elements from {m} to {n} = {SumElements(m, n)}");

int SumElements(int m, int n)
{
    if (m == n)
        return n;
    return n + SumElements(m, n - 1);
}
*/

/*//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Enter 2 positive numbers: ");
Console.Write($"Enter number M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter number N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}
*/
