﻿//Является ли одно число квадратом второго


Console.WriteLine("Введите первое число ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

if (Square (FirstNumber, SecondNumber)) Console.WriteLine("Да");
else Console.WriteLine("Нет");

bool Square(int num1, int num2)
{
    return num1 == num2 * num2 || num1 == num2 * num2; 

}
