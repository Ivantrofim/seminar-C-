﻿// Напишите программу, которая:

// 1. будет принимать на вход два числа и выводить, является ли первое число
// кратным второму. 

// 2. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 != 0)
Console.WriteLine($"Некратно, остаток {num1 % num2}");
else
Console.WriteLine("Кратно");
