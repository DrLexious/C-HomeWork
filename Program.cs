//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
CreateRandomArray(array);
ShowArray(array);
int count = 0;
for (int i = 0; i < array.Length; i++) 
if(array[i] % 2 == 0)
count++;

Console.WriteLine($"Total {array.Length} numbers, {count} even numbers");
void CreateRandomArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
void ShowArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i]+",");
    Console.WriteLine();
}

//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
CreateRandomArray(array);
ShowArray(array);
int sum = 0;
for (int i = 0; i < array.Length; i+=2)
{
    sum += array[i];
}

Console.WriteLine($"Summary of numbers in not even index is: {sum}");
void CreateRandomArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(1,10);
    }
}
void ShowArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
        Console.Write(array[i]+",");
    Console.WriteLine();
}


//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Input a size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int[size];
CreateRandomArray(array);
ShowArray(array);
int min = Int32.MaxValue;
int max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}
Console.WriteLine();
Console.WriteLine($"Difference between maxValue and minValiue is: {max - min}");

void CreateRandomArray(int[] numbers)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(new Random().Next(1,100));
        }
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
}
