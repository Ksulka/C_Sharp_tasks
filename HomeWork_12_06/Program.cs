// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
Console.WriteLine("Введите пятизначное число");

int num = int.Parse(Console.ReadLine());

if (num < 10000 | num > 99999)
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
else
{
int num1 = num/10000;
int num2 = (num/1000) % 10;
int num4 = (num/10) % 10;
int num5 = num % 10;

if ((num1 == num5) & (num2 == num4))
{
    Console.WriteLine(num + " - это число является палиндромом");
}
else 
{
    Console.WriteLine(num + " - это число не является палиндромом");
}
}

// Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.

Console.WriteLine(" Введите X координату первой точки");

double X1 = double.Parse(Console.ReadLine());

Console.WriteLine(" Введите Y координату первой точки");

double Y1 = double.Parse(Console.ReadLine());

Console.WriteLine(" Введите Z координату первой точки");

double Z1 = double.Parse(Console.ReadLine());

Console.WriteLine(" Введите X координату второй точки");

double X2 = double.Parse(Console.ReadLine());

Console.WriteLine(" Введите Y координату второй точки");

double Y2 = double.Parse(Console.ReadLine());

Console.WriteLine(" Введите Z координату второй точки");

double Z2 = double.Parse(Console.ReadLine());

double R = Math.Round((Math.Sqrt(Math.Pow((X1-X2),2) + Math.Pow((Y1-Y2),2) + Math.Pow((Z1-Z2),2))),2);

Console.WriteLine(" Расстояние между точками  " + R);

// Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

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
        Console.Write("   " + Math.Pow(i,3));
        i++;
    }
}
else if (N > 0)
{
    int i = 1;
    while (i <= N)
    {
        Console.Write("   " + Math.Pow(i,3));
        i++;
    }
}
