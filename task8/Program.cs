// Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.WriteLine("Hello, World!");

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[]Array = new int[8];
for(int j = 0; j < Array.Length; j++)
{
    Array[j] = new Random().Next(-99,100);
}
Print(Array);

for(int p = 0; p < Array.Length; p++)
{
    if(Array[p] < 0)
    Array[p] = Array[p]*(-1);
}

Print(Array);

// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[]Arr = new int[8];
for(int k = 0; k < Arr.Length; k++)
{
    Arr[k] = new Random().Next(-100,100);
}
Print(Arr);

Console.Write("Введите число:   ");
int A = int.Parse(Console.ReadLine());
int a1 = 0;
for(int h = 0; h < Arr.Length; h++)
{
    if(Arr[h] == A) a1++;
}
if(a1 > 0) Console.Write($"Да это число есть в массиве {a1} раз   ");
else Console.Write("Данного числа нет  ");


// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[]Arr1 = new int[123];
for(int s = 0; s < Arr1.Length; s++)
{
    Arr1[s] = new Random().Next(-200,200);
}
Print(Arr1);

int count = 0;
for(int a = 0; a < Arr1.Length; a++)
{
   if( Arr1[a] >=10 & Arr1[a] <= 99) count++;
}
if(count > 0) Console.Write($"Да числа в промежутке от 10 до 99 есть в массиве {count} раз   ");
else Console.Write("Данного числа нет  ");

// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите количество элемонтов для задания массива  ");
int L = int.Parse(Console.ReadLine());
int[]Arr2 = new int[L];
for(int w = 0; w < Arr2.Length; w++)
{
    Arr2[w] = new Random().Next(-10,11);
}
Print(Arr2);
if(L % 2 == 0)
{
int[]ArrMult = new int[L/2];
int m = L-1;
for(int t = 0; t < L/2 ; t++)
{
    ArrMult[t] = Arr2[t]*Arr2[m];
    m--;
}
Print(ArrMult);
}
else
{
int[]ArrMult = new int[(L-1)/2];
int b=L-1;
for(int n1 = 0; n1 < (L-1)/2 ; n1++)
{
    ArrMult[n1] = Arr2[n1]*Arr2[b];
    b--;
}
Print(ArrMult);
}