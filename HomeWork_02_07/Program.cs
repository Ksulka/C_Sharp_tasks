
Console.WriteLine("Домашнее задание к семинару №8");

// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i,j] / 10 <= 0)
      Console.Write($" {arr[i,j]} ");

      else Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}


int[,] CreateArray(int n, int m)
{
    int[,] array = new int[n, m];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }

    }
    return array;
}


int[,] massiv = (CreateArray(5, 6));

PrintArray(massiv);
Console.WriteLine("");

for (int i = 0; i < massiv.GetLength(0); i++)
{
    int sorted = 0;
    int help = 0;
    while (sorted < massiv.GetLength(1))
    {
        int j = 0;
        while (j < massiv.GetLength(1) - 1 - sorted)
        {
            if (massiv[i, j] < massiv[i, j + 1])
            {
                help = massiv[i, j + 1];
                massiv[i, j + 1] = massiv[i, j];
                massiv[i, j] = help;
            }
            j++;
        }
        sorted++;
    }

}
PrintArray(massiv);
Console.WriteLine("");

// Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

int[,] array = (CreateArray(5, 6));

PrintArray(array);
Console.WriteLine("");
int[] sum = new int[array.GetLength(0)];
for (int i = 0; i < sum.Length; i++)
{
    for (int k = 0; k < array.GetLength(1); k++)
    {
        sum[i] = sum[i] + array[i, k];
    }
}
int min = sum[0];
int indexmin = 0;
for (int i = 0; i < sum.Length; i++)
{
    if (sum[i] < min)
    {
        min = sum[i];
        indexmin = i;
    }
}

Console.WriteLine($"Минимальная сумма элементов у строки с индексом {indexmin}  и она равна  {min}");
Console.WriteLine();
// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

int[,] matrix1 = (CreateArray(5, 6));
PrintArray(matrix1);
Console.WriteLine("");
int[,] matrix2 = (CreateArray(6, 5));
PrintArray(matrix2);
Console.WriteLine("");

int[,] matrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

for (int i = 0; i < matrix1.GetLength(0); i++)
{

    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix[i, j] = matrix1[i, j] * matrix2[j, i];
    }

}
PrintArray(matrix);
Console.WriteLine("");


// Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

Console.WriteLine("Введите ширину");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите высоту");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите глубину");
int z = int.Parse(Console.ReadLine());

int[,,] cube = new int[x, y, z];

int[] random = new int[cube.Length];
int number;
for (int i = 0; i < random.Length; i++)
{
    random[i] = new Random().Next(10, 100);
    number = random[i];
    if (i >= 1)
    {
        for (int j = 0; j < i; j++)
        {
            while (random[i] == random[j])
            {
                random[i] = new Random().Next(10, 100);
                j = 0;
                number = random[i];
            }
            number = random[i];
        }
    }
}

for (int j = 0; j < random.Length; j++)
{
Console.Write(random[j] + " ");
}
Console.WriteLine();
int count = 0;

for (int i = 0; i < cube.GetLength(0); i++)
{
    for (int j = 0; j < cube.GetLength(1); j++)
    {
        for (int k = 0; k < cube.GetLength(2); k++)
        {
            cube[i, j, k] = random[count];
            count++;
        }
    }
}

for (int i = 0; i < cube.GetLength(0); i++)
{
    for (int j = 0; j < cube.GetLength(1); j++)
    {
        
        for (int k = 0; k < cube.GetLength(2); k++)
        {
            Console.WriteLine($"({i}, {j}, {k}) = {cube[i, j, k]}; ");
        }
        
    }
   
}
Console.WriteLine();
// Заполните спирально массив 4 на 4.

// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10 9  8  7

int[,] spiral = new int[4,4];

int temp = 1;
int s = 0;
int w = 0;

while (temp <= spiral.GetLength(0) * spiral.GetLength(1))
{
  spiral[s, w] = temp;
  temp++;
  if (s <= w + 1 && s + w < spiral.GetLength(1) - 1)
    w++;
  else if (s < w && s + w >= spiral.GetLength(0) - 1)
    s++;
  else if (s >= w && s + w > spiral.GetLength(1) - 1)
    w--;
  else
    s--;
}

PrintArray(spiral);