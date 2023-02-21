Console.WriteLine("Введите координаты точки 1");
Console.Write("X: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки 2");
Console.Write("X: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yb = Convert.ToInt32(Console.ReadLine());

double length = Length(xa, ya, xb, yb);
string result = $"Расстояние между точками равно {length}";
Console.WriteLine(result);

double Length(int x1, int y1, int x2, int y2)
{
    int x=x1-x2;
    int y=y1-y2;
    double s = Math.Sqrt(x * x + y * y);
    double roundS = Math.Round(s, 2, MidpointRounding.ToZero);
    return roundS;
}
// Задача 18: Напишите программу, 
// 1. которая по заданному номеру четверти, 
// 2. показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите четверть: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string result = QuarterFind(quarter);
if (quarter > 0 && quarter < 5)
{
    Console.WriteLine($"В указанной четверти координаты соответствуют следующим диапазонам: {result}");
}
else Console.WriteLine($"Четверть введена некоректно");

string QuarterFind(int q)
{
    if (q == 1) return "X>0, Y>0";
    if (q == 2) return "X<0, Y>0";
    if (q == 3) return "X<0, Y<0";
    if (q == 4) return "X>0, Y<0";
    return "";
}