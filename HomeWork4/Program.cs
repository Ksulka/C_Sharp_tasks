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