
Console.WriteLine("Hello, World!");


// Напишите программу, которая на вход принимает два числа и выдаёт
// первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26

int  RecFib(int first, int second, int num)
{
    if(num<=0) return 0;
    if(num==1) return first;
    if(num==2) return second;
    return RecFib(first, second, num-1) + RecFib(first, second, num-2);
}
Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество");
int N = int.Parse(Console.ReadLine());

for(int i = 1; i <= N; i++)
{
    Console.Write($"{RecFib(a,b,i)}  ");
}

// В некотором машинном алфавите имеются четыре буквы «а», «и», «с»
// и «в». Покажите все слова, состоящие из n букв, которые можно построить из
// букв этого алфавита.
// n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са,
// ав, ва, ви, ив, св, вс


string[] Words(string alpha, int length)
{
    string[] result;
    if (length <= 0)
    {
        result = new string[1];
        result[0] = String.Empty;
        return result;
    }

    string[] resultOld = Words(alpha, length - 1);


    result = new string[resultOld.Length * alpha.Length];
    int count = 0;
    for (int i = 0; i < resultOld.Length; i++)
    {
        for (int j = 0; j < alpha.Length; j++)
        {
            result[count] = resultOld[i] + alpha[j];
            count++;
        }
    }

    return result;
}
Console.WriteLine(" ");

int n = 4;
string alphabet = "пион";
string[] word;
word = Words(alphabet, n);

for (int i = 0; i < word.Length; i++)
{
    Console.Write((i + 1) + " " + word[i] + " ");
}

Console.WriteLine(" ");
// Заданы 2 массива: info и data. В массиве info хранятся двоичные
// представления нескольких чисел (без разделителя). В массиве data хранится
// информация о количестве бит, которые занимают числа из массива info.
// Напишите программу, которая составит массив десятичных представлений чисел
// массива data с учётом информации из массива info.
// 25 мин
// входные данные:
// - data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// - info = {2, 3, 3, 1 }
// выходные данные:
// - 1, 7, 0, 1
int [] data = {0, 1, 1, 1, 1, 0, 0, 0, 1 };
int [] info = {2, 3, 3, 1 };
int sum = 0;
int mult;
for (int i = 0; i < info.Length; i++)
{
    mult = 0;
    for (int j = sum; j < sum + info[i]; j++)
    {
        mult += data[j] * (int)Math.Pow(2, info[i] - j + sum - 1);
        
    }
    sum += info[i];
    Console.WriteLine(mult);
    Console.WriteLine(" ");
}