/*//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandom2DArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[rows,colums];
    for(int i=0; i<rows; i++)
        for(int j=0; j<colums; j++)
            array[i,j] = Convert.ToDouble(new Random().Next(minValue,maxValue+1))/10;
    return array;
}
void Show2DArray(double[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+"\t");
        Console.WriteLine();
    }
}
double[,] newArray = CreateRandom2DArray();
Show2DArray(newArray);
*/

/*//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Enter number of row: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number of column: ");
int m = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [10,10];
CreateRandom2DArray(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("No such element");
}
else
{
    Console.WriteLine($"Element of {n} row & {m} column equal {numbers[n-1,m-1]}");
}

Show2DArray(numbers);

void CreateRandom2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)       
            for (int j = 0; j < array.GetLength(1); j++)
                array [i,j] = new Random().Next(-100, 100)/10;          
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + ",");  
        Console.WriteLine(); 
    }
}
*/
