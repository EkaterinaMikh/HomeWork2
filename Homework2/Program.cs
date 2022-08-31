//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

/*Console.WriteLine("Введите трёхзначное число: ");

int num = Convert.ToInt32(Console.ReadLine());

string stringNum = Convert.ToString(num);

Console.WriteLine("Вторая цифра числа: " + stringNum[1]);
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/*Console.WriteLine("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

string num1 = Convert.ToString(num);

if (num1.Length > 2)
{
    Console.WriteLine("Третья цифра введенного числа: " + num1[2]);
}
else 
{
    Console.WriteLine("Третьей цифры в числе нет");
}*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*Console.Write("Введите цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

void DayOfTheWeek (int num) {

  if (num == 6 || num == 7)
  {
  Console.WriteLine("Это выходной");
  }
  
  else if (num >=1 && num < 6)

{
  Console.WriteLine("Нет, это будний день");
}
}
DayOfTheWeek(num);*/
