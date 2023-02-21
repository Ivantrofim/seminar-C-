// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
int mult = Multiplication(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {mult}");
}
else Console.WriteLine("Ошибка");


int Multiplication(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
             result = result * i;
        } 
    }
    return result;
}
