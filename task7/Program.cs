// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
int Func(int N)
{
int count = 0;

if(N == 0) count = 1;
else
{
int result = N;
while(result > 0)
{
    result = result/10;
    count++;
}
}
return count;
}

Console.WriteLine("Введите число");
int Num = int.Parse(Console.ReadLine());
Console.WriteLine(" Количество цифр в числе:   " + Func(Num));

// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.

int Factorial(int A)
{
    int F = 1;
    int i = 1;
    while(i <= A)
    {
        F = F * i;
        i++;
    }
    return F;
}

Console.WriteLine("Введите число");
int C = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение всех чисел от 1 до {C}:   " + Factorial(C));


// Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[]array = new int[8];
for(int i=0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,2);
}
void PrintArray(int[]collection)
{
    for(int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i] + "  ");
    }
}
PrintArray(array);