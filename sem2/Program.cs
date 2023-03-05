// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.

int CutNumber()
{

  int num = new Random().Next(100, 1000);
  Console.WriteLine("current" + num);

  int sotni = num / 10;
  int ed = num % 10;

   int result = sotni * 10 + ed;
   return result;

}

int result = CutNumber();
Console.WriteLine("max number is " + result);


