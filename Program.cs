// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("enter a first number");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter a second number");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA>numB)
{
    Console.WriteLine(numA+" - maximum");
    Console.WriteLine(numB+" - minimum");
}
else
{
    Console.WriteLine(numA+" - minimum");
    Console.WriteLine(numB+" - maximum");
}
