// Напишите программу, которая
// 1. Выводит случайное трехзначное число
// 2. Удаляет вторую цифру этого числа

// 456 -> 46
// 782 -> 72
// 918 -> 98


int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 1000 без второй цифры -> {number}");
int firstDigit = number / 100;
int thirdDigit = number % 10;
int sum = firstDigit * 10 + thirdDigit;

Console.WriteLine(sum);