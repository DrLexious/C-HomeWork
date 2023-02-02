/*//Задача 54:Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateRandom2DArray()
{
    Console.Write("Input number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows,colums];
    for(int i=0; i<rows; i++)
        for(int j=0; j<colums; j++)
            array[i,j] = new Random().Next(minValue,maxValue+1);
    return array;
}

void Show2DArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+"\t");
        Console.WriteLine();
    }
}
void SortLines(int[,] array)
{
  for (int i=0; i<array.GetLength(0); i++)
    for (int j=0; j<array.GetLength(1); j++)
      for (int k=0; k<array.GetLength(1) - 1; k++)
        if (array[i,k] < array[i, k+1])
        {
          int temp = array[i, k+1];
          array[i, k+1] = array[i, k];
          array[i, k] = temp;
        }  
}

int[,] newArray = CreateRandom2DArray();
Show2DArray(newArray);
Console.WriteLine();
SortLines(newArray);
Show2DArray(newArray);
*/

/*//Задача 56:Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void CreateRandom2DArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
        for(int j=0; j<array.GetLength(1); j++)
            array[i,j] = new Random().Next(1,10);
}

void Show2DArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+"\t");
        Console.WriteLine();
    }
}


Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
CreateRandom2DArray(array);
Show2DArray(array);

int minSumStr = 0;
int sumLine = SumStr(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSum = SumStr(array, i);
  if (sumLine > tempSum)
  {
    sumLine = tempSum;
    minSumStr = i;
  }
}

Console.WriteLine($"Line {minSumStr+1} :minimum sumary of elements in this line is: ({sumLine})");

int SumStr(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}
*/
/*//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void CreateRandom2DArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
        for(int j=0; j<array.GetLength(1); j++)
            array[i,j] = new Random().Next(1,10);
}

void Show2DArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+"\t");
        Console.WriteLine();
    }
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums in first array: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums in second array: ");
int p = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = new int[m, n];
int[,] secondArray = new int[n, p];
CreateRandom2DArray(firstArray);
Show2DArray(firstArray);
Console.WriteLine();
CreateRandom2DArray(secondArray);
Show2DArray(secondArray);

void MultiplyArray(int[,] firstArray, int[,] secondArray, int[,] multiArray)
{
    for(int i=0; i<multiArray.GetLength(0); i++)
        for(int j=0; j<multiArray.GetLength(0); j++)
        {
            int sum=0;
            for(int k=0; k<firstArray.GetLength(1); k++)
            {
                sum+=firstArray[i,k]*secondArray[k,j];
            }
            multiArray[i,j] =sum;
        }
}

Console.WriteLine();
int[,] multiArray = new int[m, p];
MultiplyArray(firstArray, secondArray, multiArray);
Show2DArray(multiArray);
*/
/*//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


void Create3DArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
      for (int j = 0; j < i; j++)
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
        number = temp[i];
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
    for (int y = 0; y < array3D.GetLength(1); y++)
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
}
void Snow3DArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
        Console.Write($"X({i}) Y({j}) ");
        for (int k = 0; k < array3D.GetLength(2); k++)
        {
            Console.Write( $"Z({k})={array3D[i,j,k]}; ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.WriteLine($"Enter 3D Array X x Y x Z:");
Console.Write($"Enter X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write($"Enter Z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] array3D = new int[x, y, z];
Create3DArray(array3D);
Snow3DArray(array3D);
*/

/*//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] spiralArray = new int[4, 4];
int temp = 1;
int i = 0;
int j = 0;
while (temp <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
{
  spiralArray[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < spiralArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= spiralArray.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > spiralArray.GetLength(1) - 1)
    j--;
  else
    i--;
}

ShowArray(spiralArray);

void ShowArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");
      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
*/
