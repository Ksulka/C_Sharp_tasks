// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите целые числа через запятую без пробелов");
string m = Console.ReadLine();
string[] numbers = m.Split(',');
int[] array = new int[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{
    array[i] = int.Parse(numbers[i]);
}
int count = 0;
for (int j = 0; j < numbers.Length; j++)
{
    if (array[j] > 0) count++;
}
Console.WriteLine($"Количество введеных чисел больше 0:    {count}");


// Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями 
// y = k1 *x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

bool Intersect(double k1, double k2, double b1, double b2)
{
    if (k1 == k2) return false;
    else return true;
}

double IntersectKoordinaty(double k1, double k2, double b1, double b2)
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = k1 * x + b1;
    return x;
}

Console.WriteLine("Введите коэффициент k1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2");
double b2 = double.Parse(Console.ReadLine());

if (Intersect(k1, k2, b1, b2) == false)
{
    if (b1 == b2)
    { Console.WriteLine("Прямые совпадают и имеют бесконечное множество общих точек"); }
    else { Console.WriteLine("Прямые параллельны и не имееют общих точек"); }
}
else
{
    double x = IntersectKoordinaty(k1, k2, b1, b2);
    double y = k1 * x + b1;
    Console.WriteLine($"Прямые пересекаются в точке с координатами ({x};{y})");
}