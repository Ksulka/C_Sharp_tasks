// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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

int[,] array = new int[5, 5];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
    }
}
Print(array);
Console.WriteLine();
int help = 0;
for (int j = 0; j < array.GetLength(1); j++)

{
    help = array[0, j];
    array[0, j] = array[array.GetLength(1) - 1, j];
    array[array.GetLength(1) - 1, j] = help;
}
Print(array);
Console.WriteLine();

// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }

    }
    return array;
}
Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());
if (m == n)
{
    int[,] mass = new int[m, n];
    mass = CreateArray(m, n);
    Print(mass);
    Console.WriteLine();

    int res = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            res = mass[i, j];
            mass[i, j] = mass[j, i];
            mass[j, i] = res;
        }
    }
    Print(mass);
    Console.WriteLine();
}
else
{
    Console.WriteLine("Невозможно поменять местами столбцы и строки, т.к. массив не квадратный");
}

//  Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 } 
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

int Count(int[,] arr, int value)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == value) count++;
        }
    }
    return count;
}

Console.WriteLine("Введите количество строк");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк");
int column = int.Parse(Console.ReadLine());

int[,] massiv = new int[row, column];
massiv = CreateArray(row, column);
Print(massiv);

int[] arrStorage = new int[massiv.Length];
int k = 0;
bool finded = false;
for (int i = 0; i < massiv.GetLength(0); i++)
{
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        finded = false;
        for (int l = 0; l < k; l++)
        {
            if (arrStorage[l] == massiv[i, j])
            {
                finded = true;
                break;
            }
        }
        if (!finded)
        {
            arrStorage[k] = massiv[i, j];
            k++;
        }
    }

}
Console.WriteLine(" ");
for (int i = 0; i < k; i++)
{
    Console.WriteLine($"{arrStorage[i]} встречается {Count(massiv, arrStorage[i])}   раз(а)");
}

// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7
int[,] massiv1 = new int[5, 6];
massiv1 = CreateArray(5, 6);
Print(massiv1);

int min = massiv1[0, 0];
int r = 0;
int c = 0;
for (int i = 0; i < massiv1.GetLength(0); i++)
{
    for (int j = 0; j < massiv1.GetLength(1); j++)
    {
        if (massiv1[i, j] < min)
        {
            min = massiv[i, j];
            r = i;
            c = j;
        }
    }
}
int[,] newarray = new int[massiv1.GetLength(0) - 1, massiv1.GetLength(1) - 1];
for (int i = 0; i < massiv1.GetLength(0); i++)
{
    for (int j = 0; j < massiv1.GetLength(1); j++)

    {
        if (!(i == r) && !(j == c))
        {
            int k1 = i;
            if (i > r) k1 = i - 1;
            int l1 = j;
            if (l1 > c) l1 = j - 1;
            newarray[k1, l1] = massiv1[i, j];
        }
    }
}
Print(newarray);