//ЗАДАЧИ НА МЕМИНАРЕ 3

//Координаты X / Y 


/*
void ShowArea(int quart)
{
    if(quart >= 1 && quart <= 4)
    {
        if(quart == 1) Console.WriteLine("In this quart x > 0 and y > 0");
        if(quart == 2) Console.WriteLine("In this quart x < 0 and y > 0");
        if(quart == 3) Console.WriteLine("In this quart x < 0 and y < 0");
        if(quart == 4) Console.WriteLine("In this quart x > 0 and y < 0");
    }
    else
        Console.WriteLine("This number is uncorrect");
}

Console.Write("Input quart: ");
int numQuart = Convert.ToInt32(Console.ReadLine());

ShowArea(numQuart);
*/


// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.



/*
Console.Write("Input x number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y number: ");
int y = Convert.ToInt32(Console.ReadLine());

void NumArea()
{
    if (x > 0 && y > 0) Console.WriteLine("1st quart");
    if (x < 0 && y > 0) Console.WriteLine("2nd quart");
    if (x < 0 && y < 0) Console.WriteLine("3rd quart");
    if (x > 0 && y < 0) Console.WriteLine("4th quart");
}
NumArea();
*/

//               Другое решение

/*
int Quart(int x, int y)
{
    int result = -1;
    if (x > 0 && y > 0) result = 1;
    if (x < 0 && y > 0) result = 2;
    if (x < 0 && y < 0) result = 3;
    if (x > 0 && y < 0) result = 4;
    return result;
}

Console.Write("Input x number: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y number: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Quart(x, y));
*/


// Напишите программу, которая принимает на вход число (N)  
// и выдаёт квадраты чисел от 1 до N.

void Quart(int x)
{
    int current = 1;
    while(current <= x)
    {
        int quart = current * current;
        Console.Write(quart + " ");
        current++;
    }
}
Console.Write("Inpet number: ");
int n = Convert.ToInt32(Console.ReadLine());
Quart(n);


