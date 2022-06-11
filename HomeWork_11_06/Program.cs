// Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

Console.WriteLine("Введите трехзначное число");

int N = int.Parse(Console.ReadLine());

if (N < 100 | N > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    int n = N/10;
    n = n % 10;
    Console.WriteLine("Вторая цифра числа  " + n);
}

/*Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.*/

int weekday = new Random().Next(1,8);

if (weekday < 6)
{
    Console.WriteLine(weekday + "   - это будний день");
}
else
{
    Console.WriteLine(weekday + "   - выходной  день");
}