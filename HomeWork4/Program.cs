// Задача 8: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int start = 2;
if (N < 2)
{
    Console.WriteLine(" до этого числа нет четных чисел");
}
if (N % 2 == 0)
{
    Console.Write(N + " -->   ");
    while (start <= N)
    {
        Console.Write(start);
        Console.Write("  ");
    start = start + 2;
    }
}
else
{   
    Console.Write(N + " -->   ");
    while (start <= N-1)
    {
        Console.Write(start);
        Console.Write("  ");
    start = start + 2;
    }
}

// Задача 2: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int a1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b1 = int.Parse(Console.ReadLine());
if (a1 == b1)
{
Console.WriteLine("Числа равны");   
}
else if (a1 > b1)
{
    Console.WriteLine("max = " + a1);  
}
else 
{
    Console.WriteLine("max = " + b1); 
}

// Задача 4: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите первое число");
int a2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c2 = int.Parse(Console.ReadLine());
int max = a2;
if (b2 > max) max = b2;
else if (c2 > max) max = c2;
Console.WriteLine("max = " + max);

// Задача 6: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
Console.WriteLine("Введите число, которое хотите проверить");
int A = int.Parse(Console.ReadLine());
if (A % 2 == 0)
{
    Console.WriteLine(A + "  - это число четное");
}
else
{
    Console.WriteLine(A + "  - это число нечетное");
}