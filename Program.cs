/*// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Enter a five-digit number: ");
string? number = Console.ReadLine();
if (number!.Length == 5)
{
    CheckingNumber(number);
    void CheckingNumber(string number)
    {
        if (number[0]==number[4] || number[1]==number[3])
        {
            Console.WriteLine($"Number: {number} - is palindrome.");
        }
        else Console.WriteLine($"Number: {number} - is not a palindrome");
    }
}
else Console.WriteLine("This number is not five digits");
*/

/*//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int xA = Coordinate("x", "A");
int yA = Coordinate("y", "A");
int zA = Coordinate("z", "A");
int xB = Coordinate("x", "B");
int yB = Coordinate("y", "B");
int zB = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Enter coordinate {coorName} of point {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}
double Decision(double xA, double xB, 
                double yA, double yB, 
                double zA, double zB)
{
  return Math.Sqrt(Math.Pow((xB-xA), 2) + 
                   Math.Pow((yB-yA), 2) + 
                   Math.Pow((zB-zA), 2));
}
double segmentLength=Math.Round(Decision(xA, xB, yA, yB, zA, zB), 2);
Console.WriteLine($"Segment length  {segmentLength}");
*/

/*//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Enter a number: ");
int square = Convert.ToInt32(Console.ReadLine());

void Square(int[] square)
{
  int counter = 0;
  int length = square.Length;
  while (counter < length)
  {
    square[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  while(index < count)
  {
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[square+1];
Square(arry);
PrintArry(arry);
*/
