// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
int number, index;

Console.Write("Введите число ");
number = Convert.ToInt32(Console.ReadLine());
index = 2;

while (index <= number)
{
    Console.WriteLine(index + " " );
    index = index +2;
}