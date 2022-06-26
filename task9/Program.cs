// See https://aka.ms/new-console-template for more information
// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


Console.WriteLine("Введите первую сторону");
double A = double.Parse(Console.ReadLine());

Console.WriteLine("Введите вторую сторону");
double B = double.Parse(Console.ReadLine());

Console.WriteLine("Введите третью сторону");
double C = double.Parse(Console.ReadLine());

if(A < (B+C) && B<(A+C) && C < (A+B))
{
    Console.WriteLine("Треугольник с такими сторонами имеет место быть");
}
else
{
    Console.WriteLine("треугольника с такими сторонами не может быть");
}


// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите целое десятичное число");
int X = int.Parse(Console.ReadLine());

int count = 0;
int X2 = X;
while(X2 / 2 > 0)
{
    count++;
    X2 = X2 / 2;
}

int[]mass = new int [count+1];
int X1 = X;
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = X1%2;
    X1 = X1 / 2;
}

int save;
for (int i = 0; i < mass.Length / 2; i++)
{
    save = mass[i];
    mass[i] = mass[mass.Length - 1 - i];
    mass[mass.Length - 1 - i] = save;
}
Console.WriteLine($"{X} в двоичной системе будет:  ");
Print(mass);

// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите целое десятичное число");
int F = int.Parse(Console.ReadLine());

int[]arr = new int [F];
arr[0] = 0;
arr[1] = 1;

for (int k = 2; k < F; k++)
{
    arr[k] = arr[k-2] + arr[k-1];
}

Print(arr);

// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.


int[]massiv1 = new int[10];
int[]massiv2 = new int[10];
    for (int i1 = 0; i1 < massiv1.Length; i1++)
    {
        massiv1[i1] = new Random().Next(0,1000);
    }
Print(massiv1);
for (int j1 = 0; j1 < massiv2.Length; j1++)
{
    massiv2[j1] = massiv1[j1];
}
Print(massiv2);
