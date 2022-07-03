// Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
Console.WriteLine("Введите до какого числа выводим натуральные числа");

int n = int.Parse(Console.ReadLine());

void rec(int n)
{
    if (n == 0) return;
    rec(n-1);
    Console.Write(n + " ");
}

rec(n);
Console.WriteLine();
// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

void PrintNumbers(int M, int N)
{
    if (M > N)
    {
        return;
    }
        Console.Write(M + " ");
        PrintNumbers(M + 1, N);

}
Console.WriteLine("Введите от какого числа выводим натуральные числа");

int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите до какого числа выводим натуральные числа");

int N = int.Parse(Console.ReadLine());
PrintNumbers(M, N);
Console.WriteLine();

// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число, сумму цифр которого хотите посчитать: ");
int num = int.Parse(Console.ReadLine());
int recursia(int n)
{
    if (n == 0)
    {
        return 0;
    }

  
    return n % 10 + recursia(n / 10);
}

Console.WriteLine("Сумма цифр числа: " + recursia(num)); 

// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число которое нужно возвести в степень:");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите степень в которую нужно возвести число:");
int B = int.Parse(Console.ReadLine());

double recurs(int A, int B)
{
    if (B == 0)
    {
        return 1;
    }
    if (B < 0)
    {
        return (1.0 / A) * recurs(A, B + 1);
    }
    else 
    return A * recurs(A, B - 1);
}

Console.WriteLine($"{A}  ^ {B} степени:  " + recurs(A, B));

