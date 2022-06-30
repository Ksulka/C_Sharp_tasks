
// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine();
    }
}


double[,] CreateArray(int n, int m)
{
    double[,] array = new double[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) + Math.Round(new Random().NextDouble(), 2);
        }

    }
    return array;
}

PrintArray(CreateArray(4, 3));
Console.WriteLine("");


// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// (1,7) -> числа с такой позицией в массиве нет

double[,] massiv = CreateArray(10, 15);
PrintArray(massiv);
Console.WriteLine("Введите номер строки (нумерация начинается с 0");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца (нумерация начинается с 0");
int column = int.Parse(Console.ReadLine());
if (row < massiv.GetLength(0) && column < massiv.GetLength(1))
{
    Console.WriteLine($"Значение элемента на заданной позиции {massiv[row, column]}");
}
else
{
    Console.WriteLine($"числа с такой позицией в массиве нет");
}

// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine();
    }
}


int[,] massiv2 = new int[5, 6];

for (int i = 0; i < massiv2.GetLength(0); i++)
{
    for (int j = 0; j < massiv2.GetLength(1); j++)
    {
        massiv2[i, j] = new Random().Next(0, 20);
    }
}
Print(massiv2);

double Average(int j)
{
    double columnSum = 0;
    double average = 0;
    for (int i = 0; i < massiv2.GetLength(0); i++)
    {
        columnSum = columnSum + massiv2[i, j];
    }
    return average = columnSum/massiv2.GetLength(0);
}
for (int j = 0; j < massiv2.GetLength(1); j++)
{
    Console.WriteLine($"Среднее арифметическое {j} столбца:  {Average(j)}");
}

