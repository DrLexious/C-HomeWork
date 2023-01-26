/*//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }
    int[] numbers = new int [count];
    int index = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";
        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}

void ShowArray(int[] array)
{
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}

Console.Write("Enter numbers separated by comma: ");
int[] numbers = StringToNum(Console.ReadLine());
ShowArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine($"Numbers greater than 0: {sum}");
*/

/*//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Enter b1: ");
float b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter k1: ");
float k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b2: ");
float b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter k2: ");
float k2 = Convert.ToInt32(Console.ReadLine());

float x = (-b2+b1)/(-k1+k2);
float y = k2*x+b2;

Console.WriteLine($"Two straight lines intersect in point X: {x}, Y: {y}");
*/
