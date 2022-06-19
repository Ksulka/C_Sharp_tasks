// Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве. [345, 897, 568, 234] -> 2


void PrintArray(int[]collection)
{
    for( int j = 0; j < collection.Length; j++)
    {
        Console.Write(collection[j] + "  ");
    }
}

void PrintArrayDouble(double[]coll)
{
    for( int j1 = 0; j1 < coll.Length; j1++)
    {
        Console.Write(coll[j1] + "  ");
    }
}



Console.WriteLine("Массив из 8 случайных чисел от 100 до 999 :");

int[]Array = new int[8];
for(int i = 0; i < Array.Length; i++)
{
    Array[i] = new Random().Next(100,1000);
}

PrintArray(Array); 

int even = 0;
for( int k = 0; k < Array.Length; k++)
    {
        if(Array[k] % 2 ==0) even++;
    }

Console.WriteLine($" Колличество четных чисел в массиве:   {even}");    

// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[]Array1 = new int[10];
for(int h = 0; h < Array1.Length; h++)
{
    Array1[h] = new Random().Next(-100,101);
}

PrintArray(Array1);
int sum = 0;
for(int v = 1; v < Array1.Length; v = v + 2)
{
    sum = sum + Array1[v];
}

Console.WriteLine($" Сумма элементов, стоящих на нечетных позициях:   {sum}");   

// Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76

double[]Array2 = new double[10];
for(int h1 = 0; h1 < Array2.Length; h1++)
{
    Array2[h1] = new Random().NextDouble() * 100;
}
PrintArrayDouble(Array2);
double max = Array2[0];
double min = Array2[0];
for(int h2 = 0; h2 < Array2.Length; h2++)
{
    if(Array2[h2] > max) max = Array2[h2];
    if(Array2[h2] < min) min = Array2[h2];
}
Console.WriteLine($" Разница между максимальным и минимальным элементами массива    {max - min}");