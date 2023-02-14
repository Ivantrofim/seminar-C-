
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine);

if (MultiplycitiTwoNumbers(number)) Console.WriteLine("Да");
else Console.WriteLine("Нет");

bool MultiplycitiTwoNumbers(int num)
{
     return num % 7 == 0 && num % 23 == 0;
}

