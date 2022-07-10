// Есть число N. Сколько групп M, можно получить при разбиении всех
// чисел на группы, так чтобы в одной группе все числа были взаимно просты (все
// числа в группе друг на друга не делятся)? Найдите M при заданном N и получите
// одно из разбиений на группы N ≤ 10²⁰.
// 25 мин
// Например, для N = 50, M получается 6

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());

int[] numbers = new int[N];
for (int i = 0; i < N; i++)
{
    numbers[i] = i + 1;
}
int M = (int)Math.Log(N, 2) + 1;
Console.WriteLine($"Д этого значения N можно сделать {M} разбиений");
int row = 1;
Console.WriteLine("Группа 1");
for (int i = 0; i < N; i++)
{

    Console.Write(numbers[i] + " ");
       if (numbers[i] == Math.Pow(2, row) -1)
    {
        Console.WriteLine();
        Console.WriteLine($"Группа {row+1}"); row++;}

}