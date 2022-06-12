/*Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка.*/

Console.WriteLine(" Введите X координату, но не 0");

double X = double.Parse(Console.ReadLine());

Console.WriteLine(" Введите Y координату, но не 0 ");

double Y = double.Parse(Console.ReadLine());

if (X == 0 | Y == 0)
{
  Console.WriteLine(" Координаты должны быть отличны от 0");  
}
else if (X > 0 & Y > 0)
{
    Console.WriteLine(" Координаты соответствуют первой четверти");
}
else if (X < 0 & Y > 0)
{
    Console.WriteLine(" Координаты соответствуют второй четверти");
}
else if (X < 0 & Y < 0)
{
    Console.WriteLine(" Координаты соответствуют третьей четверти");
}
else if (X > 0 & Y < 0)
{
    Console.WriteLine(" Координаты соответствуют четвертой четверти");
}

// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine(" Введите номер четверти: 1, 2, 3 или 4");

int Number = int.Parse(Console.ReadLine());

if (Number < 1 | Number > 4)
{
    Console.WriteLine("Вы ввели неверное значение");
}

if (Number == 1)
{
    Console.WriteLine(" Координаты X > 0, Y > 0");
}
else if (Number == 2)
{
    Console.WriteLine(" Координаты X < 0, Y > 0");
}
else if (Number == 3)
{
    Console.WriteLine(" Координаты X < 0, Y < 0");
}
else if (Number == 4)
{
    Console.WriteLine(" Координаты X > 0, Y < 0");
}

// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.

Console.WriteLine(" Введите X координату первой точки");

double X1 = double.Parse(Console.ReadLine());

Console.WriteLine(" Введите Y координату первой точки");

double Y1 = double.Parse(Console.ReadLine());

Console.WriteLine(" Введите X координату второй точки");

double X2 = double.Parse(Console.ReadLine());

Console.WriteLine(" Введите Y координату второй точки");

double Y2 = double.Parse(Console.ReadLine());

double R = Math.Round((Math.Sqrt(Math.Pow((X1-X2),2) + Math.Pow((Y1-Y2),2))),2);

Console.WriteLine(" Расстояние между точками  " + R);

//  Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.WriteLine(" Введите целое число, отличное от 0");

int N = int.Parse(Console.ReadLine());

if (N == 0)
{
    Console.WriteLine("Вы ввели неверное значение");
}

else if (N < 0)
{
    int i = N;
    while (i < 0)
    {
        Console.Write("   " + -Math.Pow(i,2));
        i++;
    }
}
else if (N > 0)
{
    int i = 1;
    while (i <= N)
    {
        Console.Write("   " + Math.Pow(i,2));
        i++;
    }
}
