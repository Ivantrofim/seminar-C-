Console.Write("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int LastNumber = number % 10;
    Console.WriteLine($"Последняя цифра числа - {LastNumber}");
}
else Console.WriteLine("Вы ввели НЕ трехзначное число!");
