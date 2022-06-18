// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.

Console.WriteLine("Введите первое число");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число, оно должно быть натуральным");
int B = int.Parse(Console.ReadLine());
if(B <= 0)
{
    Console.WriteLine("Вы ввели не натуральное число");
}
else
{

// цикл с for

// int Pow = A;
// for(int i = 1; i < B, i++)
// {
//   Pow = Pow * A;
// }

// цикл с while

int i = 1;
int Pow = A;
while(i < B)
{
    Pow = Pow * A;
    i++;
}
Console.WriteLine($"{A} в степени {B} равно  " + Pow);
}

// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int sum = 0;
int N1 = N;
while(N1 > 0)
{
   sum = sum + N1 % 10;
   N1 = N1 / 10;
}
Console.WriteLine($"Сумма цифр в числе {N}  равна   " + sum);

// Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.

int[]Array = new int[8];
for(int j = 0; j < Array.Length; j++)
{
    Array[j] = new Random().Next(0,100);
}
void PrintArray(int[]collection)
{
    for( int g = 0; g < collection.Length; g++)
    {
        Console.Write(collection[g] + "  ");
    }
}
Console.WriteLine("Массив из 8 случайных чисел от 0 до 99 :");

PrintArray(Array);