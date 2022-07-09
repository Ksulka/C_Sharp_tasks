// Задайте значения M и N. Напишите программу, которая выведет все
// целые числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

void PrintNumbers(int M, int N)
{
    if (M == N)
    {
        Console.Write(M + " ");
        return;
    }

    if (M > N)
    {
        Console.Write(M + " ");
        PrintNumbers(M - 1, N);
        if (M == N)
        {
            Console.Write(M + " ");
            return;
        }
    }
    if (N > M)
    {
        if (M == N)
        {
            Console.Write(M + " ");
            return;
        }
        Console.Write(M + " ");
        PrintNumbers(M + 1, N);
    }
}
Console.WriteLine("Введите от какого числа выводим  числа");

int M = int.Parse(Console.ReadLine());

Console.WriteLine("Введите до какого числа выводим  числа");

int N = int.Parse(Console.ReadLine());
PrintNumbers(M, N);
Console.WriteLine();


// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите от какого числа считаем сумму натуральных чисел");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите до какого числа считаем сумму натуральных чисел");
int n = int.Parse(Console.ReadLine());
int temp = m;


if (m > n)
{
    m = n;
    n = temp;
}

if (n <= 0 | m <= 0)
{
    Console.WriteLine($"Натуральные числа больше 0!");
}
else
{
    int sum = (n * n - m * m + m + n) / 2;
    Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n} равна {sum}");
}

// Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
  else if (n == 0 && m>0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Write("Введите число m: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int b = int.Parse(Console.ReadLine());

Console.Write($" Функция Аккермана от {(a,b)} = {Akkerman(a, b)} ");


