/*//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Enter a number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter exponent: ");
int b = Convert.ToInt32(Console.ReadLine());
int exp = a;
for (int i = 1; i < b; i++)
    exp = exp * a;
Console.WriteLine($"{a} ^ {b} = {exp}");
*/

/*//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Enter a number: ");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (i > 0)
{
    int num = i % 10;
    i = i / 10;
    sum = sum + num;
}
Console.WriteLine("Summary of numbers is: " +sum);
*/

/*//Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i<size; i++)
    {
        Console.Write($"Enter a {i+1} element of array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i]+"");
    Console.WriteLine();
}
Console.Write("Input a lenght of array: ");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateArray(lenght);
ShowArray(newArray);
*/
