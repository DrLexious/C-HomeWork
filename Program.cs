/*// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("enter a three-digit number: ");
int number = Convert.ToInt16(Console.ReadLine());
string stringNumber = Convert.ToString(number);
Console.Write("second digit this number is - "+stringNumber[1]);
*/
/*// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Enter a number: ");
int Number = Convert.ToInt16(Console.ReadLine());
string anyNumberText = Convert.ToString(Number);
if (anyNumberText.Length > 2)
{
  Console.WriteLine("Third digit is - " + anyNumberText[2]);
}
else 
{
  Console.WriteLine("...there is no third digit in this number");
}
*/
/*//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Enter a number for the day of the week: ");
int dayNum = Convert.ToInt16(Console.ReadLine());
void CheckingTheDayOfTheWeek (int dayNum) 
{
  if (dayNum == 6 || dayNum == 7) 
  {
  Console.WriteLine("this day is a day off");
  }
  else if (dayNum < 1 || dayNum > 7) 
  {
    Console.WriteLine("there is no such day of the week");
  }
  else Console.WriteLine("this day is not a day off");
}
CheckingTheDayOfTheWeek(dayNum);
*/