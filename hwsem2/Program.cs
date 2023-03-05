// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// И на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

/*
void Number()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine("Cлучайное число " + num);

    int num1 = num / 10;
    int num2 = num1 / 10;
    int result = num1 % 10;

    Console.WriteLine("Вторая цифра " + result);
}
Number();
*/


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// Или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


void RandNum()
{
    int result = 0;
    int num = new Random().Next(10, 1000000);
    Console.WriteLine("Cлучайное число " + num);

    while (num > 999)
    {
      num = num / 10;
    }
    result = num % 10;
    Console.WriteLine("Третья цифра " + result);

    if (num <= 99)
       Console.WriteLine("Третьей цифры нет");
}
RandNum();





// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
/*
void WeekDay()
{
Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 5 && num < 8)
  Console.WriteLine("Это выходной день");
else
   if(num > 0 && num < 6)
     Console.WriteLine("Это будний день");
    else
     Console.WriteLine("Такого дня нет");   
}
WeekDay();
*/
