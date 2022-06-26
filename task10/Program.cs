
// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = 3, n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(-100, 100);
    }
}

Print(mass);
Console.WriteLine("");
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = mass[i, j] - 100;
    }
}

Print(mass);
Console.WriteLine("");
// Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int m1 = 3, n1 = 4;
int[,] mass1 = new int[m1, n1];

for (int i = 0; i < mass1.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass1[i, j] = i + j;
    }
}

Print(mass1);
Console.WriteLine("");
// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int a = 6, b = 7;
int[,] mass2 = new int[a, b];

for (int i = 0; i < mass2.GetLength(0); i++)
{
    for (int j = 0; j < mass2.GetLength(1); j++)
    {
        mass2[i, j] = new Random().Next(-100, 100);
    }
}

Print(mass2);
Console.WriteLine("");

for (int i = 0; i < mass2.GetLength(0); i=+2)
{
    for (int j = 0; j < mass2.GetLength(1); j=+2)
    {
        //if(j%2==0 && i%2==0)
        mass2[i, j] = mass2[i,j]*mass2[i,j];
    }
}
Print(mass2);

// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int a1 = 6, b1 = 7;
int[,] mass3 = new int[a1, b1];

for (int i = 0; i < mass3.GetLength(0); i++)
{
    for (int j = 0; j < mass3.GetLength(1); j++)
    {
        mass3[i, j] = new Random().Next(-10, 10);
    }
}

Print(mass3);

Console.WriteLine("");
int sum = 0;
for (int i = 0; i < Math.Min(mass3.GetLength(0), mass3.GetLength(1)); i++)
{
    //for (int j = 0; j < mass3.GetLength(1); j++)
    //{
        //if(i==j)
        sum=sum+mass3[i,i];
    //}
}
Console.WriteLine($"Сумма элементов по диагонали:  {sum}");
