/*// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
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
*/
/*//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("enter a first number");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter a second number");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter a third number");
int numC = Convert.ToInt32(Console.ReadLine());
int numMax = 0;
if(numA>numB)
{
    numMax = numA; 
}
else
{
    numMax = numB;
}
if(numMax>numC)
{
    Console.WriteLine(numMax);
}
else
{
    Console.WriteLine(numC);
}
*/
/*// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("enter a number ");
int num = Convert.ToInt32(Console.ReadLine());
if(num%2==0) Console.WriteLine("Чётное");
else Console.WriteLine("нечётное!");
*/
/*// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("enter a number ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 2;
if(num<=2) Console.Write("Does not contain even numbers");
else 
while(current <= num)
{
    Console.Write(current + " ");
    current = current + 2;
}
*/